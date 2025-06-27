using Microsoft.Extensions.DependencyInjection;

namespace SingleResponsibilityPrincipalLearning
{
    public class SingleResponsibilityPrincipal
    {
        public static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();
        }
        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<>();

            return services;
        }
    }
}

    