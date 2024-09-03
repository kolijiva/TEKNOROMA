namespace TEKNOROMA.MODEL.DTOs
{
    public class AddOrderDto
    {
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
