using System;
using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> Delete(int id);
        List<CarDetailDTO> carDetailDTOs();
        
    }
}
