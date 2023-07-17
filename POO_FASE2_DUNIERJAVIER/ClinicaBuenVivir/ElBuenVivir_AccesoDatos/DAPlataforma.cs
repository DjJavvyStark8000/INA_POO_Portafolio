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
                "ID_CITAS, ID_FUNCIONARIO, HORA_ENTRADA, HORA_SALIDA, MOTIVO FROM PLATAFORMA";

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
                              HoraEntrada= row[4].ToString(),
                              HoraSalida = row[5].ToString(),
                              Motivo = row[6].ToString(),
                          }).ToList();

            }
            catch (Exception)
            {
                throw;

            }
            return plataforma;
        }

        // (2) Insertar datos de plataforma
        public int InsertarDatosPlataforma(EntidadPlataforma datosPlataforma)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO PLATAFORMA (PACIENTE_ID, CITAS_ID, FUNCIONARIO_ID, HORA_ENTRADA, MOTIVO) " +
                "VALUES (@PACIENTE_ID, @CITAS_ID, @FUNCIONARIO_ID, @HORA_ENTRADA, @MOTIVO); SELECT SCOPE_IDENTITY()";

            comando.Parameters.AddWithValue("@PACIENTE_ID", datosPlataforma.IdPaciente);
            comando.Parameters.AddWithValue("@CITAS_ID", datosPlataforma.IdCitas);
            comando.Parameters.AddWithValue("@FUNCIONARIO_ID", datosPlataforma.IdFuncionario);
            comando.Parameters.AddWithValue("@HORA_ENTRADA", datosPlataforma.HoraEntrada);
            comando.Parameters.AddWithValue("@MOTIVO", datosPlataforma.Motivo);

            comando.CommandText = ruta;
            try
            {
                cnx.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                cnx.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cnx.Dispose();
                comando.Dispose();
            }
            return id;
        }
    }
}
