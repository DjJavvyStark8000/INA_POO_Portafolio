using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica07_DunierJavier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pies de frete:");
            double frontFeet = double.Parse(Console.ReadLine());

            Console.WriteLine("Pies de fondo:");
            double backFeet = double.Parse(Console.ReadLine());
            //call convertion methods
            double frenteMetros = ConvertToMeters(frontFeet);
            double fondoMetros = ConvertToMeters(backFeet);

            double areaMeters = AreaCalc(frenteMetros, fondoMetros);

            Console.WriteLine("El área del terreno es: " + areaMeters + " m^2");
            Console.ReadKey();
        }
        static double ConvertToMeters(double feet)
        {
            double meters = feet * 0.3048;
            return meters;
        }

        static double AreaCalc(double front, double back)
        {
            double area = front * back;
            return area;
        }
    }
}
