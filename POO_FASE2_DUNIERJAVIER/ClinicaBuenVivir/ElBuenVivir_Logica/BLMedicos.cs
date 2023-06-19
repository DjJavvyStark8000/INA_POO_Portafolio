using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLMedicos
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLMedicos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (***************) llamar acceso de datos por medio de lista a los medicos
        public List<EntidadMedicos> llamarListarMedicos(string condicion = "")
        {
            List<EntidadMedicos> medico;
            DAMedicos accesarMedico = new DAMedicos(_cadenaConexion);
            try
            {
                medico = accesarMedico.ListarMedicos(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return medico;
        }
    }
}
