using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.API.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var result = _productService.GetAllProductDtos();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetProductById(id);

            if (product is null)
            {
                return NotFound();
            }
            else
            {
                var productDto = new ProductDto
                {
                    ProductName = product.ProductName,
                    Description = product.Description,
                    Price = product.Price,
                };
                return Ok(productDto);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] AddProductDto product)
        {
            var productEntity = new Product()
            {
                ProductName = product.ProductName,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                CategoryID = product.CategoryID,
                SupplierID = product.SupplierID,
            };

            var result = await _productService.CreateProduct(productEntity);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] AddProductDto productDto)
        {
            var productEntity = new Product()
            {
                ID = id,
                ProductName = productDto.ProductName,
                Description = productDto.Description,
                Price = productDto.Price,
                StockQuantity = productDto.StockQuantity,
                CategoryID = productDto.CategoryID,
                SupplierID = productDto.SupplierID
            };
            var result = await _productService.UpdateProduct(productEntity);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            var result = await _productService.DeleteProduct(product);
            return Ok(result);
        }
    }
}
