using System;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>();
            builder.RegisterType<EFCarDal>().As<ICarDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EFUserDal>().As<IUserDal>();

            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EFCustomerDal>().As<ICustomerDal>();

            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<EFBrandDal>().As<IBrandDal>();

            builder.RegisterType<ColorManager>().As<IColorService>();
            builder.RegisterType<EFColorDal>().As<IColorDal>();

            builder.RegisterType<RentalManager>().As<IRentalService>();
            builder.RegisterType<EFRentalDal>().As<IRentalDal>();


        }
    }
}
