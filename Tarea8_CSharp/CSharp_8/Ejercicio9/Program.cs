using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //9.Leer una cantidad de números variables hasta que se ingrese
            //un número múltiplo de 5. Indicar el número de datos que fueron
            //ingresados, sin contar el múltiplo de la condición de término.


            int count = 0;
            int number;

            Console.WriteLine("Ingrese un numero:");

            do
            {
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out number))
                {
                    if (number % 5 == 0)
                        break;

                    count++;//exclude the last
                }
               
            } while (true);

            Console.WriteLine("Numero de datos ingresado exclu): " + count);
        }
    }
}
