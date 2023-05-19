using System;
using System.Collections.Generic;

namespace Ejercicio3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Ingrese el primer numero:");
      double numero1 = Console.ReadLine();

      Console.WriteLine("Ingrese el segundo numero:");
      double numero2 = Console.ReadLine();

      Console.WriteLine($"Su resultado: {Producto.Suma(numero1, numero2)}");
      Console.ReadKey();
    }
  }
}