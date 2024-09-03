using TEKNOROMA.MODEL.Entities;

namespace TEKNOROMA.DAL.Data.SeedData
{
    class ServiceRequestSeed
    {
        public static List<ServiceRequest> serviceRequests = new List<ServiceRequest>()
        {
            new ServiceRequest{ID=1,Description="Uygulama Çalışmıyor.",Type="Uygulama Hatasi",Status="Aktif"}
        };
    }
}
