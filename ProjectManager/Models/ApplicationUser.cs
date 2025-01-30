using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProjectManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Nazwa wyświetlana")]
        public string DisplayName { get; set; } = string.Empty;

        // Relacje
        public ICollection<Project>? Projects { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
}
