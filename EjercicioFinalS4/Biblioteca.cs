public class Biblioteca : IBiblioteca
{
  private List<Material> materiales;
  public Biblioteca()
  {
    materiales = new List<Material>();
  }

  public void AgregarMaterial(Material material)
  {
    materiales.Add(material);
  }

  public void PrestarMaterial(Material material)
  {
    if (material.Disponible)
    {
      material.Prestar();
    }
    else
    {
      Console.WriteLine("No esta disponible.");
    }
  }

  public void DevolverMaterial(Material material)
  {
    material.Devolver();
  }
}