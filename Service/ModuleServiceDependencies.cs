using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Abstractions;
using Infrastructure.Implementaion;
using Service.Abstractions;
using Service.Implementaion;

namespace Infrastructure
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<ISubject_SectionService, Subject_SectionService>();
            return services;
        }
    }
}
