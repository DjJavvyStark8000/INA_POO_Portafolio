using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DAHistorial
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAHistorial(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) Acceso a datos mediante una Lista
        public List<EntidadHistorial> ListarHistorial(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadHistorial> historial;

            string instruccionDB = "SELECT HISTORIAL_CLINICO_ID, FECHA_REGISTRO, ANTECEDENTES, MEDICAMENTOS, " +
                "DIAGNOSTICOS, RESULTADO_PRUEBAS, OBSERVACIONES FROM HISTORIAL";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                Console.Beep();
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "HISTORIAL");
                historial = (from DataRow row in elDataSet.Tables["HISTORIAL"].Rows
                                select new EntidadHistorial()
                                {
                                    HistorialId = Convert.ToInt32(row[0]),
                                    FechaRegistro= Convert.ToDateTime(row[1]),
                                    Antecedentes = row[2].ToString(),
                                    Medicamentos = row[3].ToString(),
                                    Diagnosticos = row[4].ToString(),
                                    ResultadoPruebas = row[5].ToString(),
                                    Observaciones = row[6].ToString(),  
                                }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return historial;
        }
    }
}
