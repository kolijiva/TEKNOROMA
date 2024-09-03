using TEKNOROMA.MODEL.Base;
namespace TEKNOROMA.MODEL.Entities
{
    public class Invoice : BaseEntity
    {
        public string InvoiceNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
