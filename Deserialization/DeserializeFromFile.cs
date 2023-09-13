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
		Console.WriteLine($"Summery: {result.Summary}");
	}
}