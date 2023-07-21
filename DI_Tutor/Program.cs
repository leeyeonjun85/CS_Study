using DI_A;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Runtime.InteropServices;

namespace DI_Tutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== 종속성 주입 연습 ===============");

            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddScoped<ITestAB, Test_A>();
            using IHost host = builder.Build();

            Test_Tutor test_Tutor = new Test_Tutor();
            test_Tutor.method1();
            test_Tutor.method2();

            Console.ReadKey();
        }
    }
}