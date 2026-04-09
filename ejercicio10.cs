using System;
using System.Collections.Generic;

class Usuario
{
    public string user;
    public string pass;
}

class Cita
{
    public string paciente;
    public string fecha;
}

class Program
{
    static void Main(string[] args)
    {
        Usuario u = new Usuario();
        List<Cita> citas = new List<Cita>();

        Console.WriteLine("=== REGISTRO DE USUARIO ===");
        Console.Write("> Cree su usuario: ");
        u.user = Console.ReadLine();

        Console.Write("> Cree su contraseña: ");
        u.pass = Console.ReadLine();

        Console.WriteLine("\n=== LOGIN ===");

        string user, pass;

        Console.Write("> Usuario: ");
        user = Console.ReadLine();

        Console.Write("> Contraseña: ");
        pass = Console.ReadLine();

        if (user != u.user || pass != u.pass)
        {
            Console.WriteLine("❌Credenciales incorrectas.");
            return;
        }

        int opcion = 0;

        do
        {
            Console.WriteLine("\n=======================================");
            Console.WriteLine(" SISTEMA DE CITAS - CLÍNICA SAN JOSÉ ");
            Console.WriteLine("=======================================\n");
            Console.WriteLine("1. Registrar Cita");
            Console.WriteLine("2. Ver Citas Guardadas");
            Console.WriteLine("3. Salir");

            Console.Write("\n> Opción: ");

            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error: Solo se permiten números.");
                continue;
            }

            if (opcion == 1)
            {
                Cita c = new Cita();

                Console.Write("> Paciente: ");
                c.paciente = Console.ReadLine();

                Console.Write("> Fecha: ");
                c.fecha = Console.ReadLine();

                citas.Add(c);

                Console.WriteLine(" Cita registrada correctamente.");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("\n--- CITAS REGISTRADAS ---");

                if (citas.Count == 0)
                {
                    Console.WriteLine("No hay citas registradas.");
                }
                else
                {
                    for (int i = 0; i < citas.Count; i++)
                    {
                        Console.WriteLine("Paciente: " + citas[i].paciente + " | Fecha: " + citas[i].fecha);
                    }
                }
            }

        } while (opcion != 3);
    }
}
