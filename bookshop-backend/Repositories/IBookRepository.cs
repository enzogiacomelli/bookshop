using bookshop_backend.Models;

namespace bookshop_backend.Repositories
{
    public class IBookRepository
    {
        public async Task<Book> GetByIdAsync(string id);

        public async Task<int> CreateAsync(Book book);
    }
}
