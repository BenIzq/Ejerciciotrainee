using System;

public class Ejercicio13
{
  static void Main(string[] args)
  {
    bool primo = true;
    Console.WriteLine("Ingresa un numero: ");
    int n = int.Parse(Console.ReadLine());
    int contador = 0;
    for (int i = 1; i <= n; i++)
    {
      if (n % i == 0)
      {
        contador++;
      }

    }
    if (contador == 2)
    {
      Console.WriteLine("El numero es primo");
    }
    else
    {
      Console.WriteLine("El numero no es primo");
    }
    Console.ReadKey();
  }
}
