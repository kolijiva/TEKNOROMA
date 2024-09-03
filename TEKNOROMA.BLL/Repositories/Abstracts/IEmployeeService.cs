using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Abstracts
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        Task<string> CreateEmployee(Employee employee);
        Task<string> DeleteEmployee(Employee employee);
        Task<string> UpdateEmployee(Employee employee);
        IEnumerable<EmployeePaymentsDto> GetEmployeePayments();
        Task<IEnumerable<EmployeeDto>> GetMonthlyEmployeePayments(DateTime month);
        IEnumerable<EmployeeDto> GetAllEmployeeDtos();
    }
}
