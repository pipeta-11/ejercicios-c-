using System;

class Program
{
    static int LeerHistoriaClinica()
    {
        int numero;
        bool valido = false;

        do
        {
            try
            {
                Console.Write("Ingrese el número de historia clínica: ");
                numero = Convert.ToInt32(Console.ReadLine());
                valido = true;
                return numero;
            }
            catch
            {
                Console.WriteLine("Error: Debe ingresar solo números.");
            }

        } while (!valido);

        return 0;
    }

    static void Main(string[] args)
    {
        int historia = LeerHistoriaClinica();
        Console.WriteLine("Historia clínica registrada: " + historia);
    }
}
