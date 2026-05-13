using bookshop_backend.Models;

namespace bookshop_backend.Repositories
{
    public interface ICategoryRepository
    {
        Task <Category> GetByIdAsync(string id);

        Task<int> CreateAsync(Category category);
    }
}
