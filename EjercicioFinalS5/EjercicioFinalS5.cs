using System;

namespace EjercicioFinalS5
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bienvenido al juego de aventuras BDG");

      Console.Write("Ingrese su nombre de jugador: ");
      string nombreJugador = Console.ReadLine();
      Jugador jugador = new Jugador(nombreJugador);
      jugador.GuardarDatos("datos.bin");

      Console.WriteLine("Cargando datos del jugador...");
      Jugador jugadorCargado = Jugador.CargarDatos("datos.bin");
      Console.WriteLine("Datos del jugador cargados:");
      Console.WriteLine("Nickname: " + jugadorCargado.usuario);
      Console.WriteLine("Nivel: " + jugadorCargado.nivel);
      Console.WriteLine("Puntos de vida: " + jugadorCargado.puntos);
      Console.WriteLine("Numero de reinicios: " + jugadorCargado.muertes);
    }
  }
}