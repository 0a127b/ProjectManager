using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManager.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }  

        public Project()
        {
            Title = string.Empty;
            Description = string.Empty;
        }
    }
}
