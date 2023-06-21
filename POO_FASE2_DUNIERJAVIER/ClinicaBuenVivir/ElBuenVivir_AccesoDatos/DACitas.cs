using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;
using System.Reflection;

namespace ElBuenVivir_AccesoDatos
{
    public class DACitas
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }


        //Constructor
        public DACitas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) Acceso a datos mediante una Lista
        public List<EntidadCitas> ListarCitas(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadCitas> cita;

            string instruccionDB = "SELECT C.CITAS_ID, C.ID_MEDICOS_ESPECIALIDADES, C.HORARIO_ID, C.ESTADO, C.MOTIVO, C.OBSERVACIONES, C.PAGADO, C.METODO_PAGO, H.FECHA, H.HORA_INICIO, H.HORA_FIN\n" +
                "FROM CITAS C\n" +
                "INNER JOIN HORARIO H ON C.HORARIO_ID = H.HORARIO_ID;";


            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "CITAS");
                 cita = (from DataRow row in elDataSet.Tables["CITAS"].Rows
                          select new EntidadCitas()
                          {
                              CitasId = Convert.ToInt32(row[0]),
                              IdMedicosEspecialidades = Convert.ToInt32(row[1]),
                              HorarioId = Convert.ToInt32(row[2]),
                              Estado = row[3].ToString(),
                              Motivo = row[4].ToString(),
                              Observaciones = row[5].ToString(),
                              Pagado = row[6].ToString(),
                              Metodo_Pago = row[7].ToString(),
                              Fecha = DateTime.Parse(row[8].ToString()),
                              HoraInicio = TimeSpan.Parse(row[9].ToString()),
                              HoraFin = TimeSpan.Parse(row[10].ToString())
                          }).ToList();

            }
            catch (Exception)
            {
                
                throw;
            }
            return cita;
        }

        // (2a) Insertar datos del hoarario y recibir el id a la base de datos
        public int InsertarHorario(EntidadHorario horario)
        {
            int id = 0;
            // Establecer el objeto conexión
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            // Establecer el comando SQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO HORARIO (FECHA, HORA_INICIO, HORA_FIN) " +
                          "VALUES (@FECHA, @HORA_INICIO, @HORA_FIN); SELECT SCOPE_IDENTITY()";

            comando.Parameters.AddWithValue("@FECHA", horario.Fecha);
            comando.Parameters.AddWithValue("@HORA_INICIO", horario.HoraInicio);
            comando.Parameters.AddWithValue("@HORA_FIN", horario.HoraFin);
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

        // (2b) Insertar datos de la cita y recibir el id
        public int InsertarCita(EntidadCitas citas)
        {
            int id = 0;
            // Establecer el objeto conexión
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            // Establecer el comando SQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO CITAS (ID_MEDICOS_ESPECIALIDADES, HORARIO_ID, ESTADO, MOTIVO, OBSERVACIONES, PAGADO, METODO_PAGO) " +
                          "VALUES (@ID_MEDICOS_ESPECIALIDADES, @HORARIO_ID, @ESTADO, @MOTIVO, @OBSERVACIONES, @PAGADO, @METODO_PAGO); " +
                          "SELECT SCOPE_IDENTITY()";

            comando.Parameters.AddWithValue("@ID_MEDICOS_ESPECIALIDADES", citas.IdMedicosEspecialidades);
            comando.Parameters.AddWithValue("@HORARIO_ID", citas.HorarioId);
            comando.Parameters.AddWithValue("@ESTADO", citas.Estado);
            comando.Parameters.AddWithValue("@MOTIVO", citas.Motivo);
            comando.Parameters.AddWithValue("@OBSERVACIONES", citas.Observaciones);
            comando.Parameters.AddWithValue("@PAGADO", citas.Pagado);
            comando.Parameters.AddWithValue("@METODO_PAGO", citas.Metodo_Pago);
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
