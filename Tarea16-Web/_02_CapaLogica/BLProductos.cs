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

        //............................................***********
        //***********************************************************************************************
        //metodo para llamarlistar
        public List<EntidadesProductos> llamarListaProductos(string condicion = "")
        {
            List<EntidadesProductos> listaProductos;
            DAProductos accesoDatos = new DAProductos(_cadenaConexion);
            try
            {
                listaProductos = accesoDatos.ListaProductos(condicion);
            }
            catch (Exception)
            {
                throw;
            }

            return listaProductos;
        }

        //llamar a obterner

        public EntidadesProductos ObtenerProducto(int id)
        {
            EntidadesProductos producto;
            DAProductos accesoDatos = new DAProductos(_cadenaConexion);
            try
            {
                producto = accesoDatos.ObtenerProducto(id);
            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }

        //llamar a eliminar logica
        //***********************************************************************************************************
        public int EliminarConSP(EntidadesProductos productos)
        {
            int resultado;
            DAProductos accesoDatos = new DAProductos(_cadenaConexion);

            try
            {
                //se puede verificar antes de elimiar
                resultado = accesoDatos.EliminarRegistroConSP(productos);
                string mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }

        //llamar elimimar logica sin procedimiento almacenado
        //public int EliminarCliente(EntidadesProductos producto)
        //{
        //    int resultado;
        //    DAProductos accesoDatos = new DAProductos(_cadenaConexion);

        //    try
        //    {
        //        resultado = accesoDatos.EliminarProduto(producto);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    return resultado;
        //}

        //LLamar modicficar productos
        public int Modificar(EntidadesProductos producto)
        {
            int filasAfectadas = 0;
            DAProductos accesoDatos = new DAProductos(_cadenaConexion);

            try
            {
                filasAfectadas = accesoDatos.ModificarCliente(producto);
            }
            catch (Exception)
            {
                throw;
            }

            return filasAfectadas;
        }

        public int EliminarsinSP(EntidadesProductos producto)
        {
            int resultado;
            DAProductos accesoDatos = new DAProductos(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarProducto(producto);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }//eliminarconsp fin

    }
}
