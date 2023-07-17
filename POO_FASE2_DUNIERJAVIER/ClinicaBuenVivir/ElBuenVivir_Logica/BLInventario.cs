using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLInventario
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLInventario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        public List<EntidadInventario> llamarListarInventario(string condicion = "")
        {
            List<EntidadInventario> inventario;
            DAInventario accesarInventario = new DAInventario(_cadenaConexion);
            try
            {
                inventario = accesarInventario.ListarInventario(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return inventario;
        }

        // (2) metodo para llamar al metodo insertar MEDICAMENTOS  
        public int LlamarInsertarInventario(EntidadInventario inventario)
        {
            int id_inventario = 0;
            DAInventario unInventario = new DAInventario(_cadenaConexion);
            try
            {
                id_inventario = unInventario.InsertarInventario(inventario);
            }
            catch (Exception)
            {
                throw;
            }
            return id_inventario;
        }// fin de la clase insertar

        // (3) metodo para llamar al metodo editar el invetario 
        public int LlamarEditarInventario(EntidadInventario inventario)
        {
            int filasAfectadas = 0;
            DAInventario unInventario = new DAInventario(_cadenaConexion);
            try
            {
                filasAfectadas = unInventario.EditarInventario(inventario);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }

        // (4) metodo para llamar al metodo eliminar medicamentos
        public int LlamarEliminarInventario(int inventario)
        {
            int id_inventario = 0;
            DAInventario unInventario = new DAInventario(_cadenaConexion);
            try
            {
                id_inventario = unInventario.EliminarInventario(inventario);
            }
            catch (Exception)
            {
                throw;
            }
            return id_inventario;
        }


    }
}
