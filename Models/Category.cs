using System.ComponentModel.DataAnnotations;

namespace Sanket_web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public String Name { get; set; }
        [Range(1,100)]
        public int AddToCart { get; set; }
    }
}
