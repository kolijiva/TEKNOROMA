using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TEKNOROMA.BLL.DTOs;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Concretes;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.API.Controllers
{
    [Authorize(Roles = "Admin, CashierSalesRepresentative")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var result = _customerService.GetAllCustomerDtos();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetCustomerById(int id)
        {
            var customer = _customerService.GetCustomerById(id);

            if (customer is null)
            {
                return NotFound();
            }
            else
            {
                var customerDto = new CustomerDto
                {
                    IdentificationNumber = customer.IdentificationNumber,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Gender = customer.Gender.ToString(),
                    Email = customer.Email
                };
                return Ok(customerDto);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] AddCustomerDto customer)
        {
            var customerEntity = new Customer()
            {
                IdentificationNumber = customer.IdentificationNumber,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Gender = customer.Gender,
                Email = customer.Email
            };

            var result = await _customerService.CreateCustomer(customerEntity);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] AddCustomerDto customer)
        {
            var customerEntity = new Customer()
            {
                ID = id,
                IdentificationNumber = customer.IdentificationNumber,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Gender = customer.Gender,
                Email = customer.Email
            };
            var result = await _customerService.UpdateCustomer(customerEntity);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = _customerService.GetCustomerById(id);

            if (customer == null)
            {
                return NotFound();
            }

            var result = await _customerService.DeleteCustomer(customer);
            return Ok(result);
        }
    }
}
