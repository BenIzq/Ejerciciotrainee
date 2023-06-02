using System;
using static System.Console;


namespace Ejercicio2;
class Program
{
  internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Empieza a cocinar");

            Receta receta = new Receta();
            await receta.Hacer();

            Console.WriteLine("Servido");
        }
    }
}