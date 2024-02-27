

using System.Security.Cryptography.X509Certificates;

class Program
{
    
    public static void Main(string[] args)//main
    {
        Empresa empresa1 = new Empresa();
        empresa1.Agregar(new Empleado { Id = 1, Nombre = "Juan", Edad = 30, Salario = 15000 });
        empresa1.Agregar(new Empleado { Id = 2, Nombre = "Maria", Edad = 25, Salario = 12000 });
        dynamic listaFiltroEmpleado;
        listaFiltroEmpleado = empresa1.Filtrar(12000);
        foreach(Empleado empleadoFiltrado in listaFiltroEmpleado)
        {
            Console.WriteLine("Empleado Id: {0}, Nombre: {1}, Edad: {2}, Salario: {3}",
                 empleadoFiltrado.Id, empleadoFiltrado.Nombre, empleadoFiltrado.Edad, empleadoFiltrado.Salario);
        }      

    }
    
}

public static class ExtensionEmpresa
{
    public static List<Empleado> Filtrar(this Empresa paramEmpresa, double paramSalario)
    {
        return paramEmpresa.ListaEmpleado.Where(e => e.Salario > paramSalario).ToList();
    }
}


public class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Salario { get; set; }
}
public partial class Empresa
{
    public  List<Empleado> ListaEmpleado
    {
        get
        {
            return ListaEmpleado;
        }
        set
        {
            
        }
    }
    public Empresa()
    {
        if(ListaEmpleado == null)
        {
            ListaEmpleado = new List<Empleado>();
        }
    }
}

public partial class Empresa
{
    public void Agregar(Empleado paramEmpleado)
    {
        ListaEmpleado.Add(paramEmpleado);
    }
    public void Eliminar(Empleado paramEmpleado)
    {
        ListaEmpleado.Remove(paramEmpleado);
    }
    public void MostrarListaEmpleado()
    {
        foreach (var item in ListaEmpleado)
        {
            Console.WriteLine("Empleado Id: {0}, Nombre: {1}, Edad: {2}, Salario: {3}", item.Id, item.Nombre, item.Edad, item.Salario);
        }
    }
}