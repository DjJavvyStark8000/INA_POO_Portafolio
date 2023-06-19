using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLMedicos_Especialidades
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLMedicos_Especialidades(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos 
        public int llamarIdMedicosEspecialidades(int medicoIid = 0)
        {
            int medEspId = 0;
            DAMedicos_Especialidades accesarMed_Esp = new DAMedicos_Especialidades(_cadenaConexion);
            try
            {
                medEspId = accesarMed_Esp.IdMedicosEspecialides(medicoIid);
            }
            catch (Exception)
            {
                throw;
            }
            return medEspId;
        }
    }
}
