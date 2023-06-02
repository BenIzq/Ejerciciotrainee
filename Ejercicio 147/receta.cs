using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion14_Ejercicio1
{
    public class Receta
    {
        public async Task Hacer()
        {
            await Batir();
            await Mezclar();
            await Pelar();
            await Cortar();
            await Cocinar();
        }

        private async Task Pelar()
        {
            Console.WriteLine("Pelando");
            await Task.Delay(2000);
            Console.WriteLine("listo");
        }

        private async Task Cortar()
        {
            Console.WriteLine("Cortando");
            await Task.Delay(1500);
            Console.WriteLine("listo.");
        }

        private async Task Batir()
        {
            Console.WriteLine("Batiendo");
            await Task.Delay(1000);
            Console.WriteLine("listo");
        }

        private async Task Mezclar()
        {
            Console.WriteLine("Mezclando");
            await Task.Delay(2000);
            Console.WriteLine("Ingredientes listos.");
        }

        private async Task Cocinar()
        {
            Console.WriteLine("Cocciendo...");
            await Task.Delay(3000);
            Console.WriteLine("Está listo");
        }
    }
}