using System.ComponentModel.DataAnnotations;

namespace ProjectManager.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Treść komentarza jest wymagana")]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int ProjectId { get; set; }
        public Project? Project { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
