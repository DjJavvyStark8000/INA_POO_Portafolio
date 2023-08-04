using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ElBuenVivir_Entidades;

namespace ElBuenVivir_AccesoDatos
{
    public class DABuscarPaciente
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DABuscarPaciente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        public DataSet ListarPacientes(string condicion = "", string orden = "")
        {
            DataSet data = new DataSet(); // To store the select query results
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;

            string instruccionDB = "SELECT PACIENTE_ID, NOMBRE_PACIENTE, APELLIDOS, FECHA_NACIMIENTO, TELEFONO, ASEGURADO FROM PACIENTES";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            if (!string.IsNullOrEmpty(orden))
            {
                instruccionDB = string.Format("{0} ORDER BY {1}", instruccionDB, orden);
            }

            try
            {
                adapter = new SqlDataAdapter(instruccionDB, conexion);
                adapter.Fill(data, "PACIENTES");
            }
            catch (Exception)
            {
                throw;
            }

            return data; // The dataSet is returned here
        }


    }
}
