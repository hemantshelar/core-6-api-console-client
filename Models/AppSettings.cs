using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core_6_api_console_client.Models
{
	public class AppSettings
	{
        public WFAPIDetails WFAPIDetails { get; set; }

    }

	public class WFAPIDetails
	{
        public string WetherForecastApiEndPoint { get; set; }
	}
}
