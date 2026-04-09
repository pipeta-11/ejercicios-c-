using System;

class Program
{
    static void Main(string[] args)
    {
        string[] medicamentos = new string[5];
        int[] cantidades = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese el nombre del medicamento " + (i + 1) + ": ");
            medicamentos[i] = Console.ReadLine();

            Console.Write("Ingrese la cantidad disponible: ");
            cantidades[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        Console.WriteLine("\n===== INVENTARIO DE MEDICAMENTOS =====");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(medicamentos[i] + " - Stock: " + cantidades[i]);
        }

        int menorStock = cantidades[0];
        int posicionMenor = 0;

        for (int i = 1; i < 5; i++)
        {
            if (cantidades[i] < menorStock)
            {
                menorStock = cantidades[i];
                posicionMenor = i;
            }
        }

        Console.WriteLine("\nMedicamento con MENOR stock:");
        Console.WriteLine(medicamentos[posicionMenor] + " - Cantidad: " + menorStock);
    }
}
