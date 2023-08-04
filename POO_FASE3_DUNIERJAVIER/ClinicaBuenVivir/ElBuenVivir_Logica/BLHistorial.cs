using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLHistorial
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLHistorial(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        public List<EntidadHistorial> llamarListarHistorial(string condicion = "")
        {
            List<EntidadHistorial> historial;
            DAHistorial accesarHistorial = new DAHistorial(_cadenaConexion);
            try
            {
                historial = accesarHistorial.ListarHistorial(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return historial;
        }

        // (2a) metodo para llamar al metodo insertar MEDICAMENTOS  
        public int LlamarInsertarHistorial(EntidadHistorial historial)
        {
            int id_historial = 0;
            DAHistorial unHistorial = new DAHistorial(_cadenaConexion);
            try
            {
                id_historial = unHistorial.InsertarHistorial(historial);
            }
            catch (Exception)
            {
                throw;
            }
            return id_historial;
        }// fin de la clase insertar

        // (2b) metodo para llamar al metodo insertar MEDICAMENTOS  
        public int LlamarInsertarHistorialVacio()
        {
            int id_historial = 0;
            DAHistorial unHistorial = new DAHistorial(_cadenaConexion);
            try
            {
                id_historial = unHistorial.InsertarHistorialVacio();
            }
            catch (Exception)
            {
                throw;
            }
            return id_historial;
        }// fin de la clase insertar

        // (3) metodo para llamar al metodo editar el invetario 
        public int LlamarEditarHistorial(EntidadHistorial historial)
        {
            int filasAfectadas = 0;
            DAHistorial unHistorial = new DAHistorial(_cadenaConexion);
            try
            {
                filasAfectadas = unHistorial.EditarHistorial(historial);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }
    }
}
