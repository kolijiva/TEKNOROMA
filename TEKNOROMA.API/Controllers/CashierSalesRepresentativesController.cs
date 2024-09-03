using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.API.Controllers
{
    [Authorize(Roles = "Admin, CashierSalesRepresentative")]
    [Route("api/[controller]")]
    [ApiController]
    public class CashierSalesRepresentativesController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;
        private readonly IOrderItemService _orderItemService;

        public CashierSalesRepresentativesController(ICustomerService customerService, IOrderService orderService, IOrderItemService orderItemService)
        {
            _customerService = customerService;
            _orderService = orderService;
            _orderItemService = orderItemService;
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomersByIdentity(string id)
        {
            var result = _customerService.GetCustomerByIdentity(id);

            if (result == null)
            {
                return NotFound();
            }

            var customerDto = new CustomerDto
            {
                IdentificationNumber = result.IdentificationNumber,
                FirstName = result.FirstName,
                LastName = result.LastName,
                Gender = result.Gender.ToString(),
                Email = result.Email
            };

            return Ok(customerDto);
        }

        [HttpPost("Satış")]
        public async Task<IActionResult> CreateOrder([FromBody] AddOrderDto order)
        {
            var orderItemEntity = new OrderItem()
            {
                ProductID = order.ProductID,
                OrderID = order.OrderID,
                Quantity = order.Quantity,
                UnitPrice = order.UnitPrice
            };

            var result = await _orderItemService.CreateOrderItem(orderItemEntity);
            return Ok(result);
        }

        [HttpGet("Satış Takip Raporu")]
        public IActionResult GetOrders()
        {
            var result = _orderService.GetOrders();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
