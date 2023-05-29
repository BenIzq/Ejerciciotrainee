using System;
using System.Collections;
using System.Collections.Generic;

public class Revista : Material
{
  public int Edicion { get; set; }

  public Revista(string titulo, int edicion) : base(titulo)
  {
    Edicion = edicion;
  }

  public void Prestar()
  {
    if (Disponible)
    {
      Disponible = false;
      Console.WriteLine("La revista ha sido prestada");
    }
    else
    {
      Console.WriteLine("La revista ya se presto");
    }
  }
}