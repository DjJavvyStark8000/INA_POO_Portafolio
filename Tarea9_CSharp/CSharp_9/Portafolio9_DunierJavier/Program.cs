using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio9_DunierJavier
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Libro unLibro = new Libro();
            Libro dosLibro = new Libro("Aliens", "XYZ");
            Console.WriteLine($"Titulo: {unLibro.Titulo}");
            unLibro.Autor = "Oscar";
            Console.WriteLine($"Titulo: {unLibro.Autor}");
            Console.ReadKey();


        }

    }
}
