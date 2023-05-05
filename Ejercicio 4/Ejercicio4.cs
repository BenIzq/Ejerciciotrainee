namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cual es el precio del producto? ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("¿Va a pagar con tarjeta o efectivo? ");
            string pago = Console.ReadLine().ToLower(); 

            if (pago == "tarjeta")
            {
                Console.WriteLine("Ingrese el numero de cuenta: ");
                string cuenta = Console.ReadLine();

            }            
            Console.WriteLine("Se pago con " + pago);
            Console.WriteLine("Su numero de cuenta es: " + cuenta);
            Console.WriteLine("El precio del producto es: $" + precio);
            
        }
    }
}