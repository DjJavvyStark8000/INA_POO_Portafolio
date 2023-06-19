using ElBuenVivir_AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLBuscarPaciente
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLBuscarPaciente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public DataSet llamarListarPacientes(string condicion = "", string orden = "")
        {
            DataSet elDataSet;
            DABuscarPaciente accesarData = new DABuscarPaciente(_cadenaConexion);
            try
            {
                elDataSet = accesarData.ListarPacientes(condicion, orden);
            }
            catch (Exception)
            {
                throw;
            }
            return elDataSet;
        }
    }
}
