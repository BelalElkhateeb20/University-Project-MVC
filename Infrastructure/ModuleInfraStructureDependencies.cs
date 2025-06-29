using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Abstractions;
using Infrastructure.Repositories;

namespace Infrastructure
{
    public static class ModuleInfraStructureDependencies
    {
        public static IServiceCollection AddInfraStructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepo, StudentRepo>();
            return services;
        }
    }
}
