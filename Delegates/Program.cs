
namespace Delegates
{
    public class Program
    {
        public delegate void Mostrar(string cadena);
        public static void Main(string[] args)
        {
            Mostrar mostrar = Show;
           
            HacerAlgo(mostrar);
        }
        public static void Show(string cad)
        {
            Console.WriteLine("Hola soy un delegado"+ cad);
        }
        public static void HacerAlgo(Mostrar funcionFinal)
        {
            Console.WriteLine("hago algo");
            funcionFinal("se envio desde otra función");
        }
    }
}








