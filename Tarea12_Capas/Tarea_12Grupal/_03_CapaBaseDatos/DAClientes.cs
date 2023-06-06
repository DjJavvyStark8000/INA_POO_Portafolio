using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace _03_CapaBaseDatos
{
    internal class DAClientes
    {
        private int id_Cliente;
        private string nombre;
        private string telefono;
        private string direccion;

        //constructores
        public DAClientes()
        {
            id_Cliente = 0;
            nombre = "";
            telefono = "";
            direccion = "";
        }
        public DAClientes(int id_Cliente, string nombre, string telefono, string direccion)
        {
            this.id_Cliente = id_Cliente;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public int Cliente { get { return id_Cliente; } set { id_Cliente = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
    }
}
