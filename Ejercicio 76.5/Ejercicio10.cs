using System;
using System.Collections;
using System.Collections.Generic;
public class Ejercicio10
{
  static void Main(string[] args)
  {
    int ingresados = 0;
    Console.WriteLine("Cuantos numeros va a ingresar: ");
    int cantidad = Convert.ToInt32(Console.ReadLine());
    ArrayList arreglo = new ArrayList();

    while (cantidad > ingresados)
    {
      Console.WriteLine("Ingrese un numero: ");
      arreglo.Add(Console.ReadLine());
      ingresados++;
    }

    for (int i = 0; i < cantidad; i++)
    {
      Console.WriteLine(arreglo[i]);
    }

    Console.WriteLine("Ingrese un numero para agregar: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese la posicion donde lo quiere: ");
    int posicion = Convert.ToInt32(Console.ReadLine());

    arreglo[posicion] = numero;
    foreach (var item in arreglo)
    {
      Console.WriteLine(item);
    }
    Console.ReadLine();
  }
}

