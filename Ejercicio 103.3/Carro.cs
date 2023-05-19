using System;
using System.Collections.Generic;

namespace Carro
{
     public class Carro : Vehiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }
        public override void Frenar()
        {
            Console.WriteLine("Frenando");
        }
    }
}