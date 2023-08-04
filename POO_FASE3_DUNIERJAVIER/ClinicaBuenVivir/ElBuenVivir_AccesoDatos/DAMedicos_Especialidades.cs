using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace ElBuenVivir_AccesoDatos
{
    public class DAMedicos_Especialidades
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAMedicos_Especialidades(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        // (1) Acceso a datos mediante una Lista
        public int IdMedicosEspecialides(int medicoId = 0)
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            int medEspecialidadId = 0;
            laConexion.Open();
            // Consulta SQL para obtener el ID de MEDICOS_ESPECIALIDADES
            string query = "SELECT MED_ESP_ID FROM MEDICOS_ESPECIALIDADES WHERE ID_MEDICOS = @ID_MEDICOS";
            using (SqlCommand command = new SqlCommand(query, laConexion))
            {
                command.Parameters.AddWithValue("@ID_MEDICOS", medicoId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        medEspecialidadId = reader.GetInt32(0);
                    }                   
                }
            }
            return medEspecialidadId;
        }
    }
}
