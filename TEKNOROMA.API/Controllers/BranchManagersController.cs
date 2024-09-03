using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.MODEL.DTOs;
namespace TEKNOROMA.API.Controllers
{
    [Authorize(Roles = "Admin, BranchManager")]
    [Route("api/[controller]")]
    [ApiController]
    public class BranchManagersController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IEmployeeService _employeeService;

        public BranchManagersController(IProductService productService, IOrderService orderService, IEmployeeService employeeService)
        {
            _productService = productService;
            _orderService = orderService;
            _employeeService = employeeService;
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

        [HttpGet("Ürün Liste Raporu")]
        public IActionResult GetAllProducts()
        {
            var result = _productService.GetAllProductDtos();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("Tedarikçi Hareket Raporu")]
        public IActionResult GetOrderProductSupplierInfo()
        {
            var result = _orderService.GetOrderProductSupplierInfo();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("Satış Takip Raporu")]
        public IActionResult GetTopProducts()
        {
            var result = _orderService.GetTopProducts();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("Gider Raporu")]
        public IActionResult GetEmployeePayments()
        {
            var result = _employeeService.GetEmployeePayments();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
