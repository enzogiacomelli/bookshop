using bookshop_backend.DTOs;
using bookshop_backend.Models;

namespace bookshop_backend.Services
{
    public interface ICategoryService
    {
        Category CreateCategory(CreateCategoryDto createCategoryDto);

        List<Category> GetAllCategories();
    }
}
