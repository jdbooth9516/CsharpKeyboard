using Microsoft.AspNetCore.Identity; 


namespace customKeyboard.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}