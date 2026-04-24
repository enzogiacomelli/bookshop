using bookshop_backend.Models;

namespace bookshop_backend.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetByIdAsync(string id);

        Task<int> CreateAsync(Book book);
    }
}
