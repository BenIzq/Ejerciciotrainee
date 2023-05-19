using System;
using System.Collections;
using System.Collections.Generic;

public class Alumno
{
  public string Nombre { get; set; }
  public string Apellido { get; set; }
  public int Identificacion { get; set; }
  public string Carrera { get; set; }
  public List<int> Notas { get; set; }

  public Alumno(string nombre, string apellido, int identificacion, string carrera, List<int> notas)
  {
    Nombre = nombre;
    Apellido = apellido;
    Identificacion = identificacion;
    Carrera = carrera;
    Notas = notas;
  }
}