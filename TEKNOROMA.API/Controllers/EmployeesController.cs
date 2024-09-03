using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TEKNOROMA.BLL.DTOs;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Concretes;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.API.Controllers
{
    [Authorize(Roles = "Admin, BranchManager")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var result = _employeeService.GetAllEmployeeDtos();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

            if (employee is null)
            {
                return NotFound();
            }
            else
            {
                var employeeDto = new EmployeeDto
                {
                    IdentificationNumber = employee.IdentificationNumber,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    Gender = employee.Gender.ToString(),
                    Department = employee.Department,
                    Position = employee.Position,
                    Salary = employee.Salary,
                    PaymentDate = employee.PaymentDate,
                    HireDate = employee.HireDate
                };
                return Ok(employeeDto);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] AddEmployeeDto employee)
        {
            var employeeEntity = new Employee()
            {
                IdentificationNumber = employee.IdentificationNumber,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Gender = employee.Gender,
                Department = employee.Department,
                Position = employee.Position,
                Salary = employee.Salary,
                PaymentDate = employee.PaymentDate,
                HireDate = employee.HireDate,
                StoreID = employee.StoreID
            };

            var result = await _employeeService.CreateEmployee(employeeEntity);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] AddEmployeeDto employee)
        {
            var employeeEntity = new Employee()
            {
                ID = id,
                IdentificationNumber = employee.IdentificationNumber,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Gender = employee.Gender,
                Department = employee.Department,
                Position = employee.Position,
                Salary = employee.Salary,
                PaymentDate = employee.PaymentDate,
                HireDate = employee.HireDate,
                StoreID = employee.StoreID
            };
            var result = await _employeeService.UpdateEmployee(employeeEntity);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            var result = await _employeeService.DeleteEmployee(employee);
            return Ok(result);
        }
    }
}
