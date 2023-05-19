using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class Program
{
  static void Main(string[] args)
  {
    List<Alumno> listaAlumnos = new List<Alumno>();
    listaAlumnos.Add(new Alumno("Juan", "Tuneado", 1001, "Ingenieria", new List<int>() { 5, 4, 10, 3, 7 }));
    listaAlumnos.Add(new Alumno("Armando", "Cajas", 1002, "Ingenieria", new List<int>() { 2, 1, 8, 9, 4 }));
    listaAlumnos.Add(new Alumno("Adam", "Smith", 1003, "Medicina", new List<int>() { 6, 7, 8, 9, 10 }));
    listaAlumnos.Add(new Alumno("Danny", "Pudi", 1004, "Agronomia", new List<int>() { 7, 4, 5, 5, 6 }));
    listaAlumnos.Add(new Alumno("Jessie", "Ennies", 1005, "Medicina", new List<int>() { 6, 6, 6, 6, 6 }));

    foreach (Alumno alumno in listaAlumnos)
    {
      double promedio = alumno.Notas.Average();

      if (promedio >= 6)
      {
        Console.WriteLine("Nombre: " + alumno.Nombre + " " + alumno.Apellido);
        Console.WriteLine("Numero de Identificacion: " + alumno.Identificacion);
        Console.WriteLine();
      }
    }
    Console.ReadLine();
  }
}