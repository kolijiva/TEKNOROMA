using System.ComponentModel.DataAnnotations;
using TEKNOROMA.MODEL.Base;
namespace TEKNOROMA.MODEL.Entities
{
    public class ServiceRequest : BaseEntity
    {
        public string Description { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
