using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio9_DunierJavier
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //instanciar 2 objetos por clase
            Libro unLibro = new Libro();
            Libro dosLibro = new Libro("Aliens", "XYZ");
            Cliente unCliente = new Cliente();
            Cliente dosCliente = new Cliente("Javier", "Bolaños");

            //1.Utilizar con cada objeto todos los métodos getter,
            //setter y métodos de funcionalidad que creó.
            //Libro
            unLibro.Categoria = "Ciencia";//prueba de que puedo cambiar los datos aqui
            unLibro.AnioPublicacion = 2023;
            unLibro.setPrice(20000);//llamamos el metodo de cambiar precio
            Console.WriteLine($"El autor {unLibro.Autor} que creo el libro {dosLibro.Titulo}\n" +
                $"que pertenece la la categoria {unLibro.Categoria} lo estara promoviendo en\n" +
                $"el editorial {dosLibro.Editorial} en el anio {unLibro.AnioPublicacion}, este\n" +
                $"tiene un costo de {unLibro.Precio}");
            //cambiar titulo editorial
            unLibro.setEditorial("Aliens2", "ABC");
            Console.WriteLine($"\nEl autor a anunciado que para el anio {unLibro.AnioPublicacion + 1}\n" +
                $"estara publicando {unLibro.Titulo} en el\n" +
                $"editorial {unLibro.Editorial}");

            Console.WriteLine("\n\n-------------------------------------------------------\n\n");
            unCliente.setTelefono(55555555);//cambiar telefono
            //chequer si el telefono es valido rando de 22222222 a 99999999 es valido
            if (unCliente.checkPhone(unCliente.Telefono))
                Console.WriteLine("El numero de telefono SI es valido");
            else
                Console.WriteLine("El numero de telefono NO es valido");
            Console.ReadKey();

        }

    }
}
