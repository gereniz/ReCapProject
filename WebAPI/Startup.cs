using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSingleton<ICarService,CarManager>();
            services.AddSingleton<ICarDal, EFCarDal>();

            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IUserDal, EFUserDal>();

            services.AddSingleton<ICustomerService, CustomerManager>();
            services.AddSingleton<ICustomerDal, EFCustomerDal>();

            services.AddSingleton<IRentalService, RentalManager>();
            services.AddSingleton<IRentalDal, EFRentalDal>();

            services.AddSingleton<IBrandService, BrandManager>();
            services.AddSingleton<IBrandDal, EFBrandDal>();

            services.AddSingleton<IColorService, ColorManager>();
            services.AddSingleton<IColorDal, EFColorDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
