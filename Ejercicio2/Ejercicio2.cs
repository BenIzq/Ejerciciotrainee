namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un numero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa un numero: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1 + " es mayor");
            }
            else
            {
                Console.WriteLine(n2 + " es mayor");
            }
        }
    }
}