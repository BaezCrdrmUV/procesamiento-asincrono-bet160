using System;
using System.Threading.Tasks;

namespace ProcesamientoAsincrono
{
    class ProgramaAsincrono
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cantidad entera para calcular su 50%");
            int cantidad = int.Parse(Console.ReadLine());

            var porcentaje = CalcularPorcentaje(cantidad);
            Metodo1();

            porcentaje.Wait();
            Console.ReadLine();
        }

        private static void Metodo1()
        {
            Console.WriteLine("Ejecucion asincrona del metodo 1");
        }

        static async Task<float> CalcularPorcentaje(int value)
        {
            Console.WriteLine("Tarea de calcular el 50% de una cantidad ejecutandose de manera asincrona");

            var resultado = await Task.Run(() => value * .5f);

            Console.WriteLine($"Tarea terminada. El 50% de {value} es: {resultado} ");

            return resultado;
        }
    }
}
