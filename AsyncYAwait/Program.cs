using System;

public class Program
{
    public static async Task Main(string[] args) 
    {
        Console.WriteLine("Iniciando tarea...");

        String resultado = await ObtenerDatos();

        Console.WriteLine("Tarea Completa");
        Console.WriteLine($"Resultado: {resultado}");
    }

    public static async Task<String> ObtenerDatos() 
    {
        Console.WriteLine("Obteniendo datos....");
        await Task.Delay(3000);

        return "Datos obtenidos exitosamente";
    }
}
