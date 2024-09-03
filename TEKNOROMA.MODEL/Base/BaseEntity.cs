using TEKNOROMA.MODEL.Interfaces;
namespace TEKNOROMA.MODEL.Base
{
    public class BaseEntity : IBaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }

        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
