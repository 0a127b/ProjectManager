using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectManager.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
