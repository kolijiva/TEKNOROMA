using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.DAL.Data.SeedData
{
    public class OrderSeed
    {
        public static List<Order> orders = new List<Order>()
        {
            new Order{ID=1,OrderDate=DateTime.Now.AddDays(1),CustomerID=1 },
            new Order{ID=2,OrderDate=DateTime.Now.AddDays(2),CustomerID=2 },
            new Order{ID=3,OrderDate=DateTime.Now.AddDays(3),CustomerID=3 },
            new Order{ID=4,OrderDate=DateTime.Now.AddDays(4),CustomerID=4 },
            new Order{ID=5,OrderDate=DateTime.Now.AddDays(5),CustomerID=5 },
            new Order{ID=6,OrderDate=DateTime.Now.AddDays(6),CustomerID=6 },
            new Order{ID=7,OrderDate=DateTime.Now.AddDays(7),CustomerID=7 },
            new Order{ID=8,OrderDate=DateTime.Now.AddDays(8),CustomerID=8 },
            new Order{ID=9,OrderDate=DateTime.Now.AddDays(9),CustomerID=9 },
            new Order{ID=10,OrderDate=DateTime.Now.AddDays(10),CustomerID=10 }
        };
    }
}
