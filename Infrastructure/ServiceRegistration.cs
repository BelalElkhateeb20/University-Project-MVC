
using Domain.Models.Identity;
using Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServiceRegistration(this IServiceCollection services)
        {
            services.AddIdentity<User, Role>(
                options =>
                {
                    options.Password.RequireDigit = true;
                    options.User.RequireUniqueEmail = true;
                    options.SignIn.RequireConfirmedAccount = true;
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2);
                    options.Lockout.MaxFailedAccessAttempts = 5;
                    options.Lockout.AllowedForNewUsers = true;
                }).AddEntityFrameworkStores<DBContext>()
                .AddDefaultTokenProviders();
            //var emailsetting = new EmailSettings();
            //configuration.GetSection(nameof(EmailSettings)).Bind(emailsetting);
            //services.AddSingleton(emailsetting);



            return services;
        }
    }
}
