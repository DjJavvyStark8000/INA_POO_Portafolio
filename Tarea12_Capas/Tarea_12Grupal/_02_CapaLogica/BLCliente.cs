using System;
using System.Collections.Generic;
using System.Text;
using _03_CapaBaseDatos;
using Entidades;

namespace _02_CapaLogica
{
    internal class BLCliente
    {
        private int id_Cliente;
        private string nombre;
        private string telefono;
        private string direccion;

        //constructores
        public BLCliente()
        {
            id_Cliente = 0;
            nombre = "";
            telefono = "";
            direccion = "";
        }
        public BLCliente(int id_Cliente, string nombre, string telefono, string direccion)
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
