using System;
using System.Collections;
using System.Collections.Generic;
public class Libro : Material
{
  public string Autor { get; set; }

  public Libro(string titulo, string autor) : base(titulo)
  {
    Autor = autor;
  }

  public void Prestar()
  {
    if (Disponible)
    {
      Disponible = false;
      Console.WriteLine("El libro ha sido prestado");
    }
    else
    {
      Console.WriteLine("El libro ya fue prestado");
    }
  }

  public void Devolver()
  {
    Disponible = true;
    Console.WriteLine("El libro fue devuelto");
  }
}