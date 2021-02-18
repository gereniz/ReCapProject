using System;
using System.Collections.Generic;
using Core.Unitilies.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rentals>> GetAll();

        IResult Add(Rentals rental);

        IResult Update(Rentals rental, int id);
    }
}
