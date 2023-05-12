using System;

namespace Ejercicio1;
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        if (nombre.ToLower() == "alejandro")
        {
            Console.WriteLine("Hola");
        }
        else
        {
            Console.WriteLine("No te conozco");
        }

        Console.ReadLine();
    }
}
