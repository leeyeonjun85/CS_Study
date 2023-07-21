

using Microsoft.Extensions.Hosting;

Console.WriteLine("=============== 종속성 주입 연습 ===============");
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddScoped<ITestAB, Test_A>();



Console.ReadKey();