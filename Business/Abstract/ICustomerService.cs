using System;
using System.Collections.Generic;
using Core.Unitilies.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customers>> GetAll();

        IResult Add(Customers customer);

        IResult Delete(int id);

        IResult Update(Customers customer);
    }
}
