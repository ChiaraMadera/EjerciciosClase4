using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Diccionario de calificaciones: Crear un diccionario donde la clave sea el nombre del
alumno y el valor sea su nota. El programa debe permitir:
a. Agregar alumnos y sus notas.
b. Mostrar el promedio general del curso.
c. Indicar el alumno con mejor nota y el de peor nota.
d. Hint: usar Dictionary<string, double> y recorrer con foreach
*/
partial class Program
{
    static void Ejercicio9()
    {
        Dictionary<string, double> notas = new Dictionary<string, double>();
        string nombre;

        Console.WriteLine("Ingrese alumnos y sus notas (fin para terminar): ");
        while (true)
        {
            Console.Write("Nombre del Alumno: ");
            nombre = Console.ReadLine();
            if (nombre.ToLower() == "fin") break;

            Console.Write("Nota: ");
            double nota = double.Parse(Console.ReadLine());
            notas[nombre] = nota;
        }
        double promedio = notas.Values.Average();
        var mejorAlumno = notas.MaxBy(x => x.Value);
        var peorAlumno = notas.MinBy(x => x.Value);

        Console.WriteLine($"\n Promedio del Curso: {promedio:F2}");
        Console.WriteLine($"Mejor Alumno:{mejorAlumno.Key} ({mejorAlumno.Value})");
        Console.WriteLine($"Peor Alumno: {peorAlumno.Key}({peorAlumno.Value})");
    }
}
