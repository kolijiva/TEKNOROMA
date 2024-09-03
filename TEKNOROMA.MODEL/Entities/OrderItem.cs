using TEKNOROMA.MODEL.Base;
namespace TEKNOROMA.MODEL.Entities
{
    public class OrderItem : BaseEntity
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }


        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
