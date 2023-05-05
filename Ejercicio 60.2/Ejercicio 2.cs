using System;

public class Ejercicio2
{
  static void Main(string[] args)
  {
    static double Sumar(double num1, double num2)
    {
      return num1 + num2;
    }

    static double Restar(double num1, double num2)
    {
      return num1 - num2;
    }

    static double Multiplicar(double num1, double num2)
    {
      return num1 * num2;
    }

    static double Dividir(double num1, double num2)
    {
      return num1 / num2;
    }

    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    int opcion = int.Parse(Console.ReadLine());
    double total = 0;
    Console.WriteLine("Ingrese el primer numero");
    double n1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero");
    double n2 = Convert.ToDouble(Console.ReadLine());

    switch (opcion)
    {
      case 1:
        total = Sumar(n1, n2);
        Console.WriteLine("El total de la suma es " + total);
        break;

      case 2:
        total = Restar(n1, n2);
        Console.WriteLine("El total de la resta es " + total);
        break;

      case 3:
        total = Multiplicar(n1, n2);
        Console.WriteLine("El total de la multiplicacion es " + total);
        break;

      case 4:
        if (n2 == 0)
        {
          Console.WriteLine("No se puede dividir por cero");
        }
        else
        {
          total = Dividir(n1, n2);
          Console.WriteLine("El resultado de la division es " + total);
        }
        break;

    }
    Console.ReadKey();
  }
}
