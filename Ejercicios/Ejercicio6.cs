/*
Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de
la semana. La estructura es para registrar la temperatura diaria de una cabina de
pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la matriz de forma
aleatoria para el mes de mayo donde el primer día inicia en lunes y el último (31) se
ubica en el miércoles (la matriz puede ser inicializada con valores aleatorios desde el
principio del programa, no es necesario pedir los valores al usuario para cada
posición). Se nos pide hacer lo siguiente:
a. Obtener la temperatura más alta y baja de la semana y que día se produjo
(lunes, martes, etc.)
b. Promedio de temperatura de la semana.
c. Temperatura más alta del mes y su día.
*/

partial class Program
{
    static void Ejercicio6()
    {
        Random rnd = new Random();
        int[,] temperatura = new int[5, 7];

        string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        for(int i = 0; i < 5; i++)
            for (int j = 0; j < 7; j++)
                temperatura[i, j] = rnd.Next(7, 39);
        for (int i = 0; i < 5; i++)
        {
            int max = int.MinValue, min = int.MaxValue, total = 0;
            int diaMax = 0, diaMin = 0;

            for (int j = 0; j < 5; j++)
            {
                int t = temperatura[i, j];
                total += t;
                if (t > max) {max = t; diaMax = j;}
                if (t < min) { min = t; diaMin = j; }
            }
            Console.WriteLine($"Dia de la Semana {i + 1}: ");
            Console.WriteLine($" - Maxima {max}° ({diasSemana[diaMax]}) | Minima {min}° ({diasSemana[diaMin]})");
            Console.WriteLine($"- Promedio: {total / 7.0:F1}°");
        }
    }
}
