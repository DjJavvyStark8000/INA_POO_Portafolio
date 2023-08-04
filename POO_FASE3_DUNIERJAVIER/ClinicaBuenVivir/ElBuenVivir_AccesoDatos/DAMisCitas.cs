using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DAMisCitas
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }


        //Constructor
        public DAMisCitas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) Acceso a datos mediante una Lista
        public List<EntidadMisCitas> ListarMisCitas(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadMisCitas> cita;

            string instruccionDB = "SELECT C.CITAS_ID,H.FECHA,H.HORA_INICIO, ESTADO, C.MOTIVO,F.NOMBRE_FUNCIONARIO,P.MONTO, OBSERVACIONES\n" +
                "FROM CITAS AS C\n" +
                "INNER JOIN HORARIO AS H ON C.HORARIO_ID = H.HORARIO_ID\n" +
                "INNER JOIN PAGOS AS P ON C.PAGOS_ID = P.PAGOS_ID\n" +
                "INNER JOIN PLATAFORMA AS PF ON C.CITAS_ID = PF.CITAS_ID\n" +
                "INNER JOIN FUNCIONARIOS AS F ON PF.FUNCIONARIO_ID = F.FUNCIONARIO_ID\n" +
                "INNER JOIN PACIENTES AS PA ON PF.PACIENTE_ID = PA.PACIENTE_ID";


            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {

                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "CITAS");
                cita = (from DataRow row in elDataSet.Tables["CITAS"].Rows
                        select new EntidadMisCitas()
                        {
                            CitasId = Convert.ToInt32(row[0]),
                            FechaCita = row[1].ToString(),
                            HoraCita = row[2].ToString(),
                            Estado = row[3].ToString(),
                            Motivo = row[4].ToString(),
                            Medico = row[5].ToString(),
                            Monto = Convert.ToDecimal(row[6]),
                            Observaciones = row[7].ToString(),
                           
                        }).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            return cita;
        }
    }
}
