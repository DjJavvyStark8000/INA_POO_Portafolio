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

            string instruccionDB = "SELECT HISTORIAL_ID, PACIENTE_ID, FECHA_REGISTRO, ANTECEDENTES, MEDICAMENTOS, " +
                "DIAGNOSTICOS, RESULTADO_PRUEBAS, OBSERVACIONES FROM HISTORIAL";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "HISTORIAL");
                historial = (from DataRow row in elDataSet.Tables["HISTORIAL"].Rows
                             select new EntidadHistorial()
                             {
                                 HistorialId = Convert.ToInt32(row[0]),
                                 PacienteId = Convert.ToInt32(row[1]),
                                 FechaRegistro = row[2].ToString(),
                                 Antecedentes = row[3].ToString(),
                                 Medicamentos = row[4].ToString(),
                                 Diagnosticos = row[5].ToString(),
                                 ResultadoPruebas = row[6].ToString(),
                                 Observaciones = row[7].ToString(),
                             }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return historial;
        }

        public int InsertarHistorial(EntidadHistorial historial)
        {
            int id = 0;
            // Establecer el objeto conexión
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            // Establecer los comandos SQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO HISTORIAL (PACIENTE_ID, FECHA_REGISTRO, ANTECEDENTES, MEDICAMENTOS, DIAGNOSTICOS, RESULTADO_PRUEBAS, OBSERVACIONES) " +
                "VALUES (@PACIENTE_ID, @FECHA_REGISTRO, @ANTECEDENTES, @MEDICAMENTOS, @DIAGNOSTICOS, @RESULTADO_PRUEBAS, @OBSERVACIONES); SELECT SCOPE_IDENTITY()";

            // Add the missing command parameters
            comando.Parameters.AddWithValue("@PACIENTE_ID", historial.PacienteId);
            comando.Parameters.AddWithValue("@FECHA_REGISTRO", historial.FechaRegistro);
            comando.Parameters.AddWithValue("@ANTECEDENTES", historial.Antecedentes);
            comando.Parameters.AddWithValue("@MEDICAMENTOS", historial.Medicamentos);
            comando.Parameters.AddWithValue("@DIAGNOSTICOS", historial.Diagnosticos);
            comando.Parameters.AddWithValue("@RESULTADO_PRUEBAS", historial.ResultadoPruebas);
            comando.Parameters.AddWithValue("@OBSERVACIONES", historial.Observaciones);

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

        public int InsertarHistorialVacio()
        {
            Console.Beep();
            int id = 0;
            // Establecer el objeto conexión
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            // Establecer los comandos SQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO HISTORIAL DEFAULT VALUES; SELECT SCOPE_IDENTITY()";

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

        // (3) Editar un medicamento en la base de datos
        public int EditarHistorial(EntidadHistorial historial)
        {
            int filasAfectadas = 0;
            // Establecer el objeto de conexión
            SqlConnection conexion = new SqlConnection(_cadenaConexion);


            // Establecer el comando SQL
            SqlCommand comando = new SqlCommand();

            string ruta = "UPDATE HISTORIAL SET FECHA_REGISTRO = @FECHA_REGISTRO, ANTECEDENTES = @ANTECEDENTES, MEDICAMENTOS = @MEDICAMENTOS, " +
                "DIAGNOSTICOS = @DIAGNOSTICOS, RESULTADO_PRUEBAS = @RESULTADO_PRUEBAS, OBSERVACIONES = @OBSERVACIONES WHERE HISTORIAL_ID = " +
                   "(SELECT HISTORIAL_ID FROM HISTORIAL WHERE HISTORIAL_ID = @HISTORIAL_ID)";

            comando.Parameters.AddWithValue("@HISTORIAL_ID", historial.HistorialId);
            comando.Parameters.AddWithValue("@FECHA_REGISTRO", historial.FechaRegistro);
            comando.Parameters.AddWithValue("@ANTECEDENTES", historial.Antecedentes);
            comando.Parameters.AddWithValue("@MEDICAMENTOS", historial.Medicamentos);
            comando.Parameters.AddWithValue("@DIAGNOSTICOS", historial.Diagnosticos);
            comando.Parameters.AddWithValue("@RESULTADO_PRUEBAS", historial.ResultadoPruebas);
            comando.Parameters.AddWithValue("@OBSERVACIONES", historial.Observaciones);

            comando.CommandText = ruta;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                filasAfectadas = Convert.ToInt32(comando.ExecuteNonQuery());
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return filasAfectadas;
        }
    }
}
