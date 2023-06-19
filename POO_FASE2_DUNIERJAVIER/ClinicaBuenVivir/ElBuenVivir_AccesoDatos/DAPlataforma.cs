using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
   public class DAPlataforma
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAPlataforma(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) Acceso a datos mediante una Lista
        public List<EntidadPlataforma> ListarPlataforma(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadPlataforma> plataforma;

            string instruccionDB = "SELECT PLATAFORMA_ID, ID_PACIENTE, " +
                "ID_CITAS, ID_FUNCIONARIO, HORA_ENTRADA, HORA_SALIDA, MOTIVO, CASO FROM PLATAFORMA";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {

                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "PLATAFORMA");
                plataforma = (from DataRow row in elDataSet.Tables["PLATAFORMA"].Rows
                          select new EntidadPlataforma()
                          {
                              PlataformaId = Convert.ToInt32(row[0]),
                              IdPaciente = Convert.ToInt32(row[1]),
                              IdCitas = Convert.ToInt32(row[2]),
                              IdFuncionario = Convert.ToInt32(row[3]),
                              HoraEntrada= TimeSpan.Parse(row[4].ToString()),
                              HoraSalida = TimeSpan.Parse(row[5].ToString()),
                              Motivo = row[6].ToString(),
                              Caso = row[7].ToString()
                          }).ToList();

            }
            catch (Exception)
            {
                throw;

            }
            return plataforma;
        }
    }
}
