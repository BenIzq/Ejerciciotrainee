using System;

public class Ejercicio12
{
  static void Main(string[] args)
        {
            int n;
            double media = 0 ;
            int total = 0;
            
                Console.Write("Ingrese un numero del 1 al 1000: ");
                n = int.Parse(Console.ReadLine());

                if (n < 1 || n > 1000)
                {
                    Console.WriteLine("El numero ingresado no esta entre 1 a 1000.");
                }
                      

            for (int i = 1; i <= n; i++)
              {
                total = total + i;
                media = total / i;
              }

            

            Console.WriteLine("El total es " + total);
            Console.WriteLine("La media es " + media);

            Console.ReadKey();
        }
}
