using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ejercicio3;

  internal class Program
  {
    static void Main(string[] args)
    {
      WriteLine("Escribe una oracion");
      var frase = ReadLine();
      var cantPalabras = frase.Split(' ').Length;

      if (cantPalabras >= 4 && frase.Length >= 20)
      {
        WriteLine($"Longitud:\t{frase.Length} caracteres");

        frase = frase.Replace("a", "x");
        frase = frase.Replace("A", "X");
        WriteLine($"Remplazar la letra \"a\" por \"x\":\t{frase}");

        WriteLine($"Cadena en mayusculas:\t{frase.ToUpper()}");
        WriteLine($"Cadena en minusculas:\t{frase.ToLower()}");

        WriteLine($"removiendo las 3 primeras letras:\t{frase.Substring(3, (frase.Length - 3))}");

        WriteLine($"extrayendo las letras en las posiciones de la 5 a la 10:\t{frase.Remove(5, 5)}");

        var inversa = "";
        for (int i = (frase.Length - 1); i >= 0; i--)
        {
          inversa += frase[i];
        }
        WriteLine($"invierte la cadena:\t{inversa}");

        WriteLine($"numero de palabras:\t{frase.Split(' ').Length}");

        WriteLine($"escribir solo la tercera palabra:\t{frase.Split(' ')[2]}");
      }
      else
      {
        WriteLine("Necesita tener 4 palabras y 20 caracteres");
      }
      ReadKey();


    }
  }
