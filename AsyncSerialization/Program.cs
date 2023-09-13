using System.Text.Json;
using Domain;

namespace AsyncSerialization;

public class Program
{
	static async Task Main(string[] args)
	{
		var weatherForecast = new BasicWeatherForecast
		{
			Date = DateTime.Parse("2021-12-01"),
			TemperatureCelsius = 25,
			Summary = "Hot"
		};
		
		// Name of the file where the JSON string is stored
		const string fileName = "output.json";
		
		// Stream write data to a local File
		await using var createStream = File.Create(fileName);
		
		// Serialize it
		await JsonSerializer.SerializeAsync(createStream, weatherForecast);
		
		// Await and dispose the stream 
		await createStream.DisposeAsync();

		Console.WriteLine($"JSON file [{fileName}] created successfully.");
	}
}
