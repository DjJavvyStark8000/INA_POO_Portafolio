using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salario Base:");
            double baseSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Ventas mensuales:");
            double monthlySales = double.Parse(Console.ReadLine());

            double commission = monthlySales * 0.1; // 10% commission on sales
            double grossSalary = baseSalary + commission;

            Console.WriteLine("El salario bruto es: " + grossSalary);
            Console.ReadKey();
        }
    }
}
