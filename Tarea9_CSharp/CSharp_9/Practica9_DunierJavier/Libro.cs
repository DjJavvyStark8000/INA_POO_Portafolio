using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio9_DunierJavier
{
    internal class Libro
    {
        private string? titulo;
        private string? autor;
        private int? anioPublicacion;
        private string? editorial;
        private string? categoria;
        private double? precio;

        //constructor
        public Libro()
        {
            titulo = string.Empty;
            autor = string.Empty;
            anioPublicacion = 0;
            editorial = string.Empty;
            categoria = string.Empty;
            precio = 0;
        }

        //aqui puede hacer un constructor con parametros (SOBRECARGAS)
        public Libro(string titulo, string editorial)
        {
            this.titulo = titulo;
            this.editorial = editorial;
        }

        public Libro(double precio)
        {
            this.precio = precio;
        }
        //setter y getters
        public string? Titulo
        {
            get => titulo;
            set { titulo = value; }
        }

        public string? Autor
        {
            get => autor;
            set { autor = value; }
        }

        public int? AnioPublicacion
        {
            get => anioPublicacion;
            set { anioPublicacion = value; }
        }

        public string? Editorial
        {
            get => editorial;
            set { editorial = value; }
        }

        public string? Categoria
        {
            get => categoria;
            set { categoria = value; }
        }
        public double? Precio
        {
            get => precio;
            set { precio = value; }
        }

        //metodos get
        public string getAutorLibro()
        {
            string result = $"Autor: {autor}\nLibro: {titulo}";
            return result;
        }

        public string getBookPrice()
        {
            string result = $"Titulo: {titulo}\nPrecio: {precio}";
            return result;
        }

        //metodos set
        public void setPrice(double precio)
        {
            this.precio = precio;
        }

        public void setEditorial(string titulo, string editorial)
        {
            this.titulo = titulo;
            this.editorial = editorial;
        }


        //metodos con funcionalidad y sobrecargas
        public void printInfo()
        {
            Console.WriteLine(
                "Datos generales del libro:\n" +
                $"Titulo: {titulo}\n" +
                $"Autor: {autor}\n" +
                $"Anio: {anioPublicacion}\n" +
                $"Editorial: {editorial}\n" +
                $"Categoria: {categoria}\n" +
                $"Precio: {precio}");
        }

        public void printInfo(int anioPublicacion)
        {
            if (anioPublicacion > DateTime.Now.Year)
            {
                Console.WriteLine("Anio fuera de rango");
            }
            else if (anioPublicacion <= DateTime.Now.Year && anioPublicacion > 2000)
            {
                Console.WriteLine("Existe una gran variedad de libros relativamente modernos");
            }
            else
            {
                Console.WriteLine("Existe una gran variedad de libros antiguos a la disposicion :)");
            }
        }

        public double printInfo(string nombre, int precio)
        {
            double descuento = 0.0;
            DateTime fechaActual = DateTime.Now;
            int esteMes = fechaActual.Month;

            if (esteMes == 4 || esteMes == 8)
            {
                descuento = precio * 0.5;
            }

            double precioFinal = precio - descuento;

            return precioFinal;
        }
    }
}