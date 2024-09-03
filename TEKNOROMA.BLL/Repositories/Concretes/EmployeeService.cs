using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<string> CreateEmployee(Employee employee)
        {
            return await _employeeRepository.Create(employee);
        }

        public async Task<string> DeleteEmployee(Employee employee)
        {
            return await _employeeRepository.Delete(employee);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public async Task<string> UpdateEmployee(Employee employee)
        {
            return await _employeeRepository.Update(employee);
        }

        public IEnumerable<EmployeePaymentsDto> GetEmployeePayments()
        {
            var emplyees = _employeeRepository.GetAll().ToList();
            var employeePaymentsDto = emplyees.Select(p => new EmployeePaymentsDto
            {
                IdentificationNumber = p.IdentificationNumber,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Salary = p.Salary,
            }).OrderByDescending(s => s.Salary).ToList();
            return employeePaymentsDto;
        }

        public async Task<IEnumerable<EmployeeDto>> GetMonthlyEmployeePayments(DateTime month)
        {
            var startDate = new DateTime(month.Year, month.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var employees = _employeeRepository.GetAll();
            var employeeDto = employees.Select(x => new EmployeeDto
            {
                IdentificationNumber = x.IdentificationNumber,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Gender = x.Gender.ToString(),
                Department = x.Department,
                Position = x.Position,
                Salary = x.Salary,
                PaymentDate = x.PaymentDate,
                HireDate = x.HireDate
            });
            return employeeDto.Where(e => e.PaymentDate >= startDate && e.PaymentDate <= endDate);
        }

        public IEnumerable<EmployeeDto> GetAllEmployeeDtos()
        {
            var employees = _employeeRepository.GetAll();
            var employeesDto = employees.Select(x => new EmployeeDto
            {
                IdentificationNumber = x.IdentificationNumber,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Gender = x.Gender.ToString(),
                Department = x.Department,
                Position = x.Position,
                Salary = x.Salary,
                PaymentDate = x.PaymentDate,
                HireDate = x.HireDate
            });
            return employeesDto;
        }
    }
}
