/*
Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares
pares. Imprimir la matriz por pantalla
*/

partial class Program
{
    static void Ejercicio5()
    {
        char[,] matriz = new char[5, 5];
        for (int i = 0; i < 5; i++)
        {
            string fila = " ";
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = ((i + j) % 2 == 0) ? 'P' : 'I';
                fila += matriz[i, j] + " ";
            }
            Console.WriteLine(fila);
        }
        Console.WriteLine("\n");
    }
}
