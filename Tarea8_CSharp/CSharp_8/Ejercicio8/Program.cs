using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        //instancing the list so it can be accessed from the other methods
        private static List<int> numbers = new List<int>();
        static void Main(string[] args)
        {
            //8.	Leer una cantidad variable de números e indicar
            //cuánto suman todos los números, y cuál es el promedio
            //de los números

            readNumbers();
            Console.WriteLine($"La suma de los numeros es {sumNumbers()}\nEl promedio es {sumNumbers() / (numbers.Count() - 1)}"); 
            Console.ReadKey();



        }

        static void readNumbers()
        {
            int userInput = -1;

            // List<int> numbers = new List<int>();//in a list i dont need to send the array length first because dynamcic
            
            while (userInput != 0)
            {
                Console.WriteLine("Ingrese un numero:");
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    numbers.Add(userInput);
                }
                Console.Clear();
            }
        }

        static float sumNumbers() {
          //This is just to practice methods lol
            return numbers.Sum();
        }
    }
}
