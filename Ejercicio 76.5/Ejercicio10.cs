using System;

public class Ejercicio10
{
        static void Main(string[] args)
    {
        int n, sump = 0, sumi = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                sump += n;
            }
            else
            {
                sumi += n;
            }
        }

        int total = sump - sumi;

        Console.WriteLine("La suma de los pares es: " + sump);
        Console.WriteLine("La suma de los impares es " + sumi);
        Console.WriteLine("El resultado es: " + total);
    }
    }
