using TEKNOROMA.BLL.DTOs;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Concretes
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepository<Invoice> _invoiceRepository;

        public InvoiceService(IRepository<Invoice> invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        public async Task<string> CreateInvoice(Invoice invoice)
        {
            return await _invoiceRepository.Create(invoice);
        }

        public async Task<string> DeleteInvoice(Invoice invoice)
        {
            return await _invoiceRepository.Delete(invoice);
        }

        public Invoice GetInvoiceById(int id)
        {
            return _invoiceRepository.GetById(id);
        }

        public IEnumerable<Invoice> GetInvoices()
        {
            return _invoiceRepository.GetAll();
        }

        public async Task<string> UpdateInvoice(Invoice invoice)
        {
            return await _invoiceRepository.Update(invoice);
        }

        public async Task<IEnumerable<InvoiceDto>> GetInvoicesReport(DateTime month)
        {
            var startDate = new DateTime(month.Year, month.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var invoices = _invoiceRepository.GetAll();
            var invoicesDto = invoices.Select(x => new InvoiceDto
            {
                Date = x.Date,
                InvoiceNumber = x.InvoiceNumber,
                Amount = x.Amount
            });
            return invoicesDto.Where(i => i.Date >= startDate && i.Date <= endDate);
        }
    }
}
