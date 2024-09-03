using TEKNOROMA.MODEL.Base;
namespace TEKNOROMA.MODEL.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }


        public int CustomerID { get; set; }
        public Customer Customer { get; set; }


        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
