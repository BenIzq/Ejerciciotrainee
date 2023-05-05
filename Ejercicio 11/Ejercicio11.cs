using System;

public class Ejercicio11
{
  static void Main(string[] args)
  {
    Console.WriteLine("ingresa un numero entre 1 y 7");
    int n1 = int.Parse(Console.ReadLine());
    switch (n1)
    {
      case 1:
        Console.WriteLine("Lunes");
        break;
      case 2:
        Console.WriteLine("Martes");
        break;
      case 3:
        Console.WriteLine("Miercoles");
        break;
      case 4:
        Console.WriteLine("Jueves");
        break;
      case 5:
        Console.WriteLine("Viernes");
        break;
      case 6:
        Console.WriteLine("Sabado");
        break;
      case 7:
        Console.WriteLine("Domingo");
        break;
    }
  }
}
