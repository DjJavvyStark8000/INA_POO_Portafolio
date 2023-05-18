using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los MB:");
            double megabytes = double.Parse(Console.ReadLine());

            double bits = megabytes * 8 * 1024 * 1024;
            double bytes = megabytes * 1024 * 1024;
            double kilobytes = megabytes * 1024;
            double gigabytes = megabytes / 1024;

            
            Console.WriteLine("Bits: " + bits);
            Console.WriteLine("Bytes: " + bytes);
            Console.WriteLine("Kilobytes: " + kilobytes);
            Console.WriteLine("Gigabytes: " + gigabytes);
            Console.ReadKey();
        }
    }
}
