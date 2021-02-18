using System;
using System.Collections.Generic;
using Core.Unitilies.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<Users>> GetAll();

        IResult Add(Users user);

        IResult Delete(int id);

        IResult Update(Users user, int id);
    }
}
