using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Construya un programa que permita leer una cantidad 
            //    variable de números y nos indique cuantos fueron 
            //    mayores o iguales a 100 y cuántos menores a 100, 
            //    cada vez que ingresa un número debe preguntar si 
            //    desea ingresar otro.

     
            int userInput = -1;
            int high100 = 0;
            int low100 = 0;

            while (userInput != 0)
            {
                Console.WriteLine("Ingrese cualquier numero o el cero para terminar: ");
                userInput = int.Parse(Console.ReadLine());
                if (userInput >= 100 && userInput != 0)
                {
                    high100++;
                }
                else if (userInput < 100 && userInput != 0)
                {
                    low100++;
                }
                Console.Clear();
             
            }
            Console.WriteLine($"Cantidad Mayores de 100: {high100}\nCantidad Menores de 100: {low100}");
            Console.ReadKey();
        }
    }
}
