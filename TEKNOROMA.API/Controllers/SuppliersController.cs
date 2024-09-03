using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.API.Controllers
{
    [Authorize(Roles = "Admin, BranchManager")]
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet]
        public IActionResult GetAllSuppliers()
        {
            var result = _supplierService.GetAllSupplierDtos();

            if (result == null || !result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetSupplierById(int id)
        {
            var supplier = _supplierService.GetSupplierById(id);

            if (supplier is null)
            {
                return NotFound();
            }
            else
            {
                var supplierDto = new SupplierDto
                {
                    SupplierName = supplier.SupplierName,
                    ContactInfo = supplier.ContactInfo
                };
                return Ok(supplierDto);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSupplier([FromBody] SupplierDto supplier)
        {
            var supplierEntity = new Supplier()
            {
                SupplierName = supplier.SupplierName,
                ContactInfo = supplier.ContactInfo
            };

            var result = await _supplierService.CreateSupplier(supplierEntity);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] SupplierDto supplier)
        {
            var supplierEntity = new Supplier()
            {
                ID = id,
                SupplierName = supplier.SupplierName,
                ContactInfo = supplier.ContactInfo
            };
            var result = await _supplierService.UpdateSupplier(supplierEntity);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            var supplier = _supplierService.GetSupplierById(id);

            if (supplier == null)
            {
                return NotFound();
            }

            var result = await _supplierService.DeleteSupplier(supplier);
            return Ok(result);
        }
    }
}
