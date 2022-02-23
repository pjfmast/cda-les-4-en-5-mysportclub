using System.ComponentModel.DataAnnotations;

namespace MySportsClub.Models
{
    // todo lesson 4-05. Create a ViewModel for registering a new user:
    public class RegisterUserViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        [UIHint("email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirmed password is not equal to password.")]
        public string ConfirmedPassword { get; set; }
    }

}
