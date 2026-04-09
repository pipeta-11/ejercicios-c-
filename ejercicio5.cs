using System;

class Program
{
    static void Main()
    {
        int turno;
        string continuar = "S";

        while (continuar.ToUpper() == "S")
        {
            Console.Write("Ingrese número de turno: ");
            turno = int.Parse(Console.ReadLine()!);
            while (turno <= 0)
            {
                Console.WriteLine("Error: El turno debe ser mayor a 0");
                Console.Write("Ingrese número de turno: ");
                turno = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("Turno " + turno + " registrado");
            Console.Write("¿Desea continuar? (S/N): ");
            continuar = Console.ReadLine()!;
        }

        Console.WriteLine("Programa finalizado.");
    }
}
