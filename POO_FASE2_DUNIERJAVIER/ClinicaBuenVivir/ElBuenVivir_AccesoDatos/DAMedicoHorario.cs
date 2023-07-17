using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DAMedicoHorario
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAMedicoHorario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        //ver medicos por fecha y horario
        public List<EntidadMedicoHorario> ListarMedicosXHorario(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadMedicoHorario> medico;

            string instruccionDB = "SELECT F.NOMBRE_FUNCIONARIO, F.PUESTO, H.FECHA, H.HORA_INICIO, H.HORA_FIN, H.MEDICO_ID\n" +
                "FROM HORARIO H\n" +
                "INNER JOIN FUNCIONARIOS F ON H.MEDICO_ID = F.FUNCIONARIO_ID";


            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {

                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "MEDICOHORARIO");
                medico = (from DataRow row in elDataSet.Tables["MEDICOHORARIO"].Rows
                          select new EntidadMedicoHorario()
                          {
                              NombreMedico = row[0].ToString(),
                              Puesto = row[1].ToString(),
                              Fecha = row[2].ToString(),
                              Horain = row[3].ToString(),
                              Horaout = row[4].ToString(),
                              Medicoid = Convert.ToInt32(row[5].ToString()),

                          }).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            return medico;
        }
    }
}
