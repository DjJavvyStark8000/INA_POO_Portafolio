using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DAMedicos
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAMedicos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }


        // (***************) Acceso a datos mediante una Lista PARA MEDICOS DE LA CLINICA
        public List<EntidadMedicos> ListarMedicos(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadMedicos> medicos;

            string instruccionDB = "SELECT MEDICOS_ID, NOMBRE_MEDICO, APELLIDOS, FECHA_NACIMIENTO, " +
                "GENERO, NACIONALIDAD, ESTADO_CIVIL, DIAS_LIBRES, CORREO, TELEFONO, CIUDAD, " +
                "PROVINCIA, DIRECCION_DETALLE, ANOTACIONES, PUESTO, HORA_ENTRADA, HORA_SALIDA FROM MEDICOS";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "MEDICOS");

                medicos = (from DataRow row in elDataSet.Tables["MEDICOS"].Rows
                           select new EntidadMedicos()
                           {
                               Identificacion = Convert.ToInt32(row[0]),
                               Nombre = row[1].ToString(),
                               Apellidos = row[2].ToString(),
                               FechaNacimiento = row[3].ToString(),
                               Genero = row[4].ToString(),
                               Nacionalidad = row[5].ToString(),
                               EstadoCivil = row[6].ToString(),
                               DiasLibres = row[7].ToString(),
                               Correo = row[8].ToString(),
                               Telefono = Convert.ToInt32(row[9]),
                               Ciudad = row[10].ToString(),
                               Provincia = row[11].ToString(),
                               DetalleDireccion = row[12].ToString(),
                               Anotaciones = row[13].ToString(),
                               Puesto = row[14].ToString(),
                               HoraEntrada = row[15].ToString(),
                               HoraSalida = row[16].ToString(),
                           }).ToList();

                // Utiliza la lista de funcionarios como necesites
            }
            catch (Exception)
            {
                throw;
            }
            return medicos;
        }
    }
}
