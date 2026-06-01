using bookshop_backend.Models;

namespace bookshop_backend.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetByIdAsync(int id);

        Task<List<Book>> GetAllAsync();

        Task<int> CreateAsync(Book book);
    }
}
