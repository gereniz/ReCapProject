using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            //IDisposable pattern implementation of c#
            using (DomainContext domainContext = new DomainContext()) //using bittiği an bellek temizlenir
            {
                var addedEntity = domainContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                domainContext.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (DomainContext domainContext = new DomainContext())
            {
                var deletedEntity = domainContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                domainContext.SaveChanges();
            }
        }


        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (DomainContext domainContext = new DomainContext())
            {
                return domainContext.Set<Car>().SingleOrDefault(filter);
            }
        }


        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (DomainContext domainContext = new DomainContext())
            {
                return filter == null ? domainContext.Set<Car>().ToList() : domainContext.Set<Car>().Where(filter).ToList();
            }
        }


        public void Update(Car entity)
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
