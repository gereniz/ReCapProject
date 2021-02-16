using System;
using System.Collections.Generic;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customers>
    {
        List<CustomerDetailDTO> GetCustomerDetailDTOs();
    }
}
