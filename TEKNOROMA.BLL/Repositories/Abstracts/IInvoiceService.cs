using TEKNOROMA.BLL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Abstracts
{
    public interface IInvoiceService
    {
        IEnumerable<Invoice> GetInvoices();
        Invoice GetInvoiceById(int id);
        Task<string> CreateInvoice(Invoice invoice);
        Task<string> DeleteInvoice(Invoice invoice);
        Task<string> UpdateInvoice(Invoice invoice);
        Task<IEnumerable<InvoiceDto>> GetInvoicesReport(DateTime month);
    }
}
