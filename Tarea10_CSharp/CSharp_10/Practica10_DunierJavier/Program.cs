using Practica10_DunierJavier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10_DunierJavier
{
    internal class Program
    {

        static void Main(string[] args)
        {

            TourVacaciones miTour = new TourVacaciones();//intance of a class
            TourVacaciones[] onTour = miTour.DatosTour(2);// call method to build array and return it


            miTour.PrintDatosTour(onTour);//from returned call print and send array

            TourVacaciones.MostrarCantidadObjetos();


            Console.ReadKey();



        }

    }


}
