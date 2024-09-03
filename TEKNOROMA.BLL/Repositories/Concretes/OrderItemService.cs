using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Concretes
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IRepository<OrderItem> _orderItemRepository;

        public OrderItemService(IRepository<OrderItem> orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }
        public async Task<string> CreateOrderItem(OrderItem orderItem)
        {
            return await _orderItemRepository.Create(orderItem);
        }

        public async Task<string> DeleteOrderItem(OrderItem orderItem)
        {
            return await _orderItemRepository.Delete(orderItem);
        }

        public IEnumerable<OrderItem> GetAllOrderItems()
        {
            return _orderItemRepository.GetAll();
        }

        public OrderItem GetOrderItemById(int id)
        {
            return _orderItemRepository.GetById(id);
        }

        public async Task<string> UpdateOrderItem(OrderItem orderItem)
        {
            return await _orderItemRepository.Update(orderItem);
        }
    }
}
