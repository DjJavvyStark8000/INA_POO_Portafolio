using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.	Leer 10 números e indicar cuánto es la suma de todos ellos.
            int[] numbers = ReadNumbers(10);
            int sum = sumNumbers(numbers);
            Console.WriteLine("La suma de los números es: " + sum);


        }

        static int[] ReadNumbers(int count)//retorna un array
        {
            int userInput = 0;
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Ingrese un número:");
                if (int.TryParse(Console.ReadLine(), out userInput)) { //if this is true
                    numbers[i] = userInput;
                }
                else
                {
                    numbers[i] = 0;//this is just for testing is the user enters a letter is will add a 0 to the array
                }
            }
            return numbers;
        }

        static int sumNumbers(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
