using System;
using static System.Console;


namespace Ejercicio182;

    public class Colegio
    {
      public int Id { get; set; }
      public string Nombre { get; set; }

      public ICollection<Clase> Clases { get; set; }
    }

    public class Clase
    {
      public int Id { get; set; }
      public string Nombre { get; set; }

      public int ColegioId { get; set; }
      public Colegio Colegio { get; set; }

      public ICollection<Profesor> Profesores { get; set; }
      public ICollection<Alumno> Alumnos { get; set; }
    }

    public class Profesor
    {
      public int Id { get; set; }
      public string Nombre { get; set; }

      public int ClaseId { get; set; }
      public Clase Clase { get; set; }
    }

    public class Alumno
    {
      public int Id { get; set; }
      public string Nombre { get; set; }

      public int ClaseId { get; set; }
      public Clase Clase { get; set; }
    }

