using System;
using System.Collections.Generic;
using System.Linq;

class ProcessingHandler
{
    public static void ProcesarCalificaciones(List<double> calificaciones)
    {
        if (calificaciones.Count == 0)
        {
            Console.WriteLine("No se ingresaron calificaciones para procesar.");
            return;
        }

        double promedio = calificaciones.Average();
        double max = calificaciones.Max();
        double min = calificaciones.Min();

        Console.WriteLine("\nResultados del procesamiento:");
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Calificación más alta: {max}");
        Console.WriteLine($"Calificación más baja: {min}");
    }

    // Método de prueba
    static void Main()
    {
        List<double> calificaciones = InputHandler.ObtenerCalificaciones();
        ProcesarCalificaciones(calificaciones);
    }
}
