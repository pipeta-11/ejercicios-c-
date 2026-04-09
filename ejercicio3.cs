using System;

class Program
{
    static void Main()
    {
        int opcion;
    
        Console.WriteLine("========Menú de servicio clínico======="); 
        Console.WriteLine("1. Consulta");
        Console.WriteLine("2. Laboratorio");
        Console.WriteLine("3. Rayos x");
        Console.WriteLine("4. Farmacia");
        Console.WriteLine("5. Salir");
   
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Servicio: Consulta");
                Console.WriteLine("Precio: $50");
                Console.WriteLine("Tiempo de espera: 20 minutos");
                break;

            case 2:
                Console.WriteLine("Servicio: Laboratorio");
                Console.WriteLine("Precio: $80");
                Console.WriteLine("Tiempo de espera: 30 minutos");
                break;

            case 3:
                Console.WriteLine("Servicio: Rayos X");
                Console.WriteLine("Precio: $120");
                Console.WriteLine("Tiempo de espera: 40 minutos");
                break;

            case 4:
                Console.WriteLine("Servicio: Farmacia");
                Console.WriteLine("Precio: Depende del medicamento");
                Console.WriteLine("Tiempo de espera: 10 minutos");
                break;

            case 5:
                Console.WriteLine("Saliendo del sistema");
                break;
   
            default:
                Console.WriteLine("Opción inválida. Por favor seleccione una opción del 1 al 5.");
                break;
        }
    }
}
