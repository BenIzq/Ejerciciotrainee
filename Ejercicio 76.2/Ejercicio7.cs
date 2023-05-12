using System;
using System.Collections.Generic;
public class Ejercicio7
{
  static void Main(string[] args)
  {
    List<string> nombres = new List<string>();
    for (int i = 0; i < 5; i++)
    {
      Console.Write("Ingresa un nombre: ");
      string nombre = Console.ReadLine();
      nombres.Add(nombre);
    }
    Console.Write("Que nombre quieres buscar?");
    string nombreBuscado = Console.ReadLine();

    if (nombres.Contains(nombreBuscado))
    {
      Console.WriteLine("Si esta en la lista.");
    }
    else
    {
      Console.WriteLine("No esta en la lista");
    }
    Console.ReadLine();
  }
}
