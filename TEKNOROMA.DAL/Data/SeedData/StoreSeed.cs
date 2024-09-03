using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.DAL.Data.SeedData
{
    public class StoreSeed
    {
        public static List<Store> stores = new List<Store>()
        {
            new Store{ID=1,Name="Teknorama Istanbul",Location="Istanbul"},
            new Store{ID=2,Name="Teknorama Ankara",Location="Ankara"},
            new Store{ID=3,Name="Teknorama Izmir",Location="Izmir"},
            new Store{ID=4,Name="Teknorama Antalya",Location="Antalya"},
            new Store{ID=5,Name="Teknorama Bursa",Location="Bursa"}
        };
    }
}
