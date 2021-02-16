using System;
using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCustomerDal : EFEntityRepositoryBase<Customers,DomainContext> ,ICustomerDal
    {
        public List<CustomerDetailDTO> GetCustomerDetailDTOs()
        {
            using(DomainContext domainContext = new DomainContext()) 
            {
                var result = from c in domainContext.customers
                             join u in domainContext.users
                             on c.userid equals u.id
                             select new CustomerDetailDTO
                             {
                                 id = c.id,
                                 name = u.name,
                                 surname = u.surname,
                                 email = u.email,
                                 password = u.password,
                                 companyname = c.companyname
                             };
                return result.ToList();
            }
        }
           
    }
}
