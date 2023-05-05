using System;

public class Ejercicio14
{
  static void Main(string[] args)
  {
    Console.WriteLine("Ingresa un numero: ");
    int n = int.Parse(Console.ReadLine());
    int contador = 0;
    while (n > 0)
    {
      n = n / 10;
      contador++;
    }
    Console.WriteLine("Tiene " + contador + " cifras");
    Console.ReadKey();
  }
}
