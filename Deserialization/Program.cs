namespace Deserialization;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("== Deserialize From Json String ==");
		DeserializeFromJsonString.Execute();
		Console.WriteLine("\n");

		Console.WriteLine("== Deserialize From File ==");
		DeserializeFromFile.Execute();
		Console.WriteLine("\n");
	}
}