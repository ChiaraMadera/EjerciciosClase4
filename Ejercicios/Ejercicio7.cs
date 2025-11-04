using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera
fila y la primera columna se debe guardar los números (de 0 a 9), estando el cero en
la primera posición (fila 0, columna 0). El resto de los lugares debe ser calculado
usando los números que se dispone, por ejemplo, en la fila 1, calcular 1*1, 1*2, 1*3,
etc. usando las posiciones del array o arreglo. Al finalizar el cálculo, mostrar la matriz
por pantalla
*/
partial class Program
{
    static void Ejercicio7()
    {
        int[,] tabla = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            tabla[0, i] = i;
            tabla[i, 0] = i;
        }

        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                tabla[i, j] = i * j;
            }    
        }
        Console.WriteLine("******Tabla del 1 al 9*****\n");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{tabla[i, j],3}");
            }
            Console.WriteLine();
        }
    }
}
