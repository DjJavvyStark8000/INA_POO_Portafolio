using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ElBuenVivir_Entidades;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DAEspecialidad
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAEspecialidad(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) Acceso a datos mediante una Lista
        public List<EntidadEspecialidad> ListarEspecialidades(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadEspecialidad> especialidad;

            string instruccionDB = "SELECT ESPECIAL_ID, NOMBRE_ESPECIALIDAD, DESCRIPCION, AREA, COSTO, DISPONIBILIDAD, OBSERVACIONES FROM ESPECIALIDADES";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "ESPECIALIDADES");
                especialidad = (from DataRow row in elDataSet.Tables["ESPECIALIDADES"].Rows
                                select new EntidadEspecialidad()
                                {
                                    ID_Especialidad = (int)row[0],
                                    Nombre_Especialidad = row[1].ToString(),
                                    Descripcion = row[2].ToString(),
                                    Area = row[3].ToString(),
                                    Costo = (decimal)row[4],
                                    Disponibilidad = row[5].ToString(),
                                    Observaciones = row[6].ToString()
                                }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return especialidad;
        }

        // (2) Insertar datos a la base de datos
        public int InsertarEspecialidad(EntidadEspecialidad especialidad)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO ESPECIALIDADES (NOMBRE_ESPECIALIDAD, DESCRIPCION, AREA, COSTO, DISPONIBILIDAD, OBSERVACIONES) " +
                "VALUES (@NOMBRE_ESPECIALIDAD, @DESCRIPCION, @AREA, @COSTO, @DISPONIBILIDAD, @OBSERVACIONES); SELECT SCOPE_IDENTITY()";

            comando.Parameters.AddWithValue("@NOMBRE_ESPECIALIDAD", especialidad.Nombre_Especialidad);
            comando.Parameters.AddWithValue("@DESCRIPCION", especialidad.Descripcion);
            comando.Parameters.AddWithValue("@AREA", especialidad.Area);
            comando.Parameters.AddWithValue("@COSTO", especialidad.Costo);
            comando.Parameters.AddWithValue("@DISPONIBILIDAD", especialidad.Disponibilidad);
            comando.Parameters.AddWithValue("@OBSERVACIONES", especialidad.Observaciones);
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

        // (3) Editar una especialidad en la base de datos
        public int EditarEspecialidad(EntidadEspecialidad especialidad)
        {
            int filasAfectadas = 0;
            // Establecer el objeto de conexión
            SqlConnection conexion = new SqlConnection(_cadenaConexion);


            // Establecer el comando SQL
            SqlCommand comando = new SqlCommand();
           
            string ruta = "UPDATE ESPECIALIDADES SET NOMBRE_ESPECIALIDAD = @NOMBRE_ESPECIALIDAD, DESCRIPCION = @DESCRIPCION, " +
                          "AREA = @AREA, COSTO = @COSTO, DISPONIBILIDAD = @DISPONIBILIDAD, OBSERVACIONES = @OBSERVACIONES " +
                          "WHERE ESPECIAL_ID = (SELECT ESPECIAL_ID FROM ESPECIALIDADES WHERE ESPECIAL_ID = @ESPECIAL_ID)";

            comando.Parameters.AddWithValue("@ESPECIAL_ID", especialidad.ID_Especialidad);
            comando.Parameters.AddWithValue("@NOMBRE_ESPECIALIDAD", especialidad.Nombre_Especialidad);
            comando.Parameters.AddWithValue("@DESCRIPCION", especialidad.Descripcion);
            comando.Parameters.AddWithValue("@AREA", especialidad.Area);
            comando.Parameters.AddWithValue("@COSTO", especialidad.Costo);
            comando.Parameters.AddWithValue("@DISPONIBILIDAD", especialidad.Disponibilidad);
            comando.Parameters.AddWithValue("@OBSERVACIONES", especialidad.Observaciones);
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


        // (4) Eliminar una especialidad de la base de datos
        public int EliminarEspecialidad(int especialidadId)
        {
            int id = 0;
            // Establecer el objeto de conexión
            using (SqlConnection cnx = new SqlConnection(_cadenaConexion))
            {
                // Establecer el comando SQL
                SqlCommand comando = new SqlCommand();
                comando.Connection = cnx;
                string ruta = "DELETE FROM ESPECIALIDADES WHERE ESPECIAL_ID = @ESPECIAL_ID";

                comando.Parameters.AddWithValue("@ESPECIAL_ID", especialidadId);
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

        //VERIFICACION DE EXISTENCIA EN LA BASEDEDATOS
        public bool EspecialidadExiste(EntidadEspecialidad especialidad)
        {
            bool existe = false;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            {
                conexion.Open();

                // Ejecutar una consulta para verificar si el dato existe en la base de datos
                string query = "SELECT COUNT(*) FROM ESPECIALIDADES WHERE NOMBRE_ESPECIALIDAD = @ESPECIALIDAD";
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@ESPECIALIDAD", especialidad.Nombre_Especialidad);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    existe = true;
                }
            }

            return existe;
        }
    }
}
