using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
   public class BLMisCitas
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLMisCitas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        public List<EntidadMisCitas> llamarListarMisCitas(string condicion = "")
        {
            List<EntidadMisCitas> miCita;
            DAMisCitas accesarMisCitas = new DAMisCitas(_cadenaConexion);
            try
            {
                miCita = accesarMisCitas.ListarMisCitas(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return miCita;
        }
    }
}
