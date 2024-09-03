using TEKNOROMA.MODEL.Enums;
namespace TEKNOROMA.BLL.DTOs
{
    public class AddCustomerDto
    {
        public string IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
    }
}
