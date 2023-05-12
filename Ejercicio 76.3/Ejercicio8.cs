using System;
using System.Collections.Generic;
public class Ejercicio8
{
  static void Main(string[] args)
  {
    int Par = 0;
    int Impar = 0;
    List<int> coleccion = new List<int>();
    for (int i = 0; i < 10; i++)
    {
      Console.Write("Ingresa un numero: ");
      int numero = Convert.ToInt32(Console.ReadLine());
      coleccion.Add(numero);
    }
    foreach (int numero in coleccion)
    {
      if (numero % 2 == 0)
      {
        Par += numero;
        Console.WriteLine("Suma par: " + Par);
      }
      else
      {
        Impar += numero;
        Console.WriteLine("Suma impar" + Impar);
      }
    }
    Console.WriteLine("El total de los pares es " + Par);
    Console.WriteLine("El total de los impares es" + Impar);
    Console.ReadLine();
  }
}
