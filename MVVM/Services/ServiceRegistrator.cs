using BusinessLayer;
using BusinessLayer.Abstract;
using BusinessLayer.Handlers;
using BusinessLayer.Services;
using BusinessLayer.Validators;
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

            .AddTransient< SizeValidator>()
            .AddTransient< PowerValidator>()
            .AddTransient<FormFactorValidator>()

            .AddTransient<ISingleUnitService, SingleUnitService>()
            .AddTransient<IComputerService, ComputerService>()
            .AddTransient<ISystemUnitService, SystemUnitService>()
            ;
    }
}
