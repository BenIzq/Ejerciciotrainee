using System;
using System.Collections.Generic;
public class Barco : Vehiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando");
        }
        public override void Anclar()
        {
            Console.WriteLine("Anclar");
        }
    }
