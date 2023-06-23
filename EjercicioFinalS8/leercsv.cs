using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Ejerciciofinal
{
  class CsvLoader
  {
    private SqlConnection connection;

    public CsvLoader(SqlConnection connection)
    {
      this.connection = connection;
    }

    public void CargarDatosDesdeCsv(string rutaArchivo)
    {
      try
      {
        using (StreamReader reader = new StreamReader(rutaArchivo))
        {
          string linea;
          while ((linea = reader.ReadLine()) != null)
          {
            string[] datos = linea.Split(',');

            int id = int.Parse(datos[0]);
            string origen = datos[1];
            string destino = datos[2];
            DateTime fecha = DateTime.Parse(datos[3]);
            decimal precio = decimal.Parse(datos[4]);
            string aereopuerto = datos[5];

            string query = "INSERT INTO vuelos (id, origen, destino, fecha, precio, aereopuerto) VALUES (@id, @origen, @destino, @fecha, @precio, @aereopuerto)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
              command.Parameters.AddWithValue("@id", id);
              command.Parameters.AddWithValue("@origen", origen);
              command.Parameters.AddWithValue("@destino", destino);
              command.Parameters.AddWithValue("@fecha", fecha);
              command.Parameters.AddWithValue("@precio", precio);
              command.Parameters.AddWithValue("@aereopuerto", aereopuerto);
              command.ExecuteNonQuery();
            }
          }
        }

        Console.WriteLine("Datos cargados desde el archivo CSV correctamente.");
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error al cargar los datos desde el archivo CSV: " + ex.Message);
      }
    }
  }
}
