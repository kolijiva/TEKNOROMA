using TEKNOROMA.BLL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Abstracts
{
    public interface IExpenseService
    {
        IEnumerable<Expense> GetAllExpenses();
        Expense GetExpenseById(int id);
        Task<string> CreateExpense(Expense expense);
        Task<string> DeleteExpense(Expense expense);
        Task<string> UpdateExpense(Expense expense);
        Task<IEnumerable<ExpenseDto>> GetMonthlyExpenses(DateTime month);
    }
}
