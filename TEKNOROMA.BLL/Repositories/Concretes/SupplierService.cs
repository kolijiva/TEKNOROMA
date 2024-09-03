using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Concretes
{
    public class SupplierService : ISupplierService
    {
        private readonly IRepository<Supplier> _supplierRepository;

        public SupplierService(IRepository<Supplier> supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public async Task<string> CreateSupplier(Supplier supplier)
        {
            return await _supplierRepository.Create(supplier);
        }

        public async Task<string> DeleteSupplier(Supplier supplier)
        {
            return await _supplierRepository.Delete(supplier);
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _supplierRepository.GetAll();
        }

        public Supplier GetSupplierById(int id)
        {
            return _supplierRepository.GetById(id);
        }

        public async Task<string> UpdateSupplier(Supplier supplier)
        {
            return await _supplierRepository.Update(supplier);
        }

        public IEnumerable<SupplierDto> GetAllSupplierDtos()
        {
            var suppliers = _supplierRepository.GetAll();
            var suppliersDto = suppliers.Select(x => new SupplierDto
            {
                SupplierName = x.SupplierName,
                ContactInfo = x.ContactInfo
            });
            return suppliersDto;
        }
    }
}
