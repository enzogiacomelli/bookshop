using bookshop_backend.Models;

namespace bookshop_backend.Repositories
{
    public interface ICategoryRepository
    {
        Task <Category> GetByIdAsync(int id);

        Task<int> CreateAsync(Category category);

        Task<List<Category>> GetAllAsync();
    }
}
