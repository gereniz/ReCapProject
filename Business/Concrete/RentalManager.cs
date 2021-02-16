using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Unitilies.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rentals rental)
        {
            if(rental.returndate == null)
            {
                return new ErrorResult(Messages.Invalid);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalDal.GetAll(), Messages.Listed);
        }

        public IResult Update(Rentals rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
