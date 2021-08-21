using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.ViewModels.Registrator
{
    public static class ViewModelRegistrator
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services) => services
            .AddSingleton<MainWindowViewModel>()
            .AddSingleton<ConfigPageViewModel>()
            .AddSingleton<ExistingUnitsPageViewModel>()
            ;
    }
}
