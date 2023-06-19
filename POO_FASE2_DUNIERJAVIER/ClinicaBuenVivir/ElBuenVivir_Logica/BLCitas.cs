using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLCitas
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLCitas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        public List<EntidadCitas> llamarListarCitas(string condicion = "")
        {
            List<EntidadCitas> cita;
            DACitas accesarCitas = new DACitas(_cadenaConexion);
            try
            {
                cita = accesarCitas.ListarCitas(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return cita;
        }
        // (2) metodo para llamar al metodo insertar Horario
        public int LlamarInsertarHorario(EntidadHorario horario)
        {
            int id_especial = 0;
            DACitas unHorario = new DACitas(_cadenaConexion);
            try
            {
                id_especial = unHorario.InsertarHorario(horario);
            }
            catch (Exception)
            {
                throw;
            }
            return id_especial;
        }// fin de la clase insertar
    }
}
