using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            //IDisposable pattern implementation of c#
            using (DomainContext domainContext = new DomainContext()) //using bittiği an bellek temizlenir
            {
                var addedEntity = domainContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                domainContext.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (DomainContext domainContext = new DomainContext())
            {
                var deletedEntity = domainContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                domainContext.SaveChanges();
            }
        }


        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (DomainContext domainContext = new DomainContext())
            {
                return domainContext.Set<Color>().SingleOrDefault(filter);
            }
        }


        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (DomainContext domainContext = new DomainContext())
            {
                return filter == null ? domainContext.Set<Color>().ToList() : domainContext.Set<Color>().Where(filter).ToList();
            }
        }


        public void Update(Color entity)
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
