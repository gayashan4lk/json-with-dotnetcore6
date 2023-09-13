using System.Text.Json;
using Domain;

namespace Deserialization;

public static class DeserializeFromJsonString
{
	public static void Execute()
	{
		// String variable that contains the JSON text
		var jsonString = @"{
		   ""Date"":""2021-12-01T00:00:00-06:00"",
		   ""TemperatureCelsius"":17,
		   ""Summary"":""Overcast Clouds"",
		   ""Pressure"":1018,
		   ""Humidity"":85,
		   ""Coordinates"":{
		      ""Lon"":-83.9167,
		      ""Lat"":9.8667
		   },
		   ""Wind"":{
		      ""Speed"":1.79,
		      ""Degree"":157,
		      ""Gust"":3.58
		   },
		   ""SummaryWords"":[
		      ""Cool"",
		      ""Windy"",
		      ""Humid""
		   ]
		}";

		var result = JsonSerializer.Deserialize<WeatherForecast>(jsonString);

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