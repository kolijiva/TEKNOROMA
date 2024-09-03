using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Abstracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        Task<string> CreateProduct(Product product);
        Task<string> DeleteProduct(Product product);
        Task<string> UpdateProduct(Product product);
        public IEnumerable<ProductDto> GetAllProductDtos();
    }
}
