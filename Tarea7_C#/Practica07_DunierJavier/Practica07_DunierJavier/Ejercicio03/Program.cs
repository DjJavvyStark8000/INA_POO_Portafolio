using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese horas:");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese minutos:");
            int minutes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundos:");
            int seconds = int.Parse(Console.ReadLine());


            int totalSeconds = CalculateTotalSeconds(hours, minutes, seconds);

            Console.WriteLine("Total de segundos: " + totalSeconds);
            Console.ReadKey();
        }

        static int CalculateTotalSeconds(int hours, int minutes, int seconds)
        {
            int totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            return totalSeconds;
        }
    }
}
