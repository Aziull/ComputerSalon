using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace MVVM.Data
{
    public static class DbRegistrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration) => services
            .AddDbContext<MainDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString(configuration["Type"]));
            });
    }
}
