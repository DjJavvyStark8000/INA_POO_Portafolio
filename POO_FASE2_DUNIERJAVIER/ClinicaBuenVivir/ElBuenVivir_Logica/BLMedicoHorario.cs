using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLMedicoHorario
    {

        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLMedicoHorario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }


        // (1) llamar medicos horarios
        public List<EntidadMedicoHorario> llamarListarMedicosXHorario(string condicion = "")
        {
            List<EntidadMedicoHorario> medicohorario;
            DAMedicoHorario accesarMedicoHorario = new DAMedicoHorario(_cadenaConexion);
            try
            {
                medicohorario = accesarMedicoHorario.ListarMedicosXHorario(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return medicohorario;
        }
    }
}
