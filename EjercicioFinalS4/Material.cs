using System;
using System.Collections;
using System.Collections.Generic;

public abstract class Material
{
  public bool Disponible { get; set; }
  public string Titulo { get; set; }

  public Material(string titulo)
  {
    Disponible = true;
    Titulo = titulo;    
  }
}