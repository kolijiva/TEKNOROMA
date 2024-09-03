using TEKNOROMA.MODEL.Base;
namespace TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        Task<string> Create(T entity);
        Task<string> Update(T entity);
        Task<string> Delete(T entity);
        T GetByIdentity(string id);
    }
}
