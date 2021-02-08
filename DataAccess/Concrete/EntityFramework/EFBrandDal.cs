using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            //IDisposable pattern implementation of c#
            using (DomainContext domainContext = new DomainContext()) //using bittiği an bellek temizlenir
            {
                var addedEntity = domainContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                domainContext.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (DomainContext domainContext = new DomainContext())
            {
                var deletedEntity = domainContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                domainContext.SaveChanges();
            }
        }


        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (DomainContext domainContext = new DomainContext())
            {
                return domainContext.Set<Brand>().SingleOrDefault(filter);
            }
        }


        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (DomainContext domainContext = new DomainContext())
            {
                return filter == null ? domainContext.Set<Brand>().ToList() : domainContext.Set<Brand>().Where(filter).ToList();
            }
        }


        public void Update(Brand entity)
        {
            using (DomainContext domainContext = new DomainContext())
            {
                var updatedEntity = domainContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                domainContext.SaveChanges();
            }
        }
    }
}
