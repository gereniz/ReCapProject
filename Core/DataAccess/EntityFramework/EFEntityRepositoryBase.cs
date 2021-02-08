using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity,TDomainContext> : IEntityRepository<TEntity>
        where TEntity : class , IEntity , new()
        where TDomainContext : DbContext , new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of c#
            using (TDomainContext domainContext = new TDomainContext()) //using bittiği an bellek temizlenir
            {
                var addedEntity = domainContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                domainContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TDomainContext domainContext = new TDomainContext())
            {
                var deletedEntity = domainContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                domainContext.SaveChanges();
            }
        }


        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TDomainContext domainContext = new TDomainContext())
            {
                return domainContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }


        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TDomainContext domainContext = new TDomainContext())
            {
                return filter == null ? domainContext.Set<TEntity>().ToList() : domainContext.Set<TEntity>().Where(filter).ToList();
            }
        }


        public void Update(TEntity entity)
        {
            using (TDomainContext domainContext = new TDomainContext())
            {
                var updatedEntity = domainContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                domainContext.SaveChanges();
            }
        }

    }
}
