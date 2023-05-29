using System;
using System.Collections;
using System.Collections.Generic;

public class Revista : Material
{
  public string Edicion { get; set; }

  public Revista(string titulo, string edicion) : base(titulo)
  {
    Edicion = edicion;
  }

  public void prestar()
  {
    if (Disponible)
    {
      Console.WriteLine("la revista ha sido prestada");
      Disponible = false;
    }
    else
    {
      Console.WriteLine("la revista ya se presto");
    }
  }
  public void devolver()
  {
    Console.WriteLine("la revista fue devuelta");
    Disponible = true;
  }
}