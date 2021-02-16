using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFUserDal : EFEntityRepositoryBase<Users,DomainContext> ,IUserDal
    {
        
    }
}
