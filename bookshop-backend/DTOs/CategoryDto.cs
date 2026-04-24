using System.ComponentModel.DataAnnotations;

namespace bookshop_backend.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
