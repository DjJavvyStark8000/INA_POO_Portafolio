using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    1.Construya un programa que permita leer una cantidad 
            //    de 20 números y nos indique finalmente cuantos 
            //    fueron positivos, cuantos fueron negativos y cuantas 
            //    veces se introdujo el cero.

            int countZero = 0;
            int countPositive = 0;
            int countNegative = 0;
            int userInput = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                userInput = int.Parse(Console.ReadLine());
                if (userInput == 0)
                {
                    countZero++;
                }
                else if (userInput > 0)
                {
                    countPositive++;
                }
                else if (userInput < 0)
                {
                    countNegative++;
                }
                Console.Clear();
               
            }

            Console.WriteLine($"Cantidad Positivos: {countPositive}\nCantidad Negativos: {countNegative}\nCantidad Cero: {countZero}");
            Console.ReadKey();
           


        }
    }
}
