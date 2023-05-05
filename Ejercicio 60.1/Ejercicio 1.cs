using System;

public class Ejercicio1
{
  static void Main(string[] args)
  {
    double CambioD, dolares, euros;

    Console.Write("Ingrese el tipo de cambio de dolar a euro ");
    CambioD = Convert.ToDouble(Console.ReadLine());

    Console.Write("Para convertir de dolar a euro seleccione 1,  de euro a dolar seleccione 2? ");
    int n = int.Parse(Console.ReadLine());

    if (n == 1)
    {
      Console.Write("Ingrese la cantidad de dolares: ");
      dolares = Convert.ToDouble(Console.ReadLine());
      euros = dolares * CambioD;
      Console.WriteLine("Equivale a " + euros);
    }
    else if (n == 2)
    {
      Console.Write("Ingrese la cantidad de euros: ");
      euros = Convert.ToDouble(Console.ReadLine());
      dolares = euros / CambioD;
      Console.WriteLine("Equivale a " + dolares);
    }
    Console.ReadKey();
  }
}
