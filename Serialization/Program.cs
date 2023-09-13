using System.Text.Json;
using Domain;

namespace Serialization;

public class Program
{
	private static void Main(string[] args)
	{
		var weatherForecast = new WeatherForecast
		{
			Date = DateTime.Parse("2021-12-01"),
			TemperatureCelsius = 25,
			Summary = "Hot"
		};

		// 1. Basic serialization
		// Serialize 
		var jsonString = JsonSerializer.Serialize(weatherForecast);

		// Print the serialized JSON
		Console.WriteLine(jsonString);

		// 2. Serialization but with generics
		// Specify the class of the object to be serialized when calling the Serialize method
		var jsonStringGenerics = JsonSerializer.Serialize(weatherForecast);

		// Write to the console the serialized JSON text
		Console.WriteLine(jsonStringGenerics);

		//3. Serialization to a file
		// Name of the file where the JSON string is stored
		const string fileName = "output.json";

		// Write to the console the serialized JSON text
		File.WriteAllText(fileName, jsonString);
	}
}