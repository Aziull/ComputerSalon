using BusinessLayer;
using BusinessLayer.Abstract;
using BusinessLayer.Handlers;
using BusinessLayer.Services;
using DataLayer;
using DataLayer.Abstract;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVVM.Models;

namespace MVVM.Services
{
    public static class ServiceRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddSingleton<IUnitOfWork, UnitOfWork>()
            .AddSingleton<UnitMvvmDetails>()
            .AddSingleton<AllMvvmUnits>()

            .AddTransient<ISystemUnitHandler, SystemUnitHandler>()
            
            .AddTransient<IComputerService, ComputerService>()
            .AddTransient<ISystemUnitService, SystemUnitService>()
            ;
    }
}
