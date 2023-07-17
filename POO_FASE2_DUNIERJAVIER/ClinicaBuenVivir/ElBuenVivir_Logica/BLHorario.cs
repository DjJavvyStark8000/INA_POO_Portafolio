using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLHorario
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLHorario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        public List<EntidadHorario> llamarListarHorario(string condicion = "")
        {
            List<EntidadHorario> horario;
            DAHorario accesarHorario = new DAHorario(_cadenaConexion);
            try
            {
                horario = accesarHorario.ListarHorario(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return horario;
        }

        // (2a) metodo para llamar al metodo insertar Horario
        public int LlamarInsertarHorario(EntidadHorario horario)
        {
            int id_especial = 0;
            DAHorario unHorario = new DAHorario(_cadenaConexion);
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
