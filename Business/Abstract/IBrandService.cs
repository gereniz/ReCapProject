using System;
using System.Collections.Generic;
using Core.Unitilies.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brands>> GetAll();

        IResult Add(Brands brand);

        IResult Delete(int id);

        IResult Update(Brands brand, int id);
    }
}
