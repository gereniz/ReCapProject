using System;
using System.Collections.Generic;
using Core.Unitilies.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Colors>> GetAll();

        IResult Add(Colors color);

        IResult Delete(int id);

        IResult Update(Colors color);
    }
}
