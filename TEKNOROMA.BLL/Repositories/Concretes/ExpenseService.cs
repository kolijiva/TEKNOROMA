using TEKNOROMA.BLL.DTOs;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Concretes
{
    public class ExpenseService : IExpenseService
    {
        private readonly IRepository<Expense> _expenseRepository;

        public ExpenseService(IRepository<Expense> expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }
        public async Task<string> CreateExpense(Expense expense)
        {
            return await _expenseRepository.Create(expense);
        }

        public async Task<string> DeleteExpense(Expense expense)
        {
            return await _expenseRepository.Delete(expense);
        }

        public IEnumerable<Expense> GetAllExpenses()
        {
            return _expenseRepository.GetAll();
        }

        public Expense GetExpenseById(int id)
        {
            return _expenseRepository.GetById(id);
        }

        public async Task<string> UpdateExpense(Expense expense)
        {
            return await _expenseRepository.Update(expense);
        }

        public async Task<IEnumerable<ExpenseDto>> GetMonthlyExpenses(DateTime month)
        {
            var startDate = new DateTime(month.Year, month.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var expenses = _expenseRepository.GetAll();
            var expensesDto = expenses.Select(x => new ExpenseDto
            {
                Date = x.Date,
                Description = x.Description,
                Amount = x.Amount
            });
            return expensesDto.Where(e => e.Date >= startDate && e.Date <= endDate);
        }
    }
}
