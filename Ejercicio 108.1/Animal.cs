using System;
public class Animal : IAnimal
{
  public void Andar()
  {
    Console.WriteLine("Está caminando.");
  }
  public void Saltar()
  {
    Console.WriteLine("Está saltando.");
  }
  public bool EsPerro(string tipo)
  {
    if (tipo.Contains("perro"))
    {
      return true;
    }
    else
    {
      return false;
    }
  }

}
