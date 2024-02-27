public class Program
{
    delegate void Reference(string message);
    private static void Main(string[] args)
    {
        Reference reference = Console.WriteLine;
        reference("Hello world!");
    }
}
