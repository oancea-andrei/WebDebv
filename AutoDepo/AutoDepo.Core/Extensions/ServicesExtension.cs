using AutoDepoDB.Core.Services;
using AutoDepoDB.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AutoDepoDB.Core.Extensions
{
    public static class ServicesExtension
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICarBrandService, CarBrandService>();
            services.AddScoped<ICarBrandRepository, CarBrandRepository>();

            services.AddScoped<ICarModelService, CarModelService>();
            services.AddScoped<ICarModelRepository, CarModelRepository>();
        }

    }
}
