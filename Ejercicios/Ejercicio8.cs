using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la cantidad
que el programador decida, pero no más de la mitad de los lugares disponibles en la
matriz). El usuario deberá ingresar el lugar donde cree que hay una X, ingresando la
fila y la columna por separado. Informar si acertó o no por cada ingreso. Se debe
pedir al usuario ingresar valores por tantas X que se haya guardado. El usuario tiene
3 intentos para fallar. Al finalizar (Ya sea porque se
terminaron los 3 intentos, o el jugador acertó todas las X) imprimir por pantalla la
matriz con sus correspondientes X, mostrando un * donde no haya nada. 9.
*/
partial class Program
{
    static void Ejercicio8()
    {
        Random rnd = new Random();
        int size = 10;
        char[,] matriz = new char[size, size];
        int totalX = 5;
        int intentos = 3;
        int aciertos = 0;

        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                matriz[i, j] = '*';

        int colocadas = 0;
        while(colocadas < totalX)
        {
            int f = rnd.Next(size);
            int c = rnd.Next(size);
            if (matriz[f,c] != 'X')
            {
                matriz[f, c] = 'X';
                colocadas++;
            }
        }

        Console.WriteLine("Adivina las posiciones de las X (filas y columnas de 0 a 9)\n)");

        while(intentos > 0 && aciertos < totalX)
        {
            Console.Write("Fila: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Columna: ");
            int c = int.Parse(Console.ReadLine());

            if (matriz[f,c] == 'X')
            {
                Console.WriteLine("Acertaste\n");
                matriz[f, c] = '✔';
                aciertos++;
            }
            else
            {
                Console.WriteLine("Fallaste\n");
                intentos--;
            }
        }
        Console.WriteLine("\n *** Resultado Final *** \n");
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"\n Juego Finalizado. Numero de Aciertos: {aciertos}/{totalX}");
    }
}