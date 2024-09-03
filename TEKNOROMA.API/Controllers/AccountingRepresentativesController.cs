using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TEKNOROMA.BLL.DTOs;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.API.Controllers
{
    [Authorize(Roles = "Admin, AccountingRepresentative")]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingRepresentativesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IExpenseService _expenseService;
        private readonly IInvoiceService _invoiceService;

        public AccountingRepresentativesController(IEmployeeService employeeService, IExpenseService expenseService, IInvoiceService invoiceService)
        {
            _employeeService = employeeService;
            _expenseService = expenseService;
            _invoiceService = invoiceService;
        }

        [HttpGet("Aylık Çalışan Ödemeleri")]
        public async Task<IActionResult> GetMonthlyEmployeePaymentsReport(DateTime month)
        {
            var report = await _employeeService.GetMonthlyEmployeePayments(month);
            return Ok(report);
        }

        [HttpPost("expenses")]
        public async Task<IActionResult> CreateExpense([FromBody] AddExpenseDto expenseDto)
        {
            if (expenseDto == null)
            {
                return BadRequest("Gider boş olamaz");
            }

            var expenseEntity = new Expense()
            {
                Description = expenseDto.Description,
                Amount = expenseDto.Amount,
                Date = expenseDto.Date
            };

            var result = await _expenseService.CreateExpense(expenseEntity);
            return Ok(result);
        }

        [HttpGet("Aylık Gider Raporu")]
        public async Task<IActionResult> GetMonthlyExpensesReport(DateTime month)
        {
            var report = await _expenseService.GetMonthlyExpenses(month);
            return Ok(report);
        }

        [HttpPost("invoices")]
        public async Task<IActionResult> CreateInvoice([FromBody] AddInvoiceDto invoiceDto)
        {
            if (invoiceDto == null)
            {
                return BadRequest("Fatura boş olamaz");
            }

            var invoiceEntity = new Invoice()
            {
                InvoiceNumber = invoiceDto.InvoiceNumber,
                Amount = invoiceDto.Amount,
                Date = invoiceDto.Date
            };

            var result = await _invoiceService.CreateInvoice(invoiceEntity);
            return Ok(result);
        }

        [HttpGet("Faturalar")]
        public async Task<IActionResult> GetInvoicesReport(DateTime month)
        {
            var report = await _invoiceService.GetInvoicesReport(month);
            return Ok(report);
        }
    }
}
