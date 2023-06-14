using System;

namespace Entidades
{
    public class EntidadClientes
    {
        private int id_Cliente;
        private string nombre;
        private string telefono;
        private string direccion;
        private bool existe;

        //constructores
        public EntidadClientes()
        {
            id_Cliente = 0;
            nombre = "";
            telefono = "";
            direccion = "";
            existe = false;
        }
        public EntidadClientes(int id_Cliente, string nombre, string telefono, string direccion, bool existe)
        {
            this.id_Cliente = id_Cliente;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.existe = existe;
        }

        //set y get
        public int Id_Cliente { get { return id_Cliente; } set { id_Cliente = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public bool Existe { get { return existe; } set {  existe = value; } }

    }

}
