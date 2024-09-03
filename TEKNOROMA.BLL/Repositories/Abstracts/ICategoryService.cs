using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Abstracts
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        Task<string> CreateCategory(Category category);
        Task<string> DeleteCategory(Category category);
        Task<string> UpdateCategory(Category category);
        IEnumerable<CategoryDto> GetAllCategoryDtos();
    }
}
