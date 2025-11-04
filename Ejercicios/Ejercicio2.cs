using System;
using System.Collections.Generic;
using System.Linq;
/*
Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla
cuántos son mayores de edad y cuántos no.
*/
partial class Program
{
    static void Ejercicio2()
    {
        List<int> list = new List<int> {18, 21, 15, 14, 17, 55, 60, 33, 70, 81, 31, 65, 54, 66, 45, 75, 76, 29, 13, 88};

        int mayoresEdad = list.Count(e => e >= 18);
        int menoresEdad = list.Count - mayoresEdad;
        Console.WriteLine($"Mayores de Edad: {mayoresEdad}");
        Console.WriteLine($"Menores de Edad: {menoresEdad}");
    }
}
