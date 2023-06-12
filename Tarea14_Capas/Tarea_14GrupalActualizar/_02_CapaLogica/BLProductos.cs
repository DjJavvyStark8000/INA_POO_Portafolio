using System;
using System.Collections.Generic;
using System.Text;
using _03_CapaBaseDatos;
using Entidades;

namespace _02_CapaLogica
{
    public class BLProductos
    {//atributos
        private string _cadenaConexion;
        private string _mensaje;

        //propiedades
        public string Mensaje
        {
            get => _mensaje;
        }

        // constructor
        public BLProductos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //metodo para llamar al metodo insertar de la capa3accesodatos
        public int LlamarMetodoInsertar(EntidadesProductos producto)
        {
            int id_producto = 0;
            DAProductos accesoDatos = new DAProductos(_cadenaConexion);
            try
            {
                id_producto = accesoDatos.InsertarProducto(producto);
            }
            catch (Exception)
            {
                throw;
            }
            return id_producto;
        }// fin de la clase insertar
    }
}
