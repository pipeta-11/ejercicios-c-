using System;

class Paciente
{
    private string nombre;
    private int edad;
    private string genero;

    public string GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public int GetEdad()
    {
        return edad;
    }

    public void SetEdad(int edad)
    {
        this.edad = edad;
    }

    public string GetGenero()
    {
        return genero;
    }

    public void SetGenero(string genero)
    {
        this.genero = genero;
    }

    public void MostrarPerfil()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("       PERFIL DE PACIENTE         ");
        Console.WriteLine("==================================");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad + " años");
        Console.WriteLine("Género: " + genero);
        Console.WriteLine("==================================\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Paciente p1 = new Paciente();
        Paciente p2 = new Paciente();

        Console.WriteLine("Ingrese datos del paciente 1:");
        Console.Write("Nombre: ");
        p1.SetNombre(Console.ReadLine());
        Console.Write("Edad: ");
        p1.SetEdad(int.Parse(Console.ReadLine()));
        Console.Write("Género: ");
        p1.SetGenero(Console.ReadLine());

        Console.WriteLine("\nIngrese datos del paciente 2:");
        Console.Write("Nombre: ");
        p2.SetNombre(Console.ReadLine());
        Console.Write("Edad: ");
        p2.SetEdad(int.Parse(Console.ReadLine()));
        Console.Write("Género: ");
        p2.SetGenero(Console.ReadLine());

        Console.WriteLine();
        p1.MostrarPerfil();
        p2.MostrarPerfil();
    }
}
