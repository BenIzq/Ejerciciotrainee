using System;
using System.ComponentModel.Design;
using System.IO;
using System.Net;
using Newtonsoft.Json;
class Program
{
  static void Main()
  {
    string chuckapi = "https://api.chucknorris.io/jokes/random";
    string filePath = "ElBromas.txt";
    int opcion = 0;

    while (opcion != 3)
    {
      Console.WriteLine("Ingrese una opción (1, 2, 3):");
      Console.WriteLine("1. Obtener");
      Console.WriteLine("2. Buscar");
      Console.WriteLine("3. Salir");
      opcion = int.Parse(Console.ReadLine());

      switch (opcion)
      {
        case 1:
          chiste broma = Obtener(chuckapi);
          Console.WriteLine("Chiste obtenido: " + broma.Value);
          bool Existe = bromaExiste(broma.Id, filePath);
          if (!Existe)
          {
            guardar(broma, filePath);
            Console.WriteLine("Chiste guardado");
          }
          else
          {
            Console.WriteLine("El chiste ya existe en el archivo.");
          }
          break;
        case 2:
          Console.Write("Ingresa una palabra para buscar chistes: ");
          string buscar = Console.ReadLine();
          List<chiste> resultados = buscador(buscar, filePath);
          if (resultados.Count > 0)
          {
            Console.WriteLine("Resultados para la palabra " + buscar);
            foreach (chiste result in resultados)
            {
              Console.WriteLine("ID: " + result.Id);
              Console.WriteLine("Chiste: " + result.Value);
              Console.WriteLine();
            }
          }
          else
          {
            Console.WriteLine("No se encontraron chistes");
          }
          break;
        case 3:
          Environment.Exit(0);
          break;
        default:
          Console.WriteLine("La opción ingresada no es válida.");
          break;
      }
    }
  }
  static bool bromaExiste(string id, string filePath)
  {
    if (File.Exists(filePath))
    {
      using (StreamReader reader = new StreamReader(filePath))
      {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
          chiste chisteguardado = chiste.FromFileString(line);
          if (chisteguardado != null && chisteguardado.Id == id)
          {
            return true;
          }
        }
      }
    }
    return false;
  }
  static chiste Obtener(string chuckapi)
  {
    using (WebClient client = new WebClient())
    {
      string response = client.DownloadString(chuckapi);
      return JsonConvert.DeserializeObject<chiste>(response);
    }
  }

  static void guardar(chiste joke, string filePath)
  {
    using (StreamWriter writer = File.AppendText(filePath))
    {
      writer.WriteLine(joke.ToFileString());
    }
  }

  static List<chiste> buscador(string buscar, string filePath)
  {
    List<chiste> resultados = new List<chiste>();
    if (File.Exists(filePath))
    {
      using (StreamReader reader = new StreamReader(filePath))
      {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
          chiste chisteguardado = chiste.FromFileString(line);
          if (chisteguardado != null && chisteguardado.Value.Contains(buscar))
          {
            resultados.Add(chisteguardado);
          }
        }
      }
    }
    return resultados;
  }
}