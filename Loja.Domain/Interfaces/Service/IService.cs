using System;
using System.Collections.Generic;

namespace Loja.Domain.Interfaces.Service
{
    public interface IService<TEntity>  where TEntity : class
    {
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(long id);
        void Remove(long id);
        IEnumerable<TEntity> GetAll();       
    }
}
