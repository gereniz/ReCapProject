using System;
using System.Collections.Generic;
using Business.Abstract;
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

        public List<Car> Delete()
        {
            return _carDal.Delete(int id);
        }

        public List<CarDetailDTO> carDetailDTOs()
        {
            return _carDal.GetCarDetailDTOs();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.brandid == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.colorid == id); ;
        }
    }
}
