using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace _03_CapaBaseDatos
{
    internal class DAClientes
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAClientes(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
    }
}
