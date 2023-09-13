using System.Text.Json;
using Domain;

namespace AsyncDeserialization
{
	public class Program
	{
		static async Task Main(string[] args)
		{
			Console.WriteLine("== Async Deserialization ==");

			var fileName = "WeatherForecast.json";
			var filePath = $"..\\..\\..\\{fileName}";

			using FileStream openStream = File.OpenRead(filePath);

			var result = await JsonSerializer.DeserializeAsync<WeatherForecast>(openStream);

			if (result == null)
			{
				Console.WriteLine("Serialization failed!");
				return;
			}

			Console.WriteLine(result);
			Console.WriteLine($"Date: {result.Date}");
			Console.WriteLine($"Temp: {result.TemperatureCelsius} oC");
			Console.WriteLine($"Summary: {result.Summary}");
			Console.WriteLine($"Pressure: {result.Pressure}");
			Console.WriteLine($"Humidity: {result.Humidity}");
			Console.WriteLine($"Coordinates: {result.Coordinates}");
			Console.WriteLine($"Wind: {result.Wind}");
			Console.WriteLine($"SummaryWords: {result.SummaryWords}");
		}
	}
}