using System.ComponentModel.DataAnnotations;

namespace Apibodega.Shared.Entity
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}