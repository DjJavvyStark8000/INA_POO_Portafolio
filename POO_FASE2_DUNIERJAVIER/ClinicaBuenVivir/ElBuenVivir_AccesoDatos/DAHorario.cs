using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DAHorario
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAHorario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) Acceso a datos mediante una Lista
        public List<EntidadHorario> ListarHorario(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadHorario> horario;

            string instruccionDB = "SELECT HORARIO_ID, FECHA, HORA_INICIO, HORA_FIN, MEDICO_ID\n" +
                " FROM HORARIO";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "HORARIO");
                horario = (from DataRow row in elDataSet.Tables["HORARIO"].Rows
                          select new EntidadHorario()
                          {
                              HorarioId = Convert.ToInt32(row[0]),
                              FechaHorario = row[1].ToString(),
                              HoraInicio = row[2].ToString(),
                              HoraFin = row[3].ToString(),
                              MedicoId = Convert.ToInt32(row[4])
                          }).ToList(); 
            }
            catch (Exception)
            {
                throw;

            }
            return horario;
        }

        // (2) Insertar datos del hoarario y recibir el id a la base de datos
        public int InsertarHorario(EntidadHorario horario)
        {
            int id = 0;
            // Establecer el objeto conexión
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            // Establecer el comando SQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO HORARIO (FECHA, HORA_INICIO, HORA_FIN, MEDICO_ID) " +
                          "VALUES (@FECHA, @HORA_INICIO, @HORA_FIN, @MEDICO_ID); SELECT SCOPE_IDENTITY()";

            comando.Parameters.AddWithValue("@FECHA", horario.FechaHorario);
            comando.Parameters.AddWithValue("@HORA_INICIO", horario.HoraInicio);
            comando.Parameters.AddWithValue("@HORA_FIN", horario.HoraFin);
            comando.Parameters.AddWithValue("@MEDICO_ID", horario.MedicoId);
            comando.CommandText = ruta;

            try
            {
                cnx.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cnx.Close();
                cnx.Dispose();
                comando.Dispose();
            }

            return id;
        }
    }
}
