using TEKNOROMA.MODEL.Entities;
using TEKNOROMA.MODEL.Enums;
namespace TEKNOROMA.MODEL.DTOs
{
    public class EmployeeDto
    {
        public string IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime HireDate { get; set; }
    }
}
