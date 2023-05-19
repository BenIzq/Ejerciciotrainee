using System;
using static System.Console;

namespace Ejercicio1;
class Program
{
    private static  List<Persona> personas = new List<Persona>();
    static void Main(string[] args)
    {
        int contador = 0;
        while (contador < 5)
        {
            WriteLine("Ingrese el nombre");

            String nombre = Console.ReadLine().ToString();
            Console.WriteLine($"Ingrese edad de {nombre}:");
            String edad = Convert.ToInt32(Console.ReadLine());

            personas.Add(new Persona(nombre, edad));
            contador++;
        }
        mayores();
    Console.writeline();
        }

    public static void mayores()
    {
        foreach (var persona in personas)
        {
            if(persona.edad >= 18){
                WriteLine(persona.nombre);
            }
        }
    }
}