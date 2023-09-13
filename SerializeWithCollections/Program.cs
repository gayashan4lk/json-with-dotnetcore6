using System.Text.Json;
using Domain;

namespace SerializeWithCollections
{
	public class Program
	{
		static void Main(string[] args)
		{
			var fullWeatherForecast = new WeatherForecast
			{
				Date = DateTime.Parse("2021-12-01"), 
				TemperatureCelsius = 17,
				Summary = "Overcast Clouds",
				Pressure = 1018,
				Humidity = 85,
				Coordinates = new Coordinates()
				{
					Lon = -83.9167,
					Lat = 9.8667
				},
				Wind = new Wind()
				{
					Speed = 1.79,
					Degree = 157,
					Gust = 3.58
				},
				SummaryWords = new[] { "Cool", "Windy", "Humid" }
			};

			string jsonString = JsonSerializer.Serialize(fullWeatherForecast);

			Console.WriteLine(jsonString);
		}
	}
}