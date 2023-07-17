using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLDiaHorario
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLDiaHorario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        public List<EntidadDiaHorario> llamarListarHorarioDia(string condicion = "",string dia = "")
        {
            List<EntidadDiaHorario> diaHorario;
            DADiaHorario accesarDiaHorario = new DADiaHorario(_cadenaConexion);
            try
            {
                diaHorario = accesarDiaHorario.ListarHorarioDia(condicion, dia);
            }
            catch (Exception)
            {
                throw;
            }
            return diaHorario;
        }
    }
}
