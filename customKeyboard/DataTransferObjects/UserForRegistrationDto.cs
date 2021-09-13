using System.ComponentModel.DataAnnotations;

namespace customKeyboard.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        public string UserName { get; set; }

    [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        
    }
}