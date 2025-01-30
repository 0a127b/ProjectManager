using System.ComponentModel.DataAnnotations;

namespace ProjectManager.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa kategorii jest wymagana")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

    }
}
