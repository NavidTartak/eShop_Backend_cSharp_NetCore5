using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Dapper.Context;
using Persistance.Dapper.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootstrapper
{
    public static class Bootstrap
    {
        public static void WireUp(IServiceCollection Services)
        {
            //Context Services
            Services.AddSingleton<EshopContext>();

            //Framework Services

            //Repository Services
            Services.AddScoped<ISevenIconsRepository, SevenIconsRepository>();
            Services.AddScoped<IProductsRepository, ProductsRepository>();
            Services.AddScoped<ISliderRepository, SliderRepository>();
            Services.AddScoped<ITopBannerRepository, TopBannerRepository>();
 
        }
    }
}
