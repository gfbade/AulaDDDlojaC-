using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity obj);
        void Update(TEntity obj);
        TEntity GetById(long id);
        void Remove(long id);
        IEnumerable<TEntity> GetAll();        
        int SaveChanges();
    }
}
