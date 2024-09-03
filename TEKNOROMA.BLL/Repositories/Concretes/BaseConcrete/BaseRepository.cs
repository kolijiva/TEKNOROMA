using Microsoft.EntityFrameworkCore;
using TEKNOROMA.BLL.Repositories.Abstracts.BaseAbstract;
using TEKNOROMA.DAL.Data.Context;
using TEKNOROMA.MODEL.Base;
namespace TEKNOROMA.BLL.Repositories.Concretes.BaseConcrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly TeknoromaDbContext _dbContext;
        private DbSet<T> _entities;

        public BaseRepository(TeknoromaDbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<T>();
        }

        public async Task<string> Create(T entity)
        {
            try
            {
                await _entities.AddAsync(entity);
                await _dbContext.SaveChangesAsync();
                return "Kayit Basarili !";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> Delete(T entity)
        {
            _entities.Remove(entity);
            int result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return "Kayit Kalici Olarak Silindi !";
            }
            else
            {
                return "Kayit Silme Islemi Sirasinda Bir Hata Meydana Geldi !";
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            try
            {
                return _entities.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return "Kayit Basariyla Guncellendi !";
        }

        public T GetByIdentity(string identity)
        {
            try
            {
                return _entities.FirstOrDefault(x => EF.Property<string>(x, "IdentificationNumber") == identity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
