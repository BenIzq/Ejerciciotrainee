using System;
using System.Data;
using System.Data.SqlClient;

namespace Ejerciciofinal
{
  class Program
  {
    static void Main(string[] args)
    {
      connect conexion = new connect();
      conexion.Conectar();
      CsvLoader csvLoader = new CsvLoader(conexion.cconectar);
      csvLoader.CargarDatosDesdeCsv("C:/Users/benja/OneDrive/Desktop/Vuelos disponibles.csv");

      string opcion;
      do
      {
        Console.WriteLine("Menú:");
        Console.WriteLine("1. Buscar fila por origen");
        Console.WriteLine("2. Buscar fila por destino");
        Console.WriteLine("3. Salir");
        Console.Write("Seleccione una opción: ");
        opcion = Console.ReadLine();

        switch (opcion)
        {
          case "1":
            Console.Write("Ingrese el origen: ");
            string origen = Console.ReadLine();
            BuscarPorOrigen(conexion.cconectar, origen);
            break;
          case "2":
            Console.Write("Ingrese el destino: ");
            string destino = Console.ReadLine();
            BuscarPorDestino(conexion.cconectar, destino);
            break;
          case "3":
            Console.WriteLine("Cerrando...");
            break;
          default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
        }

        Console.WriteLine();
      } while (opcion != "3");

      conexion.cconectar.Close();
    }

    static void BuscarPorOrigen(SqlConnection connection, string origen)
    {
      string query = $"SELECT * FROM vuelos WHERE origen = '{origen}'";
      SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
      DataTable dataTable = new DataTable();
      adapter.Fill(dataTable);

      if (dataTable.Rows.Count > 0)
      {
        Console.WriteLine("Resultados encontrados:");
        foreach (DataRow row in dataTable.Rows)
        {
          Console.WriteLine("ID: " + row["id"]);
          Console.WriteLine("Origen: " + row["origen"]);
          Console.WriteLine("Destino: " + row["destino"]);
          Console.WriteLine("Fecha: " + row["fecha"]);
          Console.WriteLine("Precio: " + row["precio"]);
          Console.WriteLine("Aereopuerto: " + row["aereopuerto"]);
          Console.WriteLine();
        }
      }
      else
      {
        Console.WriteLine("No se encontraron resultados para el origen especificado.");
      }
    }

    static void BuscarPorDestino(SqlConnection connection, string destino)
    {
      string query = $"SELECT * FROM vuelos WHERE destino = '{destino}'";
      SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
      DataTable dataTable = new DataTable();
      adapter.Fill(dataTable);

      if (dataTable.Rows.Count > 0)
      {
        Console.WriteLine("Resultados encontrados:");
        foreach (DataRow row in dataTable.Rows)
        {
          Console.WriteLine("ID: " + row["id"]);
          Console.WriteLine("Origen: " + row["origen"]);
          Console.WriteLine("Destino: " + row["destino"]);
          Console.WriteLine("Fecha: " + row["fecha"]);
          Console.WriteLine("Precio: " + row["precio"]);
          Console.WriteLine("Aereopuerto: " + row["aereopuerto"]);
          Console.WriteLine();
        }
      }
      else
      {
        Console.WriteLine("No se encontraron resultados para el destino especificado.");
      }
    }
  }
}
