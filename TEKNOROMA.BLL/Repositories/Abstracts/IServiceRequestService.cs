using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Abstracts
{
    public interface IServiceRequestService
    {
        IEnumerable<ServiceRequest> GetAllServiceRequests();
        ServiceRequest GetServiceRequestById(int id);
        Task<string> CreateServiceRequest(ServiceRequest serviceRequest);
        Task<string> DeleteServiceRequest(ServiceRequest serviceRequest);
        Task<string> UpdateServiceRequest(ServiceRequest serviceRequest);
    }
}
