using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Abstracts
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAllSuppliers();
        Supplier GetSupplierById(int id);
        Task<string> CreateSupplier(Supplier supplier);
        Task<string> DeleteSupplier(Supplier supplier);
        Task<string> UpdateSupplier(Supplier supplier);
        IEnumerable<SupplierDto> GetAllSupplierDtos();
    }
}
