using System;
using System.Collections;
using System.Collections.Generic;

public abstract class Material
{
  public string Titulo { get; set; }
  public bool Disponible { get; set; }

  public Material(string titulo)
  {
    Titulo = titulo;
    Disponible = true;
  }
}