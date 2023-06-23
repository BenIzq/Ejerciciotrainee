using System;
using System.Data.SqlClient;

namespace Ejerciciofinal
{
  internal class connect
  {
    string servidor = "Server=tcp:pruebas.database.windows.net,1433;Initial Catalog=prueba;Persist Security Info=False;User ID=Benixered;Password=contraseña;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
    public SqlConnection cconectar = new SqlConnection();

    public connect()
    {
      cconectar.ConnectionString = servidor;
    }

    public void Conectar()
    {
      try
      {
        cconectar.Open();
        Console.WriteLine("Conexión Exitosa");
      }
      catch (Exception ex)
      {
        Console.WriteLine("No se pudo conectar: " + ex.Message);
      }
    }
  }
}
