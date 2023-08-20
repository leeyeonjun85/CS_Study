using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WpfBase.Services;
using WpfBase.ViewModels;
using WpfBase.Views;

namespace WpfBase
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider _services = default!;

        private IServiceProvider ConfigurationService()
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();

            // Views
            builder.Services.AddSingleton<MainView>();
            builder.Services.AddTransient<SubView>();

            // Services
            builder.Services.AddSingleton<IViewService, ViewService>();

            // ViewModels
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddTransient<SubViewModel>();

            IHost host = builder.Build();
            return host.Services;
        }

        public App()
        {
            _services = ConfigurationService();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var viewService = (IViewService)_services.GetService(typeof(IViewService))!;
            viewService.ShowMainView();
        }
    }
}
