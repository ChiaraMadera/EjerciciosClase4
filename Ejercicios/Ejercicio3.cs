/*
Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que
tenga menos letras de todos.
*/

partial class Program
{
    static void Ejercicio3()
    {
        List<string> list = new List<string> {"Chiara", "Mario", "Silvio", "Julio", "Joaquin", "Eva"};

        string masLetras = list.OrderByDescending(n => n.Length).First();
        string masCorto = list.OrderBy(n => n.Length).First();

        Console.WriteLine($"El nombre mas largo: {masLetras}");
        Console.WriteLine($"El nombre con menos letras: {masCorto}");
    }
}
