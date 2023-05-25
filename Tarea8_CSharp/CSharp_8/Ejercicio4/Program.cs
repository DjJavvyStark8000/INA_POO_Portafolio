using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Construya un programa que permita leer una cantidad
            //variable de números indicando finalmente lo siguiente:
            //	cuantos fueron pares
            //	cuantos fueron impares
            //	cuántos fueron múltiplos de tres

            int userInput = -1;
            int even = 0;
            int odd = 0;
            int multi3 = 0;


            while (userInput != 0)
            {
                Console.WriteLine("Ingrese cualquier numero o el cero para terminar: ");
                userInput = int.Parse(Console.ReadLine());
                if(userInput != 0)
                {
                    if (userInput % 2 == 0)
                    {
                        even++;
                    }
                    else if (userInput % 3 == 0)
                    {
                        multi3++;
                        odd++;
                    }
                    else
                    {
                        odd++;
                    }
                }
                Console.Clear();
            }
            Console.WriteLine($"Cantidad Pares: {even}\nCantidad Impares: {odd}\nCantidad Multiplos de tres: {multi3}");
            Console.ReadKey();
        }
    }
}
