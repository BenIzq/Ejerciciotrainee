namespace Ejercicio4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Introduce un numero: ");
      int numero1 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Introduce un numero: ");
      int numero2 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Introduce un numero: ");
      int numero3 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Introduce un numero: ");
      int numero4 = Convert.ToInt32(Console.ReadLine());

      StringBuilder sb = new StringBuilder();
      sb.Append("El primer numero introducido es el ");
      sb.Append(numero1);

      sb.Append(", despues se han introducido el ");
      sb.Append(numero2);

      sb.Append(" y ");
      sb.Append(numero3);

      sb.Append(" y por ultimo el numero ");
      sb.Append(numero4);

      Console.WriteLine(sb.ToString());
      Console.ReadLine();

    }
  }
}