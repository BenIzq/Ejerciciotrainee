using System;
using static System.Console;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Escribe una palabra");
            var palabra= ReadLine().ToLower();
            var alrevez = "";
            for (int i = (palabra.Length-1);i>=0; i--)
            {
                alrevez += palabra[i];
            }
            WriteLine(alrevez);
            ReadKey();
        }
    }
}