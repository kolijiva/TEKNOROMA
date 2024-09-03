using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Abstracts
{
    public interface IOrderItemService
    {
        IEnumerable<OrderItem> GetAllOrderItems();
        OrderItem GetOrderItemById(int id);
        Task<string> CreateOrderItem(OrderItem orderItem);
        Task<string> DeleteOrderItem(OrderItem orderItem);
        Task<string> UpdateOrderItem(OrderItem orderItem);
    }
}
