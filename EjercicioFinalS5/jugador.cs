using System;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable]
public class Jugador
{
  public string usuario { get; set; }
  public int nivel { get; set; }
  public int puntos { get; set; }
  public int muertes { get; set; }

  public Jugador()
  {
  }

  public Jugador(string nombre)
  {
    this.usuario = nombre;
    this.nivel = 3;
    this.puntos = 1000;
    this.muertes = 10;
  }
  public static void GuardarDatos(List<Jugador> jugadores, string rutaArchivo)
  {
    try
    {
      using (FileStream archivo = File.OpenWrite(rutaArchivo))
      {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(archivo, jugadores);
      }
      Console.WriteLine("Partida guardada.");
    }
    catch (Exception ex)
    {
      RegistrarError(ex, "Los datos no se guardaron correctamente");
    }
  }

  public static List<Jugador> CargarDatos(string rutaArchivo)
  {
    List<Jugador> jugadores = new List<Jugador>();
    try
    {
      using (FileStream archivo = File.OpenRead(rutaArchivo))
      {
        BinaryFormatter formatter = new BinaryFormatter();
        jugadores = (List<Jugador>)formatter.Deserialize(archivo);
      }
      Console.WriteLine("Partida cargada");
    }
    catch (Exception ex)
    {
      RegistrarError(ex, "Datos cargados incorrectamente");
    }
    return jugadores;
  }
  private static void RegistrarError(Exception ex, String mensaje)
        {
            Console.WriteLine(mensaje + ex.Message);
            string mensajeError = $"\n{DateTime.Now}: {ex.Message}";
            File.AppendAllText("Errors.log", mensajeError);
        }

}