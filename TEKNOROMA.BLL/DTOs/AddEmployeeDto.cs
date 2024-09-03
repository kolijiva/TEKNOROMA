using TEKNOROMA.MODEL.Entities;
using TEKNOROMA.MODEL.Enums;
namespace TEKNOROMA.BLL.DTOs
{
    public class AddEmployeeDto
    {
        public string IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime HireDate { get; set; }
        public int StoreID { get; set; }
    }
}
