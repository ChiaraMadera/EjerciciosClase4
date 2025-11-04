using System;
using System.Collections.Generic;
using System.Linq;

/*
Dado que se tiene almacenado en una lista, los resultados de los últimos 10
exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10 notas de
los exámenes y el promedio resultante.
*/
partial class Program
{
    static void Ejercicio1()
    {
        List<double> list = new List<double> {7.7, 6, 10, 5, 8.1, 4, 2.2, 9, 5.5, 4.9};
        Console.WriteLine("Notas: ");
        list.ForEach(list => Console.WriteLine($"- {list}"));

        double promedio = list.Average();
        Console.WriteLine($"El promedio es: {promedio:F2}");
    }
}
