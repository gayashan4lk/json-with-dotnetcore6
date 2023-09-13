using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class FullWeatherForecast : WeatherForecast
	{
		public int Pressure { get; set; }
		public int Humidity { get; set; }
		public Coordinates? Coordinates { get; set; }
		public Wind? Wind { get; set; }
		public string[]? SummaryWords { get; set; }
	}
}
