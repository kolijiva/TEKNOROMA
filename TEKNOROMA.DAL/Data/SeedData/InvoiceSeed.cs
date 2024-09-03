using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.DAL.Data.SeedData
{
    public class InvoiceSeed
    {
        public static List<Invoice> invoices = new List<Invoice>()
        {
            new Invoice { ID = 1, InvoiceNumber = "INV001", Amount = 2000, Date = new DateTime(2024, 9, 5) },
            new Invoice { ID = 2, InvoiceNumber = "INV002", Amount = 1500, Date = new DateTime(2024, 9, 10) },
            new Invoice { ID = 3, InvoiceNumber = "INV003", Amount = 2500, Date = new DateTime(2024, 9, 25) }
        };
    }
}
