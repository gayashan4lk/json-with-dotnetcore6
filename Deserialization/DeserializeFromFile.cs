using System.Text.Json;
using Domain;

namespace Deserialization;

public static class DeserializeFromFile
{
	public static void Execute()
	{
		var fileName = "WeatherForecast.json";
		var filePath = $"..\\..\\..\\{fileName}";

		var jsonStr = File.ReadAllText(filePath);

		var result = JsonSerializer.Deserialize<WeatherForecast>(jsonStr);

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