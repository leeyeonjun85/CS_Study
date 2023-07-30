using EFCore_SQLite_WinForms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EFCore_SQLite_WinForms;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        //Application.Run(new Form1());

        // Service Add
        var services = new ServiceCollection()
            .AddSingleton<Form1>()
            .AddLogging(builder =>
            {
                builder.AddEventLog();
            })
            .AddDbContext<ModelContext>(options
                => options.UseSqlite("Data Source=EFCore_SQLite_WinForms.db"))
            .BuildServiceProvider()
            .GetRequiredService<Form1>();
        Application.Run(services);
    }    
}