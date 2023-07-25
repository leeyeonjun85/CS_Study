using EFCore_SQLite_WinForms.Controllers;
using EFCore_SQLite_WinForms.Models;
using EFCore_SQLite_WinForms.Repositories;
using EFCore_SQLite_WinForms.Repositories.Interfaces;
using EFCore_SQLite_WinForms.Views;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore_SQLite_WinForms
{
    internal static class Program
    {
        private static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            // 서비스 등록
            services.AddScoped<ModelContext>();

            services.AddTransient<ISchoolRepository, SchoolRepository>();
            services.AddTransient<IStudentRepository, StudentRepository>();

            services.AddSingleton<MainController>();

            services.AddSingleton<IMain>(provider =>
            {
                IMain mainView = new MainView();
                var controler = provider.GetRequiredService<MainController>();
                controler.SetView(mainView);
                return mainView;
            });

            return services.BuildServiceProvider();
        }



        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = ConfigureServices();
            var mainView = services.GetRequiredService<IMain>();
            Application.Run((Form)mainView);
            //Application.Run(new MainForm());
        }
    }
}