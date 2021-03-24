using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void AddRange(List<TEntity> lstObj);
        TEntity GetById(int id);
        TEntity GetById(long id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void RemoveRange(List<TEntity> lstObj);
        void Dispose();
    }
}
