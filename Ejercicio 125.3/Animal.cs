using System;
namespace Ejercicio3s
{
	public class Animal
	{
		public string tipoAnimal { get; private set; } 
		public Animal()
		{
			tipoAnimal = "Desconocido";
		}

		public void VerificarTipoAnimal(int i)
		{
			switch (i)
			{
				case (int)animales.caballo:
					tipoAnimal="caballo";
					break;
                case (int)animales.canario:
                    tipoAnimal = "canario";
                    break;
                case (int)animales.gato:
                    tipoAnimal = "gato";
                    break;
                case (int)animales.perro:
                    tipoAnimal = "perro";
                    break;
				default:
                    tipoAnimal = "(Desconocido)";
                    break;

            }

			Console.WriteLine("ese es" + tipoAnimal );
        }
	}
}