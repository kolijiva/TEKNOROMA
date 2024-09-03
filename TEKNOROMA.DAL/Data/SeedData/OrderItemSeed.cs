using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.DAL.Data.SeedData
{
    public class OrderItemSeed
    {
        public static List<OrderItem> orderItems = new List<OrderItem>()
        {
            new OrderItem{ID=1,ProductID=1,OrderID=1,Quantity=25,UnitPrice=15000},
            new OrderItem{ID=2,ProductID=5,OrderID=2,Quantity=50,UnitPrice=7500},
            new OrderItem{ID=3,ProductID=10,OrderID=3,Quantity=15,UnitPrice=72500},
            new OrderItem{ID=4,ProductID=20,OrderID=4,Quantity=45,UnitPrice=32500},
            new OrderItem{ID=5,ProductID=25,OrderID=5,Quantity=5,UnitPrice=4250},
            new OrderItem{ID=6,ProductID=3,OrderID=6,Quantity=30,UnitPrice=17500},
            new OrderItem{ID=7,ProductID=7,OrderID=7,Quantity=10,UnitPrice=65000},
            new OrderItem{ID=8,ProductID=9,OrderID=8,Quantity=35,UnitPrice=40000},
            new OrderItem{ID=9,ProductID=12,OrderID=9,Quantity=40,UnitPrice=22250},
            new OrderItem{ID=10,ProductID=17,OrderID=10,Quantity=20,UnitPrice=37500}
        };
    }
}
