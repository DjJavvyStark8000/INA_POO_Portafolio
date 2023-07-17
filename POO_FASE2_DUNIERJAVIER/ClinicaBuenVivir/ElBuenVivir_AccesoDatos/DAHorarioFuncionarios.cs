using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DAHorarioFuncionarios
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAHorarioFuncionarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) Acceso a datos mediante una Lista
        public List<EntidadHorarioFuncionarios> ListarHorarioFuncionarios(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadHorarioFuncionarios> horario;

            string instruccionDB = "SELECT HORARIO_ID, LUNES, MARTES, MIERCOLES, " +
                "JUEVES, VIERNES, SABADO, DOMINGO FROM HORARIOFUNCIONARIOS";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "HORARIOFUNCIONARIOS");
                horario = (from DataRow row in elDataSet.Tables["HORARIOFUNCIONARIOS"].Rows
                           select new EntidadHorarioFuncionarios()
                           {
                               HorarioId = Convert.ToInt32(row[0]),
                               Lunes = row[1].ToString(),
                               Martes = row[2].ToString(),
                               Miercoles = row[3].ToString(),
                               Jueves = row[4].ToString(),
                               Viernes = row[5].ToString(),
                               Sabado = row[6].ToString(),
                               Domingo = row[7].ToString()
                           }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return horario;
        }

        // (2) Insertar horario de un funicionario a la base de datos
        public int InsertarHorarioFuncionarios(EntidadHorarioFuncionarios horario)
        {
            Console.Beep();
            int id = 0;
            // Establecer el objeto de conexión
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            // Establecer el comando SQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO HORARIOFUNCIONARIOS (LUNES, MARTES, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO) " +
                "VALUES (@LUNES, @MARTES, @MIERCOLES, @JUEVES, @VIERNES, @SABADO, @DOMINGO); SELECT SCOPE_IDENTITY()";

            comando.Parameters.AddWithValue("@LUNES", horario.Lunes);
            comando.Parameters.AddWithValue("@MARTES", horario.Martes);
            comando.Parameters.AddWithValue("@MIERCOLES", horario.Miercoles);
            comando.Parameters.AddWithValue("@JUEVES", horario.Jueves);
            comando.Parameters.AddWithValue("@VIERNES", horario.Viernes);
            comando.Parameters.AddWithValue("@SABADO", horario.Sabado);
            comando.Parameters.AddWithValue("@DOMINGO", horario.Domingo);
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

        // (3) Editar un horario de funcionario en la base de datos
        public int EditarHorarioFuncionario(EntidadHorarioFuncionarios horario)
        {
            int filasAfectadas = 0;
            // Establecer el objeto de conexión
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            // Establecer el comando SQL
            SqlCommand comando = new SqlCommand();

            string ruta = "UPDATE HORARIOFUNCIONARIOS SET LUNES = @LUNES, MARTES = @MARTES, MIERCOLES = @MIERCOLES, JUEVES = @JUEVES, VIERNES = @VIERNES, SABADO = @SABADO, DOMINGO = @DOMINGO " +
                "WHERE HORARIO_ID = @HORARIO_ID";

            comando.Parameters.AddWithValue("@HORARIO_ID", horario.HorarioId);
            comando.Parameters.AddWithValue("@LUNES", horario.Lunes);
            comando.Parameters.AddWithValue("@MARTES", horario.Martes);
            comando.Parameters.AddWithValue("@MIERCOLES", horario.Miercoles);
            comando.Parameters.AddWithValue("@JUEVES", horario.Jueves);
            comando.Parameters.AddWithValue("@VIERNES", horario.Viernes);
            comando.Parameters.AddWithValue("@SABADO", horario.Sabado);
            comando.Parameters.AddWithValue("@DOMINGO", horario.Domingo);
            comando.CommandText = ruta;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                filasAfectadas = Convert.ToInt32(comando.ExecuteNonQuery());
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
            }
            return filasAfectadas;
        }

        // (4) Eliminar un horario de funcionario de la base de datos
        public int EliminarHorarioFuncionario(int horarioId)
        {
            int id = 0;
            // Establecer el objeto de conexión
            using (SqlConnection cnx = new SqlConnection(_cadenaConexion))
            {
                // Establecer el comando SQL
                SqlCommand comando = new SqlCommand();
                comando.Connection = cnx;
                string ruta = "DELETE FROM HORARIOFUNCIONARIOS WHERE HORARIO_ID = @HORARIO_ID";

                comando.Parameters.AddWithValue("@HORARIO_ID", horarioId);
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
                return id;
            }
        }

    }
}
