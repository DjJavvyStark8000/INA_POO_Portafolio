using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese segundos:");
            int totalSeconds = int.Parse(Console.ReadLine());

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = (totalSeconds % 3600) % 60;

            Console.WriteLine("Horas: " + hours);
            Console.WriteLine("Minutos: " + minutes);
            Console.WriteLine("Segundos: " + seconds);
            Console.ReadKey();
        }
    }
}
