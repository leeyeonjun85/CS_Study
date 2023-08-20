﻿using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Wpf_Chat.Services;
using Wpf_Chat.ViewModels;
using Wpf_Chat.Views;

namespace Wpf_Chat
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _services = default!;

        private static IServiceProvider ConfigurationService()
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder();

            // Views
            builder.Services.AddSingleton<MainView>();
            builder.Services.AddTransient<SubView>();

            // Services
            builder.Services.AddSingleton<IViewService, ViewService>();
            builder.Services.AddSingleton<ISignalRControl, SignalRControl>();

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
