using System;

class Program
{
    static void Main()
    {
        int total = 0;
        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Ingrese la cantidad de vacunas aplicadas el {dias[i]}: ");
            int vacunas = int.Parse(Console.ReadLine());
            total += vacunas;
        }

        double average = total / 7.0;
        Console.WriteLine($"Total de vacunas aplicadas: {total}");
        Console.WriteLine($"Promedio diario: {average:F2}");
    }
}
