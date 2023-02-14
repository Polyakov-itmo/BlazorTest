using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Extensions
{
    public static class DbContextExtensions
    {
        /*public static void ConfigureSqLiteContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<BaseContext>(opt =>
            opt.UseSqlServer(config.GetConnectionString("test")));
        }*/

        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<BaseContext>(opt =>
                opt.UseSqlServer(config.GetConnectionString("default")));
        }
    }
}
