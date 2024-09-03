using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Abstracts
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrderById(int id);
        Task<string> CreateOrder(Order order);
        Task<string> DeleteOrder(Order order);
        Task<string> UpdateOrder(Order order);
        IEnumerable<OrderProductSupplierDto> GetOrderProductSupplierInfo();
        IEnumerable<TopProductDto> GetTopProducts();
        IEnumerable<OrderDetailDto> GetOrderDetails();
        IEnumerable<OrderDto> GetOrders();
        IEnumerable<StockPriceOrderDto> GetStockPriceOrders();
    }
}
