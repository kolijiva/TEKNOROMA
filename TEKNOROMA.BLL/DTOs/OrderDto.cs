using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.MODEL.DTOs
{
    public class OrderDto
    {
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
