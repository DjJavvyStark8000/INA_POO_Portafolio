using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3Construya un programa que permita ingresar 10 notas entre 1 y 100,
            //indicando finalmente cuántos alumnos aprobaron (>=70) y cuantos reprobaron (<70).

            int userInput = 0;
            int passed = 0;
            int failed = 0;
            int counter = 1;

            while (counter <= 10)
            {
                Console.WriteLine($"Ingrese la nota {counter}");
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    if (userInput > 0 && userInput < 101)
                    {
                        if (userInput >= 70)
                        {
                            passed++;
                            counter++;
                        }
                        else
                        {
                            failed++;
                            counter++;
                        }
                    }
                }
                Console.Clear();
            }



            Console.WriteLine($"Cantidad Aprovados: {passed}\nCantidad Reprobados: {failed}");
            Console.ReadKey();
        }
    }
}

