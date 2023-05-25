using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //7.	Leer 10 números e indicar cuánto suman los números pares.
            int[] numbers = readNumbers(10);
            int sum = sumEven(numbers);
            Console.WriteLine("La suma de los números es: " + sum);

        }

        static int[] readNumbers(int count)
        {
            int userInput = 0;
            int[] numbers = new int[count];//instanciar aqui
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    numbers[i] = userInput;
                }
                else
                {
                    numbers[i] = 0;
                }
            }


            return numbers;
        }

        static int sumEven(int[] numbers)
        {
            int sum = 0;
            for (int i = 0;i < numbers.Length;i++)
            {
                if (numbers[i] % 2 == 0)//filter the even numbers
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

    }
}
