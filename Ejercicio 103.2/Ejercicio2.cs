using System;
using static System.Console;

namespace Ejercicio2;
class Program
{
    private static List<Alumno> listaAl = new List<Alumno>();
    private static List<Profesor> listaProf = new List<Profesor>();
    
    static void Main(string[] args)
    {
        var contador = 0;
        while (contador < 5)
        {
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Ingrese la edad:");
            int edad = Console.ReadLine();


            Console.WriteLine("Escriba 1 si es alumno o 2 si es profesor");
            int tipo = Console.ReadLine();
            switch (tipo)
            {
                case 1:
                    EsAlumno(nombre, edad);
                    cantidad++;
                    break;
                case 2:
                    EsProfesor(nombre, edad);
                    cantidad++;
                    break;
            }

        }

        imprimir();
        Console.WriteLine();
    }
    public static void Alumno(string nombre, int edad)
    {
        Console.WriteLine("Ingrese el número:");
        int numeroal = Console.ReadLine();
        listaAl.Add(new Alumno(nombre, edad, numeroal));
    }

    public static void esProfe(string Nombre, int Edad)
    {
        Console.WriteLine("Ingrese materia:");
        string materia = Console.ReadLine();
        listaProf.Add(new Profesor(nombre, edad, materia));
    }

    public static void imprimir()
    {

        Console.WriteLine("Alumnos");
        foreach (var persona in listaAl)
        {
            Console.WriteLine(persona.nombre + " " + persona.edad + " " + persona.numeroal);
        }


        Console.WriteLine("Profesores");
        foreach (var persona in listaProf)
        {
            Console.WriteLine(persona.nombre + " " + persona.edad + " " + persona.materia);
        }
    }
}