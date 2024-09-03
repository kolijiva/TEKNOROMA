using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Concretes
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Category> _categoryRepository;

        public ProductService(IRepository<Product> productRepository, IRepository<Category> categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public async Task<string> CreateProduct(Product product)
        {
            return await _productRepository.Create(product);
        }

        public async Task<string> DeleteProduct(Product product)
        {
            return await _productRepository.Delete(product);
        }

        public async Task<string> UpdateProduct(Product product)
        {
            return await _productRepository.Update(product);
        }

        public IEnumerable<ProductDto> GetAllProductDtos()
        {
            var result = (from p in _productRepository.GetAll()
                          join c in _categoryRepository.GetAll() on p.CategoryID equals c.ID
                          select new ProductDto
                          {
                              ProductName = p.ProductName,
                              CategoryName = c.CategoryName,
                              Description = p.Description,
                              Price = p.Price,
                          }).ToList();

            return result;
        }
    }
}
