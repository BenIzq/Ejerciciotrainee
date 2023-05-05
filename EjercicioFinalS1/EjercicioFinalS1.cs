namespace EjercicioS1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            bool primo = true; 
            Console.WriteLine("Ingresa un numero: ");
            int n = int.Parse(Console.ReadLine()); 

            if (n % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
           
            if (n > 100) 
            {
                Console.WriteLine("El numero es mayor a 100");
            }
            else
            {
                Console.WriteLine("El numero es menor o igual a 100");
            }

            for (int i = 2; i < numero; i++)
            {
                if ((numero%i)==0)
                {
                    esPrimo=false;
                }
            }
            if (primo == true) 
            {
                Console.WriteLine("El numero  es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
            
        }
    }
}
