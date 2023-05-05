namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        WriteLine("Ingrese un dia de la semana");
        string dia= ReadLine();
        dia = dia.ToLower();
        if (dia.Equals("lunes") || dia.Equals("martes") || dia.Equals("miercoles") || dia.Equals("jueves") || dia.Equals("viernes"))
        {
             WriteLine("No es fin de semana");
        }
        else if (dia.Equals("sabado") || dia.Equals("domingo"))
        {
            WriteLine("Es fin de semana");
        }
        else {
            WriteLine("El dia no es valido");
        }
        }
    }
}