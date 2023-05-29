using System;
namespace genericos
{
  public class genericos<T>
  {
    public List<T> listado;
    public Generica()
    {
      listado = new List<T>();
    }

    public bool AgregarItem(T item)
    {
      try
      {
        listado.Add(item);
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public void ImprimirLista()
    {
      Console.WriteLine("lista");
      foreach (var item in listado)
      {
        Console.WriteLine(item);
      }
    }
  }
}
