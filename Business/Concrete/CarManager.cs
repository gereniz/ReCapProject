using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Constants;
using Core.Unitilies.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Cars car)
        {
            if (car.dailyprice < 0)
            {
                return new ErrorResult(Messages.Invalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            var deleteCar = _carDal.GetAll().SingleOrDefault(c => c.id == id);
            _carDal.Delete(deleteCar);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Cars>> GetAll()
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDTO>>(_carDal.GetCarDetailDTOs(), Messages.Listed);
        }

        public IDataResult<List<Cars>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(p => p.brandid == id));
        }

        public IDataResult<List<Cars>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(p => p.colorid == id));
        }

        public IResult Update(Cars car,int id)
        {
            var updateCar = _carDal.GetAll().SingleOrDefault(c => c.id == id);
            updateCar.brandid = car.brandid;
            updateCar.colorid = car.colorid;
            updateCar.dailyprice = car.dailyprice;
            updateCar.description = car.description;
            updateCar.modelyear = car.modelyear;
            _carDal.Update(updateCar);
            return new SuccessResult(Messages.Updated);
        }
    }
}
