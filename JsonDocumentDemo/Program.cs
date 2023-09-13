using System.Text.Json;

namespace JsonDocumentDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var fileName = "weather.json";
			var filePath = $"..\\..\\..\\{fileName}";

			string jsonStr = File.ReadAllText(filePath);

			using (JsonDocument doc = JsonDocument.Parse(jsonStr))
			{
				JsonElement root = doc.RootElement;

				//Console.WriteLine(root.ToString());

				JsonElement temp = root.GetProperty("temperaturecelsius");
				//Console.WriteLine(temp.ToString());

				JsonElement last7days = root.GetProperty("last7days");
				//Console.WriteLine(last7days.ToString());

				foreach (var measure in last7days.EnumerateArray())
				{
					if (measure.TryGetProperty("temperature", out JsonElement dayTemp))
					{
						Console.WriteLine($"Temp: {dayTemp.ToString()}");
					}

					if (measure.TryGetProperty("humidity", out JsonElement dayHumidity))
					{
						Console.Write($"Humidity: {dayHumidity.ToString()}\n");
					}
				}

			}
		}
	}
}