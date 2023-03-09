using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XiomaraCampos.DAL;
using XiomaraCampos.BL;


namespace XiomaraCampos.IoC
{
    public  static class DependecyContainer
    {
        public static IServiceCollection AddESFEDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDALDependecies(configuration);
            services.AddBLDependecies();
            return services;
        }
    }
}
