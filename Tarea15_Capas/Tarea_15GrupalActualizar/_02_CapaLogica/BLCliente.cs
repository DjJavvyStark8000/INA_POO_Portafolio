using System;
using System.Collections.Generic;
using System.Text;
using _03_CapaBaseDatos;
using Entidades;

namespace _02_CapaLogica
{
    public class BLCliente
    {
        //atributos
        private string _cadenaConexion;
        private string _mensaje;

        //propiedades
        public string Mensaje
        {
            get => _mensaje;
        }

        // constructor
        public BLCliente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        //........................................................................................
        //metodo para llamar al metodo insertar de la capa3accesodatos
        public int LlamarMetodoInsertar(EntidadClientes cliente)
        {
            int id_cliente = 0;
            DAClientes accesoDatos = new DAClientes(_cadenaConexion);
            try
            {
                id_cliente = accesoDatos.InsertarCliente(cliente);
            }
            catch (Exception)
            {
                throw;
            }
            return id_cliente;
        }// fin de la clase insertar

        //.........................................................................................
        //metodo para llamarlistar
        public List<EntidadClientes> llamarListaClientes(string condicion = "")
        {
            List<EntidadClientes> listaClientes;
            DAClientes accesoDatos = new DAClientes(_cadenaConexion);
            try
            {
                listaClientes = accesoDatos.ListaClientes(condicion);
            }
            catch (Exception)
            {
                throw;
            }

            return listaClientes;
        }

        //llamar a obterner

        public EntidadClientes ObtenerCliente(int id)
        {
            EntidadClientes cliente;
            DAClientes accesoDatos = new DAClientes(_cadenaConexion);
            try
            {
                cliente = accesoDatos.ObtenerCliente(id);
            }
            catch (Exception)
            {
                throw;
            }
            return cliente;
        }

        //llamar a eliminar logica
        public int EliminarConSP(EntidadClientes cliente)
        {
            int resultado;
            DAClientes accesoDatos = new DAClientes(_cadenaConexion);

            try
            {
                //se puede verificar antes de elimiar

                resultado = accesoDatos.EliminarRegistroConSP(cliente);
                string mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }

            return resultado;
        }

        //LLamar modicficar cliente
        public int Modificar(EntidadClientes cliente)
        {
            int filasAfectadas = 0;
            DAClientes accesoDatos = new DAClientes(_cadenaConexion);

            try
            {
                filasAfectadas = accesoDatos.ModificarCliente(cliente);
            }
            catch (Exception)
            { 
                throw;
            }

            return filasAfectadas;
        }
    }

}
