using System.ComponentModel.DataAnnotations;

namespace ProjectManager.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty; 

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty; 

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = string.Empty; 
    }
}