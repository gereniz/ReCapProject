using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidator;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validator;
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
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rentals rental)
        {
            ValidationTool.Validator(new RentalValidator(), rental);
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalDal.GetAll(), Messages.Listed);
        }

        public IResult Update(Rentals rental,int id)
        {
            var updateRental = _rentalDal.GetAll().SingleOrDefault(r => r.id == id);
            updateRental.carid = rental.carid;
            updateRental.customerid = rental.customerid;
            updateRental.rentdate = rental.rentdate;
            updateRental.returndate = rental.returndate;
            _rentalDal.Update(updateRental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
