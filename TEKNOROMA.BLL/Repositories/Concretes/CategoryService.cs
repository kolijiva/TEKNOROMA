using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<string> CreateCategory(Category category)
        {
            return await _categoryRepository.Create(category);
        }

        public async Task<string> DeleteCategory(Category category)
        {
            return await _categoryRepository.Delete(category);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public async Task<string> UpdateCategory(Category category)
        {
            return await _categoryRepository.Update(category);
        }

        public IEnumerable<CategoryDto> GetAllCategoryDtos()
        {
            var categories = _categoryRepository.GetAll();
            var catgoriesDto = categories.Select(x => new CategoryDto
            {
                CategoryName = x.CategoryName,
                Description = x.Description
            });
            return catgoriesDto;
        }
    }
}
