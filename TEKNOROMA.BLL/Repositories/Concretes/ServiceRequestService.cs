using TEKNOROMA.BLL.Repositories.Abstracts;
using TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract;
using TEKNOROMA.MODEL.DTOs;
using TEKNOROMA.MODEL.Entities;
namespace TEKNOROMA.BLL.Repositories.Concretes
{
    public class ServiceRequestService : IServiceRequestService
    {
        private readonly IRepository<ServiceRequest> _serviceRequestRepository;

        public ServiceRequestService(IRepository<ServiceRequest> serviceRequestRepository)
        {
            _serviceRequestRepository = serviceRequestRepository;
        }
        public async Task<string> CreateServiceRequest(ServiceRequest serviceRequest)
        {
            return await _serviceRequestRepository.Create(serviceRequest);
        }

        public async Task<string> DeleteServiceRequest(ServiceRequest serviceRequest)
        {
            return await _serviceRequestRepository.Delete(serviceRequest);
        }

        public IEnumerable<ServiceRequest> GetAllServiceRequests()
        {
            return _serviceRequestRepository.GetAll();
        }

        public ServiceRequest GetServiceRequestById(int id)
        {
            return _serviceRequestRepository.GetById(id);
        }

        public async Task<string> UpdateServiceRequest(ServiceRequest serviceRequest)
        {
            return await _serviceRequestRepository.Update(serviceRequest);
        }
    }
}
