using System;
using System.Collections.Generic;
public class Ejercicio9
{
  static void Main(string[] args)
  {
    
    List<int> coleccion = new List<int>();
    int mayor = coleccion[0];
    int menor = coleccion[0];

    for (int i = 0; i < 10; i++)
    {
      Console.Write("Ingresa un numero: ");
      int numero = Convert.ToInt32(Console.ReadLine());
      coleccion.Add(numero);
    }
    
    foreach (int numero in coleccion)
    {
      if (numero > mayor)
      {
        mayor = numero;
      }
      if (numero < menor)
      {
        menor = numero;
      }
    }
    Console.WriteLine("El mayor es: " + mayor);
    Console.WriteLine("El menor es: " + menor);
    Console.ReadLine();
  }
}
