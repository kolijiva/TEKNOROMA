using TEKNOROMA.MODEL.Base;
using TEKNOROMA.MODEL.Enums;
namespace TEKNOROMA.MODEL.Entities
{
    public class Customer : BaseEntity
    {
        public string IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }


        public ICollection<Order> Orders { get; set; }
    }
}
