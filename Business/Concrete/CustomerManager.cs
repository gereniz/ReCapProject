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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        [ValidationAspect(typeof(CustomerValidator))]
        public IResult Add(Customers customer)
        {
            ValidationTool.Validator(new CustomerValidator(), customer);
            _customerDal.Add(customer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            var deleteCustomer = _customerDal.GetAll().SingleOrDefault(c => c.id == id);
            _customerDal.Delete(deleteCustomer);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customerDal.GetAll(), Messages.Listed);
        }

        public IResult Update(Customers customer,int id)
        {
            var updateCustomer = _customerDal.GetAll().SingleOrDefault(c => c.id == id);
            updateCustomer.userid = customer.userid;
            updateCustomer.companyname = customer.companyname;
            _customerDal.Update(updateCustomer);
            return new SuccessResult(Messages.Updated);
        }
    }
}
