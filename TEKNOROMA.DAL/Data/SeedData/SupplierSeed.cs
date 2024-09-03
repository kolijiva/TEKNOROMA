using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.DAL.Data.SeedData
{
    public class SupplierSeed
    {
        public static List<Supplier> suppliers = new List<Supplier>()
        {
            new Supplier{ID=1,SupplierName="Kunde, Wyman and Lynch",ContactInfo="(304) 403-9258"},
            new Supplier{ID=2,SupplierName="Yost - Schaefer",ContactInfo="(479) 319-9089"},
            new Supplier{ID=3,SupplierName="Upton, Runte and Crist",ContactInfo="(204) 682-6716"},
            new Supplier{ID=4,SupplierName="Sipes and Sons",ContactInfo="(435) 939-5118"},
            new Supplier{ID=5,SupplierName="Kihn, McClure and Muller",ContactInfo="(801) 473-0584"}
        };
    }
}
