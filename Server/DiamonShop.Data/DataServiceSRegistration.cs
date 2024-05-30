using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DiamonShop.Data
{
    public static class DataServiceSRegistration
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DiamondContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DiamondConnection")));



            return services;
        }
    }
}
