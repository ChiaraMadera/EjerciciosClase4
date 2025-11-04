using System;
using System.Collections.Generic;

/*
Crear una variable para guardar los nombres de elementos para una “lista de
supermercado”. Solicitar al usuario que ingrese el nombre de un elemento que va a
comprar en el super y verificar que el elemento esté en la lista. Si no está, agregarlo
e indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba. Al
finalizar mostrar por pantalla los elementos que no compró y los que compró, pero
no estaban en la lista. Si se quiere, mostrar también todos los elementos que el
usuario compró. Para salir el usuario debe ingresar “fin”.
*/
partial class Program
{
    static void Ejercicio4()
    {
        List<string> elementos = new List<string> {"huevos", "harina", "pan", "carne", "arroz"};
        List<string> vendidos = new List<string>();
        List<string> agregados = new List<string>();

        string input;
        Console.WriteLine("Ingrese producto a comprar (fin para salir): ");

        while (true) 
        {
            Console.Write("Producto: ");
            input = Console.ReadLine()?.ToLower();

            if (input == "fin") break;
            if (elementos.Contains(input))
            {
                Console.WriteLine("El producto esta en la lista. Producto eliminado.");
                elementos.Remove(input);
                vendidos.Add(input);
            }
            else
            {
                Console.WriteLine("El producto no esta en la lista. Producto agregado.");
                elementos.Add(input);
                agregados.Add(input);
            }
        }
        Console.WriteLine("Productos no comprados: " + string.Join(",", elementos));
        Console.WriteLine("Productos nuevos que compraste: " + string.Join(",", agregados));
    }
}
