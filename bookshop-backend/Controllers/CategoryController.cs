using bookshop_backend.DTOs;
using bookshop_backend.Models;
using bookshop_backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookshop_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Post(CreateCategoryDto dto)
        {
            try
            {
                _categoryService.CreateCategory(dto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("get-all")]
        public IActionResult GetAll()
        {
            try
            {
                var categories = new List<Category>();
                categories = _categoryService.GetAllCategories();

                return Ok(categories);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
