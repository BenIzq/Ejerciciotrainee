using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el nombre:");
            string name = Console.ReadLine();
            Console.WriteLine("Ingresa la ciudad:");
            string city = Console.ReadLine();
            Console.Write("Hola " + name + " bienvenido a " + city);
            Console.ReadKey();
        }
    }
}