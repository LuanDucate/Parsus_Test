using Test.Services.Interface;
using Test.Services.Services;

namespace Test.Integration.DependencyInjection
{
    public static class ServiceCollector
    {
        public static void AddInjection(this IServiceCollection services) {
            services.AddTransient<IPersonService, PersonService>();
        }
    }
}