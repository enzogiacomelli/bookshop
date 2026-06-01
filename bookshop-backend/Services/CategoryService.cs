using bookshop_backend.DTOs;
using bookshop_backend.Models;
using bookshop_backend.Repositories;
using System.Linq;

namespace bookshop_backend.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var category = new Category
            {
                Name = createCategoryDto.Name
            };

            _categoryRepository.CreateAsync(category);
            return category;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            var categories = new List<Category>();
            categories = await _categoryRepository.GetAllAsync();

            return categories;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
           var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null) return null;
            return category;
        }
    }
}
