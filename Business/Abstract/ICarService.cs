using System;
using System.Collections.Generic;
using Core.Unitilies.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Cars>> GetAll();

        IDataResult<List<Cars>>GetCarsByBrandId(int id);

        IDataResult<List<Cars>> GetCarsByColorId(int id);

        IDataResult<List<CarDetailDTO>> GetCarDetails();

        IResult Add(Cars car);

        IResult Delete(int id);

        IResult Update(Cars car);

    }
}
