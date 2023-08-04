using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DAHorarios
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAHorarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) Acceso a datos mediante una Lista
        public List<EntidadHorario> ListarHorarios(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadHorario> horario;

            string instruccionDB = "SELECT HORARIO_ID, FECHA,  " +
                "HORA_INICIO, HORA_FIN FROM HORARIO";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                Console.Beep();
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "HORARIO");
                horario = (from DataRow row in elDataSet.Tables["HORARIO"].Rows
                          select new EntidadHorario()
                          {
                              HorarioId = Convert.ToInt32(row[0]),
                              FechaHorario = row[1].ToString(),
                              HoraInicio = row[2].ToString(),
                              HoraFin = row[3].ToString()                           
                          }).ToList(); 

            }
            catch (Exception)
            {
                throw;

            }
            return horario;
        }
    }
}
