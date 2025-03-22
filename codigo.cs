using System;
using System.Collections.Generic;

class InputHandler
{
    public static List<double> ObtenerCalificaciones()
    {
        List<double> calificaciones = new List<double>();
        string entrada;

        Console.WriteLine("Ingrese las calificaciones (escriba 'fin' para terminar):");

        while (true)
        {
            Console.Write("Calificación: ");
            entrada = Console.ReadLine();

            if (entrada.ToLower() == "fin")
                break;

            if (double.TryParse(entrada, out double calificacion))
            {
                if (calificacion >= 0 && calificacion <= 10) // Ajusta el rango si es necesario
                {
                    calificaciones.Add(calificacion);
                }
                else
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 10.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingrese un número.");
            }
        }

        return calificaciones;
    }

    // Método de prueba
    static void Main()
    {
        List<double> calificaciones = ObtenerCalificaciones();
        Console.WriteLine("\nCalificaciones ingresadas: " + string.Join(", ", calificaciones));
    }
}
