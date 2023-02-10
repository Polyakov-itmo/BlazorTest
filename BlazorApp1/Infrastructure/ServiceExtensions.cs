using DataAccess.Contexts;
using DataAccess.Repos;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqLiteContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:default_sqlite"];

            services.AddDbContext<BaseContext>(opt => opt.UseSqlite(connectionString));
        }


        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryGlobal, RepositoryGlobal>();
        }

    }

    
}
