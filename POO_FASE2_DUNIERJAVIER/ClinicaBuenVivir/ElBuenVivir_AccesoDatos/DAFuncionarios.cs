using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DAFuncionarios
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAFuncionarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (***************) Acceso a datos mediante una Lista PARA FUNCIONARIOS DE LA CLINICA
        public List<EntidadFuncionario> ListarFuncionarios(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadFuncionario> funcionarios;

            string instruccionDB = "SELECT FUNCIONARIO_ID, HORARIO_ID, PUESTO, NOMBRE_FUNCIONARIO, APELLIDOS, " +
                "FECHA_NACIMIENTO, GENERO, NACIONALIDAD, ESTADO_CIVIL, CORREO, " +
                "TELEFONO, CIUDAD, PROVINCIA, DIRECCION_DETALLE, ANOTACIONES FROM FUNCIONARIOS";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "FUNCIONARIOS");

                funcionarios = (from DataRow row in elDataSet.Tables["FUNCIONARIOS"].Rows
                                select new EntidadFuncionario()
                                {
                                    Identificacion = Convert.ToInt32(row[0]),
                                    HorarioId = Convert.ToInt32(row[1]),
                                    Puesto = row[2].ToString(),
                                    Nombre = row[3].ToString(),
                                    Apellidos = row[4].ToString(),
                                    FechaNacimiento = row[5].ToString(),
                                    Genero = row[6].ToString(),
                                    Nacionalidad = row[7].ToString(),
                                    EstadoCivil = row[8].ToString(),
                                    Correo = row[9].ToString(),
                                    Telefono = Convert.ToInt32(row[10]),
                                    Ciudad = row[11].ToString(),
                                    Provincia = row[12].ToString(),
                                    DetalleDireccion = row[13].ToString(),
                                    Anotaciones = row[14].ToString(),
                                }).ToList();

                // Utiliza la lista de funcionarios como necesites
            }
            catch (Exception)
            {
                throw;
            }
            return funcionarios;
        }

        //listar medicos unicamente
        public List<EntidadFuncionario> ListarMedicos(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadFuncionario> medico;

            string instruccionDB = "SELECT NOMBRE_FUNCIONARIO, FUNCIONARIO_ID\n" +
                "FROM FUNCIONARIOS\n" +
                "WHERE PUESTO = 'Medico'";


            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {

                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "MEDICOHORARIO");
                medico = (from DataRow row in elDataSet.Tables["MEDICOHORARIO"].Rows
                          select new EntidadFuncionario()
                          {
                              Nombre = row[0].ToString(),
                              Identificacion = Convert.ToInt32(row[1].ToString()),
                          }).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            return medico;
        }


        // (2) Insertar datos a la base de datos
        public int InsertarFuncionario(EntidadFuncionario funcionario)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO FUNCIONARIOS (FUNCIONARIO_ID, HORARIO_ID, PUESTO, NOMBRE_FUNCIONARIO, APELLIDOS, FECHA_NACIMIENTO, " +
                "GENERO, NACIONALIDAD, ESTADO_CIVIL, CORREO, TELEFONO, CIUDAD, PROVINCIA, DIRECCION_DETALLE, " +
                "ANOTACIONES) " +
               "VALUES (@FUNCIONARIO_ID, @HORARIO_ID, @PUESTO, @NOMBRE_FUNCIONARIO, @APELLIDOS, @FECHA_NACIMIENTO, " +
               "@GENERO, @NACIONALIDAD, @ESTADO_CIVIL, @CORREO, @TELEFONO, @CIUDAD, @PROVINCIA, " +
               "@DIRECCION_DETALLE, @ANOTACIONES); SELECT SCOPE_IDENTITY()";

            comando.Parameters.AddWithValue("@FUNCIONARIO_ID", funcionario.Identificacion);
            comando.Parameters.AddWithValue("@HORARIO_ID", funcionario.HorarioId);
            comando.Parameters.AddWithValue("@PUESTO", funcionario.Puesto);
            comando.Parameters.AddWithValue("@NOMBRE_FUNCIONARIO", funcionario.Nombre);
            comando.Parameters.AddWithValue("@APELLIDOS", funcionario.Apellidos);
            comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", funcionario.FechaNacimiento);
            comando.Parameters.AddWithValue("@GENERO", funcionario.Genero);
            comando.Parameters.AddWithValue("@NACIONALIDAD", funcionario.Nacionalidad);
            comando.Parameters.AddWithValue("@ESTADO_CIVIL", funcionario.EstadoCivil);
            comando.Parameters.AddWithValue("@CORREO", funcionario.Correo);
            comando.Parameters.AddWithValue("@TELEFONO", funcionario.Telefono);
            comando.Parameters.AddWithValue("@CIUDAD", funcionario.Ciudad);
            comando.Parameters.AddWithValue("@PROVINCIA", funcionario.Provincia);
            comando.Parameters.AddWithValue("@DIRECCION_DETALLE", funcionario.DetalleDireccion);
            comando.Parameters.AddWithValue("@ANOTACIONES", funcionario.Anotaciones);
            comando.CommandText = ruta;
            try
            {
                cnx.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                cnx.Close();
            }
            catch (Exception)
            {
               //throw;
            }
            finally
            {
                cnx.Dispose();
                comando.Dispose();
            }
            return id;
        }

        // (3) Editar un funcionario existe en la base de datos
        public int EditarFuncionario(EntidadFuncionario funcionario)
        {
            int filasAfectadas = 0;
            // Establecer el objeto de conexión
            SqlConnection conexion = new SqlConnection(_cadenaConexion);


            // Establecer el comando SQL
            SqlCommand comando = new SqlCommand();

            string ruta = "UPDATE FUNCIONARIOS SET FUNCIONARIO_ID = @FUNCIONARIO_ID, PUESTO = @PUESTO, " +
                "NOMBRE_FUNCIONARIO = @NOMBRE_FUNCIONARIO, APELLIDOS = @APELLIDOS, FECHA_NACIMIENTO = @FECHA_NACIMIENTO, " +
                "GENERO = @GENERO, NACIONALIDAD = @NACIONALIDAD, ESTADO_CIVIL = @ESTADO_CIVIL, CORREO =  @CORREO, " +
                "TELEFONO = @TELEFONO, CIUDAD = @CIUDAD, PROVINCIA = @PROVINCIA, DIRECCION_DETALLE = @DIRECCION_DETALLE, " +
                "ANOTACIONES = @ANOTACIONES WHERE FUNCIONARIO_ID = " +
                   "(SELECT FUNCIONARIO_ID FROM FUNCIONARIOS WHERE FUNCIONARIO_ID = @FUNCIONARIO_ID)";

            comando.Parameters.AddWithValue("@FUNCIONARIO_ID", funcionario.Identificacion);
            comando.Parameters.AddWithValue("@PUESTO", funcionario.Puesto);
            comando.Parameters.AddWithValue("@NOMBRE_FUNCIONARIO", funcionario.Nombre);
            comando.Parameters.AddWithValue("@APELLIDOS", funcionario.Apellidos);
            comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", funcionario.FechaNacimiento);
            comando.Parameters.AddWithValue("@GENERO", funcionario.Genero);
            comando.Parameters.AddWithValue("@NACIONALIDAD", funcionario.Nacionalidad);
            comando.Parameters.AddWithValue("@ESTADO_CIVIL", funcionario.EstadoCivil);
            comando.Parameters.AddWithValue("@CORREO", funcionario.Correo);
            comando.Parameters.AddWithValue("@TELEFONO", funcionario.Telefono);
            comando.Parameters.AddWithValue("@CIUDAD", funcionario.Ciudad);
            comando.Parameters.AddWithValue("@PROVINCIA", funcionario.Provincia);
            comando.Parameters.AddWithValue("@DIRECCION_DETALLE", funcionario.DetalleDireccion);
            comando.Parameters.AddWithValue("@ANOTACIONES", funcionario.Anotaciones);

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


        // (4) Eliminar un funcionario de la base de datos
        public int EliminarFuncionario(int funcionarioId)
        {
            int id = 0;
            // Establecer el objeto de conexión
            using (SqlConnection cnx = new SqlConnection(_cadenaConexion))
            {
                // Establecer el comando SQL
                SqlCommand comando = new SqlCommand();
                comando.Connection = cnx;
                string ruta = "DELETE FROM FUNCIONARIOS WHERE FUNCIONARIO_ID = @FUNCIONARIO_ID";

                comando.Parameters.AddWithValue("@FUNCIONARIO_ID", funcionarioId);
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
