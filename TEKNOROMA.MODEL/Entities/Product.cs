using TEKNOROMA.MODEL.Base;
namespace TEKNOROMA.MODEL.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }


        public int CategoryID { get; set; }
        public Category Category { get; set; }


        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
    }
}
