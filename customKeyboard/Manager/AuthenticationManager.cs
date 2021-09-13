using customKeyboard.Contracts;
using customKeyboard.DataTransferObjects;
using customKeyboard.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace customKeyboard.Manager
{
    public class AuthenticationManager : IAuthenticationManager
    {
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;
    private User _user;

    public AuthenticationManager(UserManager<User> userManager, IConfiguration configuration)
    {
      _userManager = userManager;
      _configuration = configuration;
    }
    public async Task<bool> ValidateUser(UserForAuthenticationDto userForAuth)
    {
      _user = await _userManager.FindByNameAsync(userForAuth.Email);

      return (_user != null && await _userManager.CheckPasswordAsync(_user, userForAuth.Password));
    }

    public async Task<string> CreateToken()
    {
      // all of these method will get created in this Class;
      var signingCredentials = GetSigningCredentials();
      var claims =  await GetClaims();
      var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

      return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
    }

    public SigningCredentials GetSigningCredentials() 
    {
      var key = Encoding.UTF8.GetBytes("SocialMediaWebAPISecret");
      var secret = new SymmetricSecurityKey(key);
      return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
    }
    public async Task<List<Claim>> GetClaims()
    {
      var claims = new List<Claim>
      {
        new Claim("username", _user.UserName),
        new Claim("email", _user.Email),
        new Claim("id", _user.Id)
      };

      var roles = await _userManager.GetRolesAsync(_user);
      foreach(var role in roles)
      {
        claims.Add(new Claim(ClaimTypes.Role, role));
      }
      return claims; 
    }

    public JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
    {
      //this is pulling the configuration out of the appsettings.json
      var jwtSettings = _configuration.GetSection("JwtSettings");
      var tokenOptions = new JwtSecurityToken
      (
        issuer: jwtSettings.GetSection("validIssuer").Value,
        audience: jwtSettings.GetSection("validAudience").Value,
        claims: claims,
        expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings.GetSection("expires").Value)),
        signingCredentials: signingCredentials
      );

      return tokenOptions; 
    }
  }
}