public class Program
{
    
    private static void Main(string[] args)
    {
        List<int> listaenteros = new List<int>();
        listaenteros.Add(1);

        A<int,int,int> oA = new A<int,int,int>();
        oA.Algo(1, 2, 3);
        A<string,string,string> oA2 = new A<string,string,string>();
        oA2.Algo("hola", " como", " estas?");

    }
}

public class A<T,P,C>
{
    public void Algo(T t,P p,C c)
    {
        Console.WriteLine();
    }
}
// 