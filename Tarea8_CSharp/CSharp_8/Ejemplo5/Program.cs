using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Construya un programa que permita leer una cantidad
            //variable de números hasta que se ingresen 5 números
            //negativos. Indicar cantidad total de números leídos.

            int userInput = 0;
            int fiveNegs = 0;
            int total = 0;
           


            while (fiveNegs < 5)
            {
                Console.WriteLine("Ingrese cualquier numero: ");
                userInput = int.Parse(Console.ReadLine());
                if (userInput < 0)
                {
                    fiveNegs++;
                    total++;
                }
                else
                {
                    total++;
                }

                Console.Clear();
            }
            Console.WriteLine($"Cantidad total de numeros: {total}");
            Console.ReadKey();
        }

      
    }
}
