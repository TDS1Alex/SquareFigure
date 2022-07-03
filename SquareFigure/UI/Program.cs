using SquareFigure.Figures;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace SquareFigure.UI
{
    class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<IChoiceFigure>().Start();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                 .ConfigureServices(services =>
                 {
                     services.AddScoped<ICircle, Circle>();
                     services.AddScoped<ITriangle, Triangle>();
                     services.AddScoped<IChoiceFigure, ChoiceFigure>();
                 });
        }
    }
}
