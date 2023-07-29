using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLHorarios
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLHorarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        //public List<EntidadHorario> llamarListarHorarios(string condicion = "")
        //{
        //    List<EntidadHorario> horario;
        //    DAHorarios accesarHorario = new DAHorarios(_cadenaConexion);
        //    try
        //    {
        //        horario = accesarHorario.ListarHorarios(condicion);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return horario;
        //}
    }
}
