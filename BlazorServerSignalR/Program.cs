using BlazorServerSignalR.Areas.Identity;
using BlazorServerSignalR.Data;
using BlazorServerSignalR.Hubs;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerSignalR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                //options.UseSqlServer(connectionString));
                options.UseSqlite($"Data Source=BlazorServerSignalR.db"));
            builder.Services.AddDbContext<OoDbContext>(options =>
                options.UseSqlite($"Data Source=OoDb.db"));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();


            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            builder.Services.AddSingleton<WeatherForecastService>();

            //응답 압축 미들웨어 서비스 추가:
            builder.Services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                      new[] { "application/octet-stream" });
            });

            WebApplication app = builder.Build();

            // 처리 파이프라인 구성의 맨 위에 있는 응답 압축 미들웨어를 사용합니다.
            app.UseResponseCompression();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //if (builder.Environment.IsStaging())
            //{
            //    builder.WebHost.UseStaticWebAssets();
            //}

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();
            app.MapControllers();

            app.MapBlazorHub();

            //허브를 Blazor로 매핑하기 위하여 엔드포인트를 추가
            app.MapHub<ChatHub>("/chathub");
            app.MapHub<AttendanceCheck>("/attendanceCheck");

            app.MapFallbackToPage("/_Host");

            //app.Run();

            var url = "https://172.30.1.45:7076";
            url = "https://*:7076";
            app.Run(url);
        }
    }
}