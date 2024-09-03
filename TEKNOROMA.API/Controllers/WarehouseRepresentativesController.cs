using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.MODEL.DTOs;
namespace TEKNOROMA.API.Controllers
{
    [Authorize(Roles = "Admin, WarehouseRepresentative")]
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseRepresentativesController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;

        public WarehouseRepresentativesController(IOrderService orderService, IProductService productService)
        {
            _orderService = orderService;
            _productService = productService;
        }

        [HttpGet("Satış Takip Raporu")]
        public IActionResult GetOrderDetails()
        {
            var result = _orderService.GetOrderDetails();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("Stok Takip Raporu")]
        public IActionResult GetProductStocks()
        {
            var products = _productService.GetAllProducts().ToList();
            var stockDtos = products.Select(p => new StockDto
            {
                ProductName = p.ProductName,
                StockQuantity = p.StockQuantity
            });

            return Ok(stockDtos);
        }
    }
}
