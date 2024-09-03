using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;

namespace TEKNOROMA.BLL.Repositories.Concretes
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerService(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<string> CreateCustomer(Customer customer)
        {
            return await _customerRepository.Create(customer);
        }

        public async Task<string> DeleteCustomer(Customer customer)
        {
            return await _customerRepository.Delete(customer);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetById(id);
        }

        public Customer GetCustomerByIdentity(string id)
        {
            return _customerRepository.GetByIdentity(id);
        }

        public async Task<string> UpdateCustomer(Customer customer)
        {
            return await _customerRepository.Update(customer);
        }

        public IEnumerable<CustomerDto> GetAllCustomerDtos()
        {
            var customer = _customerRepository.GetAll();
            var customerDto = customer.Select(x => new CustomerDto
            {
                IdentificationNumber = x.IdentificationNumber,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Gender = x.Gender.ToString(),
                Email = x.Email
            });
            return customerDto;
        }
    }
}
