using System;
using System.Collections.Generic;

namespace Ejercicio3
{
    public class Avion : Vehiculo
    {
        public override void Acelera()
        {
            Console.WriteLine("Acendiendo");
        }
        public override void Frena()
        {
            Console.WriteLine("Descendiedo");
        }
        public void Aterriza(string destino)
        {
            Console.WriteLine("Está aterrizando en " + destino);
        }
    }
}