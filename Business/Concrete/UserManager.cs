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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(Users user)
        {
            ValidationTool.Validator(new UserValidator(),user);
            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(int id)
        {
            var deleteUser = _userDal.GetAll().SingleOrDefault(u => u.id == id);
            _userDal.Delete(deleteUser);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Users>> GetAll()
        {
            
            return new SuccessDataResult<List<Users>>(_userDal.GetAll(),Messages.Listed);
        }

        public IResult Update(Users user,int id)
        {
            var updateUser= _userDal.GetAll().SingleOrDefault(u => u.id == id);
            updateUser.name = user.name;
            updateUser.surname = user.surname;
            updateUser.email = user.email;
            updateUser.password = user.password;
            _userDal.Update(updateUser);
            return new SuccessResult(Messages.Updated);
        }
    }
}
