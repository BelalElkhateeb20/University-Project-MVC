using Core;
using Core.Features.Account.Commands.Model;
using Infrastructure;
using Infrastructure.Context;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Globalization;

namespace School_Project_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            #region Database Configuration
            builder.Services.AddDbContext<DBContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DBContext"));
            });

            #endregion

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(SignInCommand).Assembly));

            #region Dependency Injection  
            builder.Services.AddInfraStructureDependencies()
               .AddServiceDependencies()
               .AddCoreDependencies()
               .AddServiceRegistration();
            #endregion
            #region Localization
            builder.Services.AddControllersWithViews();
            builder.Services.AddLocalization(opt =>
            {

                opt.ResourcesPath = "";
            });

            builder.Services.Configure<RequestLocalizationOptions>(options =>
            {
                List<CultureInfo> supportedCultures =
                [
                        new CultureInfo("en-US"),
                        new CultureInfo("de-DE"),
                        new CultureInfo("fr-FR"),
                        new CultureInfo("ar-EG"),
                        new CultureInfo("ar"),
                        new CultureInfo("en"),
                ];

                options.DefaultRequestCulture = new RequestCulture("en-US", uiCulture: "en-US");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            #region Localization Middleware
            var locoptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locoptions.Value);
            #endregion
            app.UseAuthorization();
            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
