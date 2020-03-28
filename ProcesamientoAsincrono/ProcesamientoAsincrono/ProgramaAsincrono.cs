using System;
using System.Threading.Tasks;

namespace ProcesamientoAsincrono
{
    class ProgramaAsincrono
    {
        static void Main(string[] args)
        {
            var porcentaje = CalcularPorcentaje(70);
            Metodo1();

            porcentaje.Wait();
            Console.ReadLine();
        }

        private static void Metodo1()
        {
            Console.WriteLine("Ejecucion asincrona del metodo 1");
        }

        static async Task<float> CalcularPorcentaje(float value)
        {
            Console.WriteLine("Tarea de calcular el 50% de una cantidad ejecutandose de manera asincrona");

            var resultado = await Task.Run(() => value * .5f);

            Console.WriteLine($"Tarea terminada. El 50% de {value} es: {resultado} ");

            return resultado;
        }
    }
}
