using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10_DunierJavier
{
    internal class TourVacaciones
    {
        private static int count = 0;

        private int idTour;
        private string? destino;
        private decimal precio;
        private DateTime fechaSalida;
        private DateTime fechaRegreso;
        private string? descripcion;

        //Constructor sin parámetros -- atributos a sus valores por defecto
        public TourVacaciones()
        {
            idTour = 0;
            destino = string.Empty;
            precio = 0;
            fechaSalida = DateTime.MinValue;
            fechaRegreso = DateTime.MinValue;
            descripcion = string.Empty;

            count++;
        }

        //Constructor de todos los atributos
        public TourVacaciones(int idTour, string destino, decimal precio, DateTime fechaSalida, DateTime fechaRegreso, string descripcion)
        {
            this.idTour = idTour;
            this.destino = destino;
            this.precio = precio;
            this.fechaSalida = fechaSalida;
            this.fechaRegreso = fechaRegreso;
            this.descripcion = descripcion;

            count++;
        }

        //getters y setters simples
        public int IdTour 
        { 
            get { return idTour; }
            set { idTour = value; }  
        }
        public string? Destino 
        { 
            get { return destino; }
            set { destino = value; }
        }
        public decimal Precio
        {
            get => precio;
            set
            {
                if (value > 0)
                    precio = value;
            }
        }
        public DateTime FechaSalida 
        { 
            get { return  fechaSalida; }
            set { fechaSalida  = value; }
        
        }
        public DateTime FechaRegreso 
        { 
            get { return fechaRegreso; }
            set { fechaRegreso = value; }
        
        }
        public string? Descripcion 
        { 
           get { return descripcion; }
            set { descripcion = value; }
        }

        //8.	Cree un método que retorne un arreglo de objetos
        //TourVacaciones, el trabajo que hará el método será pedirle
        //al usuario los datos de 5 tours, crear un arreglo de objetos,
        //ir guardando los datos que escriba el usuario de cada Tour en un
        //objeto y almacenar en cada posición cada objeto. Finalmente retornar
        //el arreglo con los 5 objetos. Debe utilizar los métodos de acceso creados.



        public TourVacaciones[] DatosTour(int cantidad)
        {
            TourVacaciones[] datosTour = new TourVacaciones[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Ingrese los datos del Tour #{i + 1}:");

                // Solicitar al usuario los datos para cada atributo del tour
                Console.Write("IdTour: ");
                int idTour = int.Parse(Console.ReadLine());

                Console.Write("Destino: ");
                string? destino = Console.ReadLine();

                Console.Write("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Console.Write("Fecha de Salida (yyyy-MM-dd): ");
                DateTime fechaSalida = DateTime.Parse(Console.ReadLine());

                Console.Write("Fecha de Regreso (yyyy-MM-dd): ");
                DateTime fechaRegreso = DateTime.Parse(Console.ReadLine());

                Console.Write("Descripción: ");
                string? descripcion = Console.ReadLine();

                // Crear un nuevo objeto TourVacaciones con los datos ingresados por el usuario
                TourVacaciones tour = new TourVacaciones(idTour, destino, precio, fechaSalida, fechaRegreso, descripcion);

                // Almacenar el objeto tour en el arreglo de tours
                datosTour[i] = tour;         

            }

            return datosTour;
        }

        //1.	Cree un método que reciba un arreglo de objetos
        //tipo TourVacaciones y muestre en pantalla los datos de
        //cada objeto, trate de utilizar tabulaciones u otros elementos
        //para dar una apariencia ordenada y agradable. Debe utilizar los
        //métodos de acceso creados.

        public void PrintDatosTour(TourVacaciones[] tours)
        {
            for (int i = 0; i < tours.Length; i++)
            {
                Console.WriteLine($"Tour #{i + 1}:");
                Console.WriteLine($"IdTour: {tours[i].IdTour}");
                Console.WriteLine($"Destino: {tours[i].Destino}");
                Console.WriteLine($"Precio: {tours[i].Precio}");
                Console.WriteLine($"Fecha de Salida: {tours[i].FechaSalida.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Fecha de Regreso: {tours[i].FechaRegreso.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Descripción: {tours[i].Descripcion}");
                Console.WriteLine("-------------------------------------------------\n\n");
            }
        }

        public static void MostrarCantidadObjetos()
        {
            Console.WriteLine($"\n\n\nLa cantidad de objetos TourVacaciones creados es: {count}");
        }
    }




}