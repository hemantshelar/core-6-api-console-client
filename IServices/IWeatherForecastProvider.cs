using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core_6_api_console_client.IServices
{
    public interface IWeatherForecastProvider
    {
        object GetWeather();
    }
}
