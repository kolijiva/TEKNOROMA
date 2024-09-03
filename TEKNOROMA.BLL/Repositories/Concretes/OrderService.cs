using Microsoft.EntityFrameworkCore;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Concretes
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Supplier> _supplierRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<OrderItem> _orderItemRepository;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Customer> _customerRepository;

        public OrderService(IRepository<Product> productRepository, IRepository<Supplier> supplierRepository, IRepository<Order> orderRepository, IRepository<OrderItem> orderItemRepository, IRepository<Category> categoryRepository, IRepository<Customer> customerRepository)
        {
            _productRepository = productRepository;
            _supplierRepository = supplierRepository;
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _categoryRepository = categoryRepository;
            _customerRepository = customerRepository;
        }
        public async Task<string> CreateOrder(Order order)
        {
            return await _orderRepository.Create(order);
        }

        public async Task<string> DeleteOrder(Order order)
        {
            return await _orderRepository.Delete(order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public IEnumerable<OrderProductSupplierDto> GetOrderProductSupplierInfo()
        {
            var result = (from oi in _orderItemRepository.GetAll()
                          join o in _orderRepository.GetAll() on oi.OrderID equals o.ID
                          join p in _productRepository.GetAll() on oi.ProductID equals p.ID
                          join s in _supplierRepository.GetAll() on p.SupplierID equals s.ID
                          select new OrderProductSupplierDto
                          {
                              OrderDate = o.OrderDate,
                              ProductName = p.ProductName,
                              SupplierName = s.SupplierName,
                              ContactInfo = s.ContactInfo
                          }).ToList();

            return result;
        }
        public IEnumerable<TopProductDto> GetTopProducts()
        {
            var result = (from oi in _orderItemRepository.GetAll()
                          join p in _productRepository.GetAll() on oi.ProductID equals p.ID
                          join c in _categoryRepository.GetAll() on p.CategoryID equals c.ID
                          select new TopProductDto
                          {
                              ProductName = p.ProductName,
                              CategoryName = c.CategoryName,
                              Quantity = oi.Quantity,
                          }).OrderByDescending(oi => oi.Quantity).Take(3).ToList();

            return result;
        }

        public IEnumerable<OrderDetailDto> GetOrderDetails()
        {
            var result = (from oi in _orderItemRepository.GetAll()
                          join p in _productRepository.GetAll() on oi.ProductID equals p.ID
                          join o in _orderRepository.GetAll() on oi.OrderID equals o.ID
                          join c in _customerRepository.GetAll() on o.CustomerID equals c.ID
                          select new OrderDetailDto
                          {
                              OrderDate = o.OrderDate,
                              FirstName = c.FirstName,
                              LastName = c.LastName,
                              ProductName = p.ProductName,
                              Quantity = oi.Quantity,
                              Price = oi.UnitPrice
                          });

            return result;
        }

        public IEnumerable<OrderDto> GetOrders()
        {
            var result = (from oi in _orderItemRepository.GetAll()
                          join p in _productRepository.GetAll() on oi.ProductID equals p.ID
                          join o in _orderRepository.GetAll() on oi.OrderID equals o.ID
                          select new OrderDto
                          {
                              OrderDate = o.OrderDate,
                              ProductName = p.ProductName,
                              Quantity = oi.Quantity,
                              Price = oi.UnitPrice
                          });

            return result;
        }

        public IEnumerable<StockPriceOrderDto> GetStockPriceOrders()
        {
            var result = (from oi in _orderItemRepository.GetAll()
                          join p in _productRepository.GetAll() on oi.ProductID equals p.ID
                          join o in _orderRepository.GetAll() on oi.OrderID equals o.ID
                          join c in _customerRepository.GetAll() on o.CustomerID equals c.ID
                          select new StockPriceOrderDto
                          {
                              OrderDate = o.OrderDate,
                              FirstName = c.FirstName,
                              LastName = c.LastName,
                              Quantity = oi.Quantity,
                              ProductName = p.ProductName,
                              StockQuantity = oi.Quantity,
                              TotalPrice = (oi.Quantity * p.Price)
                          });

            return result;
        }

        public async Task<string> UpdateOrder(Order order)
        {
            return await _orderRepository.Update(order);
        }
    }
}
