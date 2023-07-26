using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace DX1
{
    internal static class Program
    {
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<Form1>()
                    .AddLogging()
                    .AddScoped<IBusinessLayer, CBusinessLayer>()
                    .AddScoped<IDataAccessLayer, CDataAccessLayer>();
        }

        



        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }
    }
}
