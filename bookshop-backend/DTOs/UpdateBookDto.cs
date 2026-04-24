using System.ComponentModel.DataAnnotations;

namespace bookshop_backend.DTOs
{
    public class UpdateBookDto
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
