using System.ComponentModel.DataAnnotations;

namespace bookshop_backend.DTOs
{
    public class CreateCategoryDto
    {
        [Required]
        public string Name { get; set; }
    }
}
