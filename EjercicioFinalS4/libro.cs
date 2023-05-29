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
  public void prestar()
  {
    if (Disponible)
    {
      Console.WriteLine("El libro ha sido prestado");
      Disponible = false;
    }
    else
    {
      Console.WriteLine("El libro ya fue prestado");
    }
  }

  public void devolver()
  {
    Disponible = true;
    Console.WriteLine("El libro fue devuelto");
  }
}