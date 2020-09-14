using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesCoreApi.Repository;
using CarSalesCoreApi.Repository.EfDataAccessLayers;
using CarSalesCoreApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CarSalesCoreApi
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
            services.AddScoped<ModelService>();
            services.AddScoped<IModelDal, EfModelDal>();
            services.AddScoped<CategoryService>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<CityService>();
            services.AddScoped<ICityDal, EfCityDal>();
            services.AddScoped<UserService>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddMvc(options =>
            {
               
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
