using TEKNOROMA.MODEL.Base;
namespace TEKNOROMA.MODEL.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }


        public ICollection<Employee> Employees { get; set; }
    }
}
