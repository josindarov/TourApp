using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Travel.Data.Contexts;

namespace Travel.Data;
public static class Configuration
{
    public static IServiceCollection InfrastructureDependencies(this IServiceCollection serivces, IConfiguration configuration)
    {
        serivces.AddDbContext<TravelDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        return serivces;
    }
}
