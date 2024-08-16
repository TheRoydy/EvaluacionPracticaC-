using Practica;
using System;

public class Persona
{
    public String Nombre { get; set; }
    public int Edad { get; set; }
    public String Direccion { get; set; }

    public Persona(String nombre, int edad, String direccion)
    {
        Nombre = nombre;
        Edad = edad;
        Direccion = direccion;
    }

    public Persona()
    {
        Nombre = "Yordy";
        Edad = 19;
        Direccion = "Neiva";
    }

    // Método virtual que puede ser sobrescrito en la clase derivada
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Dirección: {Direccion}");
    }

    public static void Main(String[] args)
    {
        Empleado empleado = new Empleado();
        empleado.MostrarInformacion();
    }

}

public class Empleado : Persona, ICalculable
{
    public double Salario { get; set; }
    public int DiasTrabajados { get; set; }

    // Constructor que inicializa los atributos heredados y el nuevo atributo
    public Empleado(String nombre, int edad, String direccion, double salario, int diasTrabajados)
        : base(nombre, edad, direccion) 
    {
        Salario = salario;
        DiasTrabajados = diasTrabajados;
    }

    public Empleado()
    {
        Nombre = "Yordy";
        Edad = 19;
        Direccion = "Neiva";
        Salario = 1300000;
        DiasTrabajados = 6;
    }

    //Implementamos el metodo de la interfaz
    public double calcularSalario()
        {
            double operacion = Salario / 30;
            return operacion * DiasTrabajados;
        }

    // Sobrescribimos el método para mostrar la información 
    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Salario: {calcularSalario()}");
    }
}
