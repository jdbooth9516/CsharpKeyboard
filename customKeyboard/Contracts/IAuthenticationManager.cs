using customKeyboard.DataTransferObjects;
using System.Threading.Tasks;


namespace customKeyboard.Contracts
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
    }
}