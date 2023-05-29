using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class Program
{
  static void Main(string[] args)
  {
    Revista r1 = new Revista("Revista D", "#708");
    Libro l1 = new Libro("Dune", "Frank Herbert");
    Libro l2 = new Libro("7 habitos de la gente altamente efectiva", "John Maxwell");

    //-----------------------------------------------------------------------------
    Biblioteca biblioteca = new Biblioteca();
    biblioteca.agregar(r1);
    biblioteca.agregar(l1);
    biblioteca.agregar(l2);

    //-----------------------------------------------------------------------------
    Console.WriteLine("Quiere prestar una revista?");
    string resp = Console.ReadLine();
    if (resp == "si")
    {
      biblioteca.prestar(r1);
    }
    else if (resp == "no")
    {
      Console.WriteLine("Quieres devolver una revista?");
      if (resp == "si")
      {
        biblioteca.devolver(r1);
      }
      else if (resp == "no")
      {
        break;
      }
    }

    Console.WriteLine("Quiere prestar un libro?");
    string resp2 = Console.ReadLine();
    if (resp2 == "si")
    {
      biblioteca.prestar(l1);
    }
    else if (resp2 == "no")
    {
      Console.WriteLine("Quieres devolver un libro?");
      if (resp2 == "si")
      {
        biblioteca.devolver(l1);
      }
      else if (resp2 == "no")
      {
        break;
      }
    }
    Console.readKey();
  }
}