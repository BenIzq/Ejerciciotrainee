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
    Revista r1 = new Revista("National Geographic", 2023);
    Libro l1 = new Libro("Dune", "Frank Herbert");
    Libro l2 = new Libro("7 habitos de la gente altamente efectiva", "John Maxwell");

//-----------------------------------------------------------------------------
    Biblioteca biblioteca = new Biblioteca();
    biblioteca.agregar(l1);
    biblioteca.agregar(l2);
    biblioteca.agregar(r1);
//-----------------------------------------------------------------------------
    biblioteca.prestar(r1);
    biblioteca.devolver(l1); 
    
    biblioteca.prestar(l1); 
    biblioteca.devolver(l1); 

  }
}