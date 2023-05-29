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
    Libro libro1 = new Libro("El Gran Gatsby", "F. Scott Fitzgerald");
    Libro libro2 = new Libro("Cien años de soledad", "Gabriel García Márquez");
    Revista revista1 = new Revista("National Geographic", 2023);
    Revista revista2 = new Revista("Time", 2023);
//-----------------------------------------------------------------------------
    Biblioteca biblioteca = new Biblioteca();
    biblioteca.AgregarMaterial(libro1);
    biblioteca.AgregarMaterial(libro2);
    biblioteca.AgregarMaterial(revista1);
    biblioteca.AgregarMaterial(revista2);
//-----------------------------------------------------------------------------

    biblioteca.PrestarMaterial(libro1); 
    biblioteca.PrestarMaterial(libro1);
    biblioteca.DevolverMaterial(libro1); 
    biblioteca.DevolverMaterial(libro1);
  }
}