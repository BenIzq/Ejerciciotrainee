using System;
using System.Collections.Generic;

namespace Ejercicio3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Avion avion = new Avion();
      avion.Acelerar();
      avion.Frenar();
      avion.Aterrizar("Canada");

      Carro carro = new Carro();
      carro.Acelerar();
      carro.Frenar();

      Barco barco = new Barco();
      barco.Acelerar();
      barco.Anclar();
      Console.ReadKey();
    }

  }
}