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
        string nombrelowe = nombreJugador.ToLower();
        Jugador jugador = new Jugador(nombrelowe);

        List<Jugador> jugadoresGuardados = Jugador.CargarDatos("datos.bin");
        jugadoresGuardados.Add(jugador);
        Jugador.GuardarDatos(jugadoresGuardados, "datos.bin");

        Console.WriteLine("Ingrese el nombre de usuario del jugador a buscar: ");
        string nombreBuscado = Console.ReadLine();
        string minuscula = nombreBuscado.ToLower();
        Jugador jugadorBuscado = jugadoresGuardados.Find(j => j.usuario == minuscula);
        if (jugadorBuscado != null)
        {
            Console.WriteLine("Jugador encontrado:");
            Console.WriteLine("Nickname: " + jugadorBuscado.usuario);
            Console.WriteLine("Nivel: " + jugadorBuscado.nivel);
            Console.WriteLine("Puntos de vida: " + jugadorBuscado.puntos);
            Console.WriteLine("Numero de reinicios: " + jugadorBuscado.muertes);
        }
        else
        {
            Console.WriteLine("Jugador no encontrado.");
        }
    }
}

}