namespace TEKNOROMA.MODEL.DTOs
{
    public class StockPriceOrderDto
    {
        public DateTime OrderDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public int StockQuantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
