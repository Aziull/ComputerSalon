using Microsoft.Extensions.Hosting;
using MVVM.Data;
using MVVM.Services;
using MVVM.ViewModels.Registrator;
using System;
using System.Windows;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IHost host;

        public static IHost Host => host ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
        public static IServiceProvider Services => Host.Services;
        public static IHostBuilder CreateHostBuilder(string[] args) => Microsoft.Extensions.Hosting.Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(
                (hostContext, services) => services
                    .AddDatabase(hostContext.Configuration.GetSection("Database"))
                    .AddServices()
                    .AddViewModels()
                );
        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Host;

            base.OnStartup(e);

            await host.StartAsync();
        }
        protected override async void OnExit(ExitEventArgs e)
        {
            var host = Host;
            base.OnExit(e);
            await host.StopAsync();

        }
    }
}
