using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Simulador de atención en ventanilla: Usar una cola (Queue) para simular la atención
de clientes en una ventanilla bancaria.
a. Encolar nombres de clientes.
b. Atender (desencolar) uno por uno hasta que no queden.
c. Mostrar en pantalla quién está siendo atendido y cuántos quedan en la fila.
d. Hint: usar Enqueue(), Dequeue() y Count.
*/
partial class Program
{
    static void Ejercicio10()
    {
        Queue<string> fila = new Queue<string>();
        fila.Enqueue("Chiara");
        fila.Enqueue("Julio");
        fila.Enqueue("Santiago");
        fila.Enqueue("Pablo");

        Console.WriteLine("Simulacion de atencion en ventanilla:\n");

        while (fila.Count > 0) 
        { 
            string atendido = fila.Dequeue();
            Console.WriteLine($"Atendiendo a: {atendido}");
            Console.WriteLine($"Quedan en fila: {fila.Count}");
            Console.WriteLine();
        }

        Console.WriteLine("Todos los clientes fueron atendidos.");

    }
}
