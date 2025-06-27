using SingleResponsibilityPrincipalLearning.Presentation;
using SingleResponsibilityPrincipalLearning.Business.Car;
using SingleResponsibilityPrincipalLearning.Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using SingleResponsibilityPrincipalLearning.Business.CarProcesses;

namespace SingleResponsibilityPrincipalLearning
{
    public class SingleResponsibilityPrincipal
    {
        public static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();

            var program = serviceProvider.GetRequiredService<Demo>();
            program.Run();
        }
        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<Demo, Demo>();
            services.AddScoped<IEngine, Engine>();
            services.AddScoped<IMusicSystem, MusicSystem>();
            services.AddScoped<ITrunk, Trunk>();
            services.AddScoped<ITripLogger, TripLogger>();
            services.AddScoped<GoodCar, GoodCar>();
            services.AddScoped<IBadCar, BadCar>();


            return services.BuildServiceProvider();
        }
    }
}

    