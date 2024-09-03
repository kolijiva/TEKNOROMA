using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Abstracts
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        Task<string> CreateCustomer(Customer customer);
        Task<string> DeleteCustomer(Customer customer);
        Task<string> UpdateCustomer(Customer customer);
        Customer GetCustomerByIdentity(string id);
        IEnumerable<CustomerDto> GetAllCustomerDtos();
    }
}
