namespace Deserialization;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("== Deserialize From Json String == \n");
		DeserializeFromJsonString.Execute();

		Console.WriteLine("== Deserialize From File == \n");
		DeserializeFromFile.Execute();
	}
}