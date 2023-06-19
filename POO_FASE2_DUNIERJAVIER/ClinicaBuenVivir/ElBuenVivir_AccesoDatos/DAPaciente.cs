using System;
using System.Collections.Generic;
using System.Text;
using ElBuenVivir_Entidades;
using System.Data.SqlClient;
using System.Data;
using System.Linq;


namespace ElBuenVivir_AccesoDatos
{
    public class DAPaciente : Persona
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAPaciente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //METODOS
        //CARGAR PACIENTES
        public List<EntidadPaciente> ListarPacientes(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadPaciente> pacientes;

            string instruccionDB = "SELECT PACIENTE_ID, ID_HISTORIAL, TIPO_ID, NOMBRE_PACIENTE, APELLIDOS, FECHA_NACIMIENTO, " +
                "GENERO, NACIONALIDAD,CORREO,TELEFONO, CIUDAD, PROVINCIA, DIRECCION_DETALLE, ESTADO_CIVIL," +
                "LABORANDO, EMERGENCIA_NUM, GUARDIAN, ASEGURADO FROM PACIENTES";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                Console.Beep();
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "PACIENTES");

                pacientes = (from DataRow row in elDataSet.Tables["PACIENTES"].Rows
                                select new EntidadPaciente()
                                {
                                    Identificacion = Convert.ToInt32(row[0]),
                                    Id_Historial = Convert.ToInt32(row[1]),
                                    Tipo_id = row[2].ToString(),
                                    Nombre = row[3].ToString(),
                                    Apellidos = row[4].ToString(),
                                    FechaNacimiento = row[5].ToString(),
                                    Genero = row[6].ToString(),
                                    Nacionalidad = row[7].ToString(),
                                    Correo = row[8].ToString(),
                                    Telefono = Convert.ToInt32(row[9]),
                                    Ciudad = row[10].ToString(),
                                    Provincia = row[11].ToString(),
                                    DetalleDireccion = row[12].ToString(),
                                    EstadoCivil = row[13].ToString(),
                                    Laborando = row[14].ToString(),
                                    NumeroEmergencia= Convert.ToInt32(row[15]),
                                    Guardian = row[16].ToString(),
                                    Asegurado = row[17].ToString()
                                }).ToList();
                // Utiliza la lista de funcionarios como necesites
            }
            catch (Exception)
            {
                throw;
            }
            return pacientes;
        }



        //INSERTAR PACIENTE
        public int InsertarPaciente(EntidadPaciente paciente)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO PACIENTES (PACIENTE_ID, TIPO_ID, NOMBRE_PACIENTE, APELLIDOS, FECHA_NACIMIENTO, GENERO, NACIONALIDAD," +
                "CORREO, TELEFONO, CIUDAD,PROVINCIA, DIRECCION_DETALLE, ESTADO_CIVIL, LABORANDO, EMERGENCIA_NUM, GUARDIAN, ASEGURADO)" +
                "VALUES (@PACIENTES_ID, @TIPO_ID, @NOMBRE_PACIENTE, @APELLIDOS, @FECHA_NACIMIENTO, @GENERO, @NACIONALIDAD," +
                "@CORREO, @TELEFONO, @CIUDAD, @PROVINCIA, @DIRECCION_DETALLE, @ESTADO_CIVIL, @LABORANDO, @EMERGENCIA_NUM, @GUARDIAN, @ASEGURADO" +
                "); SELECT SCOPE_IDENTITY()";
            comando.Parameters.AddWithValue("@PACIENTE_ID", paciente.Identificacion);
            comando.Parameters.AddWithValue("@TIPO_ID", paciente.Tipo_id);
            comando.Parameters.AddWithValue("@NOMBRE_PACIENTE", paciente.Nombre);
            comando.Parameters.AddWithValue("@APELLIDOS", paciente.Apellidos);
            comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", paciente.FechaNacimiento);
            comando.Parameters.AddWithValue("@GENERO", paciente.Genero);
            comando.Parameters.AddWithValue("@NACIONALIDAD", paciente.Nacionalidad);
            comando.Parameters.AddWithValue("@CORREO", paciente.Correo);
            comando.Parameters.AddWithValue("@TELEFONO", paciente.Telefono);
            comando.Parameters.AddWithValue("@CIUDAD", paciente.Ciudad);
            comando.Parameters.AddWithValue("@PROVINCIA", paciente.Provincia);
            comando.Parameters.AddWithValue("@DIRECCION_DETALLE", paciente.DetalleDireccion);
            comando.Parameters.AddWithValue("@ESTADO_CIVIL", paciente.EstadoCivil);
            comando.Parameters.AddWithValue("@LABORANDO", paciente.Laborando);
            comando.Parameters.AddWithValue("@EMERGENCIA_NUM", paciente.NumeroEmergencia);
            comando.Parameters.AddWithValue("@GUARDIAN", paciente.Guardian);
            comando.Parameters.AddWithValue("@ASEGURADO", paciente.Asegurado);
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
