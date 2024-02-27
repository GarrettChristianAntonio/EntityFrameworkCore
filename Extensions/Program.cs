using System.Runtime.CompilerServices;

public class Program
{
  
    private static void Main(string[] args)
    {
        String cadena = "pato";
        Console.WriteLine(cadena.Saludo());
    }
}

public static class StringExtension
{
    public static string Saludo(this String s)
    {
        return "Hola " + s;
    }
}
