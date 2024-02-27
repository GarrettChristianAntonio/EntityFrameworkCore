class Program
{
    static async Task Main()
    {
        Console.WriteLine("Inicio del programa");

        //Iniciamos tareas asíncronas
        Task tarea1 = OperacionAsincrona(8);
        Task tarea2 = OperacionAsincrona(3);
        Task tarea3 = OperacionAsincrona(6);
        Task tarea4 = OperacionAsincrona(7);

        Console.WriteLine("Realizo otras operaciones");

        await Task.WhenAll( tarea2, tarea3, tarea4);
        Console.WriteLine("Fin de la aplicación...");
        Console.ReadKey();
    }
    static async Task OperacionAsincrona(int numero)
    {
        Console.WriteLine($"Inicio de operación número {numero}");
        await Task.Delay(TimeSpan.FromSeconds(numero));
        Console.WriteLine($"Fin deoperación número {numero}");
    }
}