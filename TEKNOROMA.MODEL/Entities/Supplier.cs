using TEKNOROMA.MODEL.Base;
namespace TEKNOROMA.MODEL.Entities
{
    public class Supplier : BaseEntity
    {
        public string SupplierName { get; set; }
        public string ContactInfo { get; set; }


        public ICollection<Product> Products { get; set; }
    }
}
