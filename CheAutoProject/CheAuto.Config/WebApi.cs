using System;
using CheAuto.Common;
using CheAuto.Services;
using CheAuto.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CheAuto.Config
{
    public static class WebApi
    {
        public static void DependencyInjectionConfig(IServiceCollection services)
        {
            services.AddTransient<Seeder>();
            services.AddTransient<IBodyTypeService, BodyTypeService>();
            services.AddTransient<ICarManufacturerService, CarManufacturerService>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IEngineService, EngineService>();
            services.AddTransient<ICarComplectationService, CarComplectationService>();
            services.AddTransient<ICarModelService, CarModelService>();
        }
    }
}
