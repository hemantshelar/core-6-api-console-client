using core_6_api_console_client.IServices;
using core_6_api_console_client.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core_6_api_console_client.Services
{
	public class WeatherForecastProvider : IWeatherForecastProvider
	{
        public WeatherForecastProvider(IOptions<WFAPIDetails> options)
        {
			Console.WriteLine(options.Value.WetherForecastApiEndPoint);
            
        }
        public object GetWeather()
		{
			Console.WriteLine("OK");
			return "Ok";
		}
	}
}
