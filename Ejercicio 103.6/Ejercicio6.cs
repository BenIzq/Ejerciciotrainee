using System;
using System.Collections.Generic;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.TipoAnimal = "mapache";
            animal.ColorPelo = "rojo";
            animal.EsDomestico = false;
            animal.NumeroPatas = 4;

            Console.WriteLine("Tipo " + animal.TipoAnimal);
            Console.WriteLine("Color " +  animal.ColorPelo);
            Console.WriteLine("¿domestico? " + animal.EsDomestico);
            Console.WriteLine("Número de Patas " + animal.NumeroPatas);
            
        }
    }
}
