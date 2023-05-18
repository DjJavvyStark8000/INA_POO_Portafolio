using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_Aguinaldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double totalSalarios = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Ingrese el salario " + (i + 1) + ":");
                salarios[i] = double.Parse(Console.ReadLine());
                totalSalarios += totalSalarios;
            }

            double aguinaldo = totalSalarios / 12;

            Console.WriteLine("El aguinaldo es: " + aguinaldo);
            Console.ReadKey();
        }
    }
}
