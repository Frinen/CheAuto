using System;
using CheAuto.Services;
using CheAuto.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CheAuto.Config
{
    public static class WebApi
    {
        public static void DependencyInjectionConfig(IServiceCollection services)
        {
            services.AddTransient<IBodyTypeService, BodyTypeService>();
        }
    }
}
