using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.API.Controllers
{
    [Authorize(Roles = "Admin, BranchManager")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var result = _categoryService.GetAllCategoryDtos();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = _categoryService.GetCategoryById(id);

            if (category is null)
            {
                return NotFound();
            }
            else
            {
                var categoryDto = new CategoryDto
                {
                    CategoryName = category.CategoryName,
                    Description = category.Description
                };
                return Ok(categoryDto);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryDto category)
        {
            var categoryEntity = new Category()
            {
                CategoryName = category.CategoryName,
                Description = category.Description
            };

            var result = await _categoryService.CreateCategory(categoryEntity);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryDto category)
        {
            var categoryEntity = new Category()
            {
                ID = id,
                CategoryName = category.CategoryName,
                Description = category.Description
            };
            var result = await _categoryService.UpdateCategory(categoryEntity);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = _categoryService.GetCategoryById(id);

            if (category == null)
            {
                return NotFound();
            }

            var result = await _categoryService.DeleteCategory(category);
            return Ok(result);
        }
    }
}
