using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net;

namespace MainForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        //{
        //    // To customize application configuration such as set high DPI settings or default font,
        //    // see https://aka.ms/applicationconfiguration.
        //    ApplicationConfiguration.Initialize();
        //    Application.Run(new MainForm());
        //}

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider1 = new ServiceCollection();
            var serviceProvider2 = serviceProvider1.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=products.db"));
            //var serviceProvider2 = serviceProvider1.AddDbContext<ApplicationDbContext>(options => options.UseOracle("User Id=testuser1;Password=0330;Data Source=localhost:1521/XEPDB1;"));
            //var serviceProvider3 = serviceProvider2.AddSingleton<IProductService, ProductService>();
            var serviceProvider3 = serviceProvider2.AddScoped<IProductService, ProductService>();
            var serviceProvider4 = serviceProvider3.BuildServiceProvider();
            var serviceProvider5 = serviceProvider4.GetRequiredService<MainForm>();

            // Run the main form with DI
            Application.Run(serviceProvider5);
        }


    }
}