class Program
{
    static async Task Main()
    {
        Console.WriteLine("Inicio del programa");

        //llamamos a un metodo asincrono entero y almacenamos el resultado
        int resultado = await TareaDeLargaDuracion();
        Console.WriteLine("El resultado de la tarea ejecutada es : ", resultado);
        Console.WriteLine("Continua con otras operaciones...");
        Console.WriteLine("Fin del programa");
    }
    static async Task<int> TareaDeLargaDuracion()
    {
        Console.WriteLine("Inicio de la tarea de larga duración...");
        //Simulamos proceso que demora 5 segundos
        await Task.Delay(5000);
        Console.WriteLine("La tarea de larga duración finalizo");
        return 10;
    }
}