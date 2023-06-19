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

            string instruccionDB = "SELECT FUNCIONARIO_ID, PUESTO, NOMBRE_FUNCIONARIO, APELLIDOS, " +
                "FECHA_NACIMIENTO, GENERO, NACIONALIDAD, ESTADO_CIVIL, DIAS_LIBRES, CORREO, " +
                "TELEFONO, CIUDAD, PROVINCIA, DIRECCION_DETALLE, ANOTACIONES, HORA_ENTRADA, HORA_SALIDA FROM FUNCIONARIOS";

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
                                    Puesto = row[1].ToString(),
                                    Nombre = row[2].ToString(),
                                    Apellidos = row[3].ToString(),
                                    FechaNacimiento = row[4].ToString(),
                                    Genero = row[5].ToString(),
                                    Nacionalidad = row[6].ToString(),
                                    EstadoCivil = row[7].ToString(),
                                    DiasLibres = row[8].ToString(),
                                    Correo = row[9].ToString(),
                                    Telefono = Convert.ToInt32(row[10]),
                                    Ciudad = row[11].ToString(),
                                    Provincia = row[12].ToString(),
                                    DetalleDireccion = row[13].ToString(),
                                    Anotaciones = row[14].ToString(),
                                    HoraEntrada = row[15].ToString(),
                                    HoraSalida = row[16].ToString(),
                                }).ToList();

                // Utiliza la lista de funcionarios como necesites
            }
            catch (Exception)
            {
                throw;
            }
            return funcionarios;
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
            string ruta = "INSERT INTO FUNCIONARIOS (FUNCIONARIO_ID, PUESTO, NOMBRE_FUNCIONARIO, APELLIDOS, FECHA_NACIMIENTO, " +
                "GENERO, NACIONALIDAD, ESTADO_CIVIL, DIAS_LIBRES, CORREO, TELEFONO, CIUDAD, PROVINCIA, DIRECCION_DETALLE, " +
                "ANOTACIONES, HORA_ENTRADA, HORA_SALIDA) " +
               "VALUES (@FUNCIONARIO_ID, @PUESTO, @NOMBRE_FUNCIONARIO, @APELLIDOS, @FECHA_NACIMIENTO, " +
               "@GENERO, @NACIONALIDAD, @ESTADO_CIVIL, @DIAS_LIBRES, @CORREO, @TELEFONO, @CIUDAD, @PROVINCIA, " +
               "@DIRECCION_DETALLE, @ANOTACIONES, @HORA_ENTRADA, @HORA_SALIDA); SELECT SCOPE_IDENTITY()";

            comando.Parameters.AddWithValue("@FUNCIONARIO_ID", funcionario.Identificacion);
            comando.Parameters.AddWithValue("@PUESTO", funcionario.Puesto);
            comando.Parameters.AddWithValue("@NOMBRE_FUNCIONARIO", funcionario.Nombre);
            comando.Parameters.AddWithValue("@APELLIDOS", funcionario.Apellidos);
            comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", funcionario.FechaNacimiento);
            comando.Parameters.AddWithValue("@GENERO", funcionario.Genero);
            comando.Parameters.AddWithValue("@NACIONALIDAD", funcionario.Nacionalidad);
            comando.Parameters.AddWithValue("@ESTADO_CIVIL", funcionario.EstadoCivil);
            comando.Parameters.AddWithValue("@DIAS_LIBRES", funcionario.DiasLibres);
            comando.Parameters.AddWithValue("@CORREO", funcionario.Correo);
            comando.Parameters.AddWithValue("@TELEFONO", funcionario.Telefono);
            comando.Parameters.AddWithValue("@CIUDAD", funcionario.Ciudad);
            comando.Parameters.AddWithValue("@PROVINCIA", funcionario.Provincia);
            comando.Parameters.AddWithValue("@DIRECCION_DETALLE", funcionario.DetalleDireccion);
            comando.Parameters.AddWithValue("@ANOTACIONES", funcionario.Anotaciones);
            comando.Parameters.AddWithValue("@HORA_ENTRADA", funcionario.HoraEntrada);
            comando.Parameters.AddWithValue("@HORA_SALIDA", funcionario.HoraSalida);
            comando.CommandText = ruta;
            try
            {
                cnx.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                cnx.Close();
            }
            catch (Exception)
            {
               // throw;
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
