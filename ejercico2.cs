using system;

class TriajeSystem
{
    static void Main()
    {
    Console.WriteLine("== SISTEMA DE TRIAJE MÉDICO ==\n");

    Console.Write("Ingrese la temperatura del paciente (°C): ");
    double temperatura = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la presión sistólica del paciente (mmHg): ");
    double presion = double.Parse(Console.ReadLine());

    string color, recomendacion;
    if (temperatura >= 39 || presion < 90)
    {
        color = "100 ROJO (CRITICO)";
        recomendacion = "Requiere atención inmediata. Llamar a emergencias.";
    }
else if (temperatura >= 37.5 || presion < 120)
    {
        color ="75 AMARILLO (Urgente)";
        recomendacion ="Atención urgente. Consuktar con el médico lo antes posible.";   
    }
    else 
    {
        color = "50 VERDE (Estable)";
        recomendacion = "Paciente estable. Monitoreo de rutina.";
    }

Console.WriteLine("\n== RESULTADO DEL TRIAJE ==");
Console.WrtiteLine($"Temperatura: {temperatura} °C");
Console.WriteLine($"Presión Sistólica: {presion} mmHg");
Console.WriteLine($"\nClasificación: {color}");
Console.WriteLine($"Recomendación: {recomendacion}");
    }
}
