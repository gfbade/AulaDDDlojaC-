using Loja.Infra.Data.Context;
using Loja.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected LojaContext Context;
        protected DbSet<TEntity> DbSet;

        public Repository(LojaContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }
        public TEntity Add(TEntity obj)
        {
            var returnObj = DbSet.Add(obj);
            Context.SaveChanges();
            
            return returnObj.Entity;
        }

        public void Dispose()
        {
            Context.Dispose();         
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet;
        }

        public TEntity GetById(long id)
        {
           return DbSet.Find(id);
        }

        public void Remove(long id)
        {
            DbSet.Remove(GetById(id));
            Context.SaveChanges();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
