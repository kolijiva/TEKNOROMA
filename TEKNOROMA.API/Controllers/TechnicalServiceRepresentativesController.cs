using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.API.Controllers
{
    [Authorize(Roles = "Admin, TechnicalServiceRepresentative")]
    [Route("api/[controller]")]
    [ApiController]
    public class TechnicalServiceRepresentativesController : ControllerBase
    {
        private readonly IServiceRequestService _serviceRequestService;

        public TechnicalServiceRepresentativesController(IServiceRequestService serviceRequestService)
        {
            _serviceRequestService = serviceRequestService;
        }

        [HttpGet("Teknik Servis Talepleri - Uygulama Sorunları Görüntüleme")]
        public IActionResult GetServiceRequests()
        {
            var result = _serviceRequestService.GetAllServiceRequests();

            var serviceRequestDto = result.Select(x => new ServiceRequestDto
            {
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Type = x.Type,
                Status = x.Status,
            }).ToList();

            return Ok(serviceRequestDto);
        }

        [HttpPost("Teknik Servis Talepleri - Uygulama Sorunları Oluşturma")]
        public async Task<IActionResult> CreateServiceRequest([FromBody] AddServiceRequestDto serviceRequest)
        {
            var serviceRequestEntity = new ServiceRequest()
            {
                Description = serviceRequest.Description,
                Type = serviceRequest.Type,
                Status = serviceRequest.Status
            };

            var result = await _serviceRequestService.CreateServiceRequest(serviceRequestEntity);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateServiceRequest(int id, [FromBody] AddServiceRequestDto serviceRequest)
        {
            var serviceRequestEntity = new ServiceRequest()
            {
                ID = id,
                Description = serviceRequest.Description,
                Type = serviceRequest.Type,
                Status = serviceRequest.Status
            };
            var result = await _serviceRequestService.UpdateServiceRequest(serviceRequestEntity);
            return Ok(result);
        }
    }
}
