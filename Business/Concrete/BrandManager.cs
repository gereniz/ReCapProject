using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidator;
using Core.CrossCuttingConcerns.Validator;
using Core.Unitilies.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brands brand)
        {
            ValidationTool.Validator(new BrandValidator(), brand);
            _brandDal.Add(brand);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            var deleteBrand = _brandDal.GetAll().SingleOrDefault(b => b.id == id);
            _brandDal.Delete(deleteBrand);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Brands>> GetAll()
        {
            return new SuccessDataResult<List<Brands>>(_brandDal.GetAll(), Messages.Listed);
        }

        public IResult Update(Brands brand,int id)
        {
            var updateBrand = _brandDal.GetAll().SingleOrDefault(b => b.id == id);
            updateBrand.brandname = brand.brandname;
            _brandDal.Update(updateBrand);
            return new SuccessResult(Messages.Updated);
        }
    }
}
