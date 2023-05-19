using System;

public class Ejercicio6
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Andar();
        Console.WriteLine("¿Que tipo de animal es?");
        tipo = Console.ReadLine();
        Console.WriteLine("¿Es perro? " + animal.EsPerro(tipo));
        animal.Saltar();
    }
}
