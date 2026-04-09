using System;

class Program
{
    static double CalcularDosis(double peso, double dosisPorKg)
    {
        double dosis = peso * dosisPorKg;
        return dosis;
    }

    static void MostrarResultado(string nombre, double dosis)
    {
        Console.WriteLine("\nPaciente: " + nombre);
        Console.WriteLine("Dosis recomendada: " + dosis + " mg");
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese el nombre del paciente: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el peso del paciente (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la dosis por kg (mg): ");
        double dosisPorKg = Convert.ToDouble(Console.ReadLine());

        double dosisFinal = CalcularDosis(peso, dosisPorKg);
        MostrarResultado(nombre, dosisFinal);
    }
}
