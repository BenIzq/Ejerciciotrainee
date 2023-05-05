using System;

public class Ejercicio9
{
         static void Main(string[] args)
        {
            int[] n = new int[50];
            int contador = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    n[contador] = i;
                    contador++;
                }
            }
            for (int i = 0; i < n.Length; i++) {
                Console.WriteLine(n[i]);
            } 
        }
    }
