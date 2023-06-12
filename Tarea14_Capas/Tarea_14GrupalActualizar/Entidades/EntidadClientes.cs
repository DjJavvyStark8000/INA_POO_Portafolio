using System;

namespace Entidades
{
    public class EntidadClientes
    {
        private int id_Cliente;
        private string nombre;
        private string telefono;
        private string direccion;

        //constructores
        public EntidadClientes()
        {
            id_Cliente = 0;
            nombre = "";
            telefono = "";
            direccion = "";
        }
        public EntidadClientes(int id_Cliente, string nombre, string telefono, string direccion)
        {
            this.id_Cliente = id_Cliente;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        //set y get
        public int Id_Cliente { get { return id_Cliente; } set { id_Cliente = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }

    }

}
