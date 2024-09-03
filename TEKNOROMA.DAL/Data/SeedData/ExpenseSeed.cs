using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.DAL.Data.SeedData
{
    public class ExpenseSeed
    {
        public static List<Expense> expenses = new List<Expense>()
        {
            new Expense{ ID = 1, Description = "Ofis Kirası", Amount = 1500, Date = new DateTime(2024, 9, 10)},
            new Expense { ID = 2, Description = "Elektrik Faturası", Amount = 300, Date = new DateTime(2024, 9, 15)},
            new Expense { ID = 3, Description = "Internet", Amount = 100, Date = new DateTime(2024, 9, 20)}
        };
    }
}
