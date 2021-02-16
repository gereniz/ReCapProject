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
        List<Cars> _cars;
        public InMemoryCarDal()
        {
            {
                _cars = new List<Cars>
                {
                    new Cars{id=1 , brandid=1 , colorid=1 , modelyear=2000 , dailyprice= 50 , description="BMW"},
                    new Cars{id=2 , brandid=2 , colorid=2 , modelyear=2010 , dailyprice= 100 , description="AUDI"},
                    new Cars{id=3 , brandid=3 , colorid=3 , modelyear=2020 , dailyprice= 150, description="HYUNDAI"},
                };
            }
        }
        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carToDelete = _cars.SingleOrDefault(c => c.id == car.id);
            _cars.Remove(carToDelete);
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetByBrandId(int BrandId)
        {
            return _cars.Where(c => c.brandid == BrandId).ToList();
        }

        public List<CarDetailDTO> GetCarDetailDTOs()
        {
            throw new NotImplementedException();
        }

        public void Update(Cars car)
        {
            Cars carToUpdate = _cars.SingleOrDefault(c => c.id == car.id);
            carToUpdate.brandid = car.brandid;
            carToUpdate.colorid = car.colorid;
            carToUpdate.modelyear = car.modelyear;
            carToUpdate.dailyprice = car.dailyprice;
            carToUpdate.description = carToUpdate.description;
        }
    }
}
