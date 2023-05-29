using System;
using System.Collections;
using System.Collections.Generic;
using System;

public interface IBiblioteca
{
  public void prestar(Material material);
  public void devolver(Material material);
  public void agregar(Material material);
}