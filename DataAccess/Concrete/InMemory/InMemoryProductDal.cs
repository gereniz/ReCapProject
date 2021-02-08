using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            {
                _cars = new List<Car>
                {
                    new Car{id=1 , brandid=1 , colorid=1 , modelyear=2000 , dailyprice= 50 , description="BMW"},
                    new Car{id=2 , brandid=2 , colorid=2 , modelyear=2010 , dailyprice= 100 , description="AUDI"},
                    new Car{id=3 , brandid=3 , colorid=3 , modelyear=2020 , dailyprice= 150, description="HYUNDAI"},
                };
            }
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.id == car.id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int BrandId)
        {
            return _cars.Where(c => c.brandid == BrandId).ToList();
        }

        public List<CarDetailDTO> GetCarDetailDTOs()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.id == car.id);
            carToUpdate.brandid = car.brandid;
            carToUpdate.colorid = car.colorid;
            carToUpdate.modelyear = car.modelyear;
            carToUpdate.dailyprice = car.dailyprice;
            carToUpdate.description = carToUpdate.description;
        }
    }
}
