using bookshop_backend.DTOs;
using bookshop_backend.Models;
using bookshop_backend.Repositories;

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

        public List<Category> GetAllCategories()
        {
            var categories = new List<Category>();
            categories = _categoryRepository.GetAllAsync().Result;

            return categories;
        }

    }
}
