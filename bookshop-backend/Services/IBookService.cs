using bookshop_backend.DTOs;
using bookshop_backend.Models;

namespace bookshop_backend.Services
{
    public interface IBookService
    {
        Book CreateBook(CreateBookDto createBookDto);
        Task<BookDto> GetByIdAsync(int id);      
        Task<List<BookDto>> GetAllAsync();
    }
}
