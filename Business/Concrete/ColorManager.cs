using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Constants;
using Core.Unitilies.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Colors color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            var deleteColor = _colorDal.GetAll().SingleOrDefault(c => c.id == id);
            _colorDal.Delete(deleteColor);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Colors>> GetAll()
        {
            return new SuccessDataResult<List<Colors>>(_colorDal.GetAll(), Messages.Listed);
        }

        public IResult Update(Colors color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.Updated);
        }
    }
}

