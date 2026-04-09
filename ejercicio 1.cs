using System;
using System.Globalization;

class Program
{
    static void Main()
    { 
        string nombre;
        int edad;
        double peso;
        double estatura;
        DateTime fechaRegistro = DateTime.Now;

        Console.Write("Ingrese el nombre del paciente: ");
        nombre = Console.ReadLine()!;

        Console.Write("Ingrese la edad: ");
        edad = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el peso del paciente: ");
        peso = double.Parse(Console.ReadLine()!.Replace(",", "."), CultureInfo.InvariantCulture);

        Console.Write("Ingrese la estatura del paciente: ");
        estatura = double.Parse(Console.ReadLine()!.Replace(",", "."), CultureInfo.InvariantCulture);

        Console.Write("¿El paciente cuenta con seguro? (S/N): ");
        string respuesta = Console.ReadLine()!.ToUpper();

        bool tieneSeguro = respuesta == "S";

        double imc;
        string clasificacion;

        imc = peso / (estatura * estatura);

        if (imc < 18.5)
            clasificacion = "Bajo peso";
        else if (imc < 25)
            clasificacion = "Peso normal";
        else if (imc < 30)
            clasificacion = "Sobrepeso";
        else
            clasificacion = "Obesidad";

        Console.WriteLine("╔═══════════════════════════════════╗");
        Console.WriteLine("║     FICHA MÉDICA DEL PACIENTE     ║");
        Console.WriteLine("╠═══════════════════════════════════╝");
        Console.WriteLine("║ Fecha de ingreso: " + fechaRegistro);
        Console.WriteLine("║ Nombre: " + nombre + "        ║");
        Console.WriteLine("║ Edad: " + edad + " años" + "                     ║");
        Console.WriteLine("║ IMC: " + imc.ToString("0.0") + " (" + clasificacion + ")" + "             ║");
        Console.WriteLine("║ Seguro: " + (tieneSeguro ? "Sí" : "No") + "                        ║");
        Console.WriteLine("╚═══════════════════════════════════╝");
