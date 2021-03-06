﻿using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EFEntityRepositoryBase<Cars, DomainContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarDetailDTOs()
        {
            using(DomainContext domainContext = new DomainContext())
            {
                var result = from c in domainContext.cars
                             join b in domainContext.brands
                             on c.brandid equals b.id
                             join clr in domainContext.colors
                             on c.colorid equals clr.id
                             select new CarDetailDTO
                             {
                                 id = c.id,
                                 brandname = b.brandname,
                                 colorname = clr.colorname,
                                 dailyprice = c.dailyprice,
                                 modelyear = c.modelyear,
                                 description = c.description
                             };
                return result.ToList();
            }
        }
    }
}
