using System;
using System.Text;

class Program
{
  static string derecha(string oracion)
  {
    StringBuilder sb = new StringBuilder(oracion.Length);
    for (int i = oracion.Length - 1; i >= 0; i--)
    {
      sb.Append(oracion[i]);
    }
    return sb.ToString();
  }
  static void Main()
  {
    Console.WriteLine("Ingrese una oracion: ");
    string oracion = Console.ReadLine();

    if (EsPalindromo(oracion))
    {
      Console.WriteLine("Es palindromo.");
    }
    else
    {
      Console.WriteLine("No es palindromo.");
    }
    Console.ReadLine();
  }

  static bool EsPalindromo(string oracion)
  {
    StringBuilder sb = new StringBuilder(oracion.Length);
    foreach (char letra in oracion)
    {
      if (!char.IsWhiteSpace(letra))
      {
        sb.Append(char.ToLower(letra));
      }
    }

    string normal = sb.ToString();
    string alrevez = derecha(normal);
    return normal == alrevez;
  }
}