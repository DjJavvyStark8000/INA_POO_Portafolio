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
    }
}
