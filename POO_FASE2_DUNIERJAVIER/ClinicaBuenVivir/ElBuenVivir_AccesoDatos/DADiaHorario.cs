using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DADiaHorario
    {

        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DADiaHorario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //ver horario de un dia de un funcionario
        public List<EntidadDiaHorario> ListarHorarioDia(string condicion = "", string dia = "")//resibe condicion y nombre del dia
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadDiaHorario> medico;

            string instruccionDB = "SELECT F.FUNCIONARIO_ID, HF.LUNES, HF.MARTES, HF.MIERCOLES, HF.JUEVES, HF.VIERNES, HF.SABADO, HF.DOMINGO\n" +
                        "FROM HORARIO H\n" +
                        "INNER JOIN FUNCIONARIOS F ON H.MEDICO_ID = F.FUNCIONARIO_ID\n" +
                        "INNER JOIN HORARIOFUNCIONARIOS HF ON F.HORARIO_ID = HF.HORARIO_ID";


            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {

                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "MEDICOHORARIO");
                medico = (from DataRow row in elDataSet.Tables["MEDICOHORARIO"].Rows
                          select new EntidadDiaHorario()
                          {
                              MedicoID = Convert.ToInt32(row[0].ToString()),
                              Lunes = row[1].ToString(),
                              Martes = row[2].ToString(),
                              Miercoles = row[3].ToString(),
                              Jueves = row[4].ToString(),
                              Viernes = row[5].ToString(),
                              Sabado = row[6].ToString(),
                              Domingo = row[7].ToString(),
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
