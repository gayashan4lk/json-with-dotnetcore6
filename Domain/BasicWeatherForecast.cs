namespace Domain
{
	public class BasicWeatherForecast
	{
		public DateTimeOffset Date { get; set; }
		public int TemperatureCelsius { get; set; }
		public string? Summary { get; set; }
	}
}