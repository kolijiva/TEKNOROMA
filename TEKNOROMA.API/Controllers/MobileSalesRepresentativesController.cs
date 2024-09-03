using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.API.Controllers
{
    [Authorize(Roles = "Admin, MobileSalesRepresentative")]
    [Route("api/[controller]")]
    [ApiController]
    public class MobileSalesRepresentativesController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IOrderItemService _orderItemService;

        public MobileSalesRepresentativesController(IOrderService orderService, IOrderItemService orderItemService)
        {
            _orderService = orderService;
            _orderItemService = orderItemService;
        }

        [HttpGet("Stok Durumu,Fiyat Ve Satış")]
        public IActionResult GetStockPriceOrders()
        {
            var result = _orderService.GetStockPriceOrders();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
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
    }
}
