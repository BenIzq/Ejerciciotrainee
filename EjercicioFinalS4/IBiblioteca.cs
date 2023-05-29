using System;
using System.Collections;
using System.Collections.Generic;
using System;

public interface IBiblioteca
{
  void AgregarMaterial(Material material);
  List<Material> BuscarPorTitulo(string titulo);
  void PrestarMaterial(Material material);
  void DevolverMaterial(Material material);
}