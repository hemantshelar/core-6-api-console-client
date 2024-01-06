using core_6_api_console_client.IServices;
using core_6_api_console_client.Models;
using core_6_api_console_client.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace core_6_api_console_client;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        #region Load configuration
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appSettings.json")
            .Build();
		#endregion


		var serviceCollection = new ServiceCollection();
        serviceCollection.AddTransient<IWeatherForecastProvider,WeatherForecastProvider>();
        serviceCollection.AddLogging();
        serviceCollection.AddOptions();
        //serviceCollection.Configure<WFAPIDetails>(options => config.GetSection("WFAPIDetails"));
        
        //This is important in order to inject dependency to WeatherForecastProvider constructor.
        //Initially could not locate Bind extension method but after installing package
        //Microsoft.Extensions.Hosting  things wokred magically.
        serviceCollection.AddOptions<WFAPIDetails>().Bind(config.GetSection("WFAPIDetails"));


        var sp = serviceCollection.BuildServiceProvider();

        IWeatherForecastProvider wfp = sp.GetService<IWeatherForecastProvider>();

        var t = config.GetSection("WFAPIDetails:WetherForecastApiEndPoint");
        Console.WriteLine("OK");

    }
}
