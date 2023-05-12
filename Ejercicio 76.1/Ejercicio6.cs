using System;
using System.Collections;
public class Ejercicio6
{
  static void Main(string[] args)
  {
    ArrayList coleccion = new ArrayList();
    int suma = 0;
    for (int i = 1; i < 1001; i++)
    {
      coleccion.Add(i);
      suma += i;
      Console.WriteLine(suma);
    }
    Console.ReadLine();
  }
}
