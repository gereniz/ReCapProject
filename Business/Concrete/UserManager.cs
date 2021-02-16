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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(Users user)
        {
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

        public IResult Update(Users user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }
    }
}
