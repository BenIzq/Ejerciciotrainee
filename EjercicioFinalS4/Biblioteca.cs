public class Biblioteca : IBiblioteca
{
  private List<Material> materiales;
  public Biblioteca()
  {
    materiales = new List<Material>();
  }
  public void agregar(Material material)
  {
    materiales.Add(material);
  }
  public void prestar(Material material)
  {
      material.Prestar();
  }
  public void devolver(Material material)
  {
    material.Devolver();
  }
}