using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre: ");
            String nombre = Console.ReadLine();
            Console.Write("Hola, " + nombre);
            Console.ReadKey();
        }
    }
}