using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el ancho:");
            double width = double.Parse(Console.ReadLine());

            double length = width * 2;
            double perimeter = (length + width) * 2;
            double numberOfPosts = perimeter / 2;

            Console.WriteLine("La cantidad de postes es: " + numberOfPosts);
            Console.ReadKey();
        }
    }
}
