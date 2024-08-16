using Practica;
using System;

public class Persona
{
    public String Nombre { get; set; }
    public int Edad { get; set; }
    public String Direccion { get; set; }
    public String Telefono { get; set; }

    public Persona(String nombre, int edad, String direccion, String telefono)
    {
        Nombre = nombre;
        Edad = edad;
        Direccion = direccion;
        Telefono = telefono;
    }

    public Persona()
    {
    }

    // Método virtual para poder sobreescribir la info
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Teléfono: {Telefono}");
    }
}

public class Empleado : Persona, ICalculable
{
    public decimal Salario { get; set; }
    public int DiasTrabajados { get; set; }

    // Constructor que inicializa los atributos heredados y los nuevos atributos
    public Empleado(String nombre, int edad, String direccion, String telefono, decimal salario, int diasTrabajados)
        : base(nombre, edad, direccion, telefono)
    {
        Salario = salario;
        DiasTrabajados = diasTrabajados;
    }

    public Empleado()
    {
    }

    // Implementamos el método de la interfaz
    public decimal calcularSalario()
    {
        decimal operacion = Salario / 30;
        return Math.Round(operacion * DiasTrabajados,2);
    }

    // Sobrescribimos el método para mostrar la información 
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Su salario total por su días trabajados es de: ${calcularSalario()} COP");
    }

    public async Task MostrarSalario()
    {
        Console.WriteLine("Calculando su salario, por favor espere...");
        await Task.Delay( 2000 );
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Salario obtenido: ");
        Console.WriteLine("-------------------------------------");
        MostrarInformacion();
    }

    public static async Task Main(String[] args)
    {
        Console.WriteLine("Ingrese el nombre:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la edad:");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la dirección:");
        string direccion = Console.ReadLine();

        Console.WriteLine("Ingrese el teléfono:");
        string telefono = Console.ReadLine();

        Console.WriteLine("Ingrese el salario base:");
        decimal salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese los días trabajados:");
        int diasTrabajados = int.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------------------");

        Empleado empleado = new Empleado(nombre, edad, direccion, telefono, salario, diasTrabajados);
        await empleado.MostrarSalario();
    }
}