using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DARecetas
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DARecetas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) Acceso a datos mediante una Lista
        public List<EntidadRecetas> ListarRecetas(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadRecetas> receta;

            string instruccionDB = "SELECT RECETAS_ID, INVENTARIO_ID, ID_MED_ESPECIAL, NOMBRE_RECETA, " +
                "DOSIS, FECHA_RETIRO, DURACION, INDICACIONES,CANTIDAD_RECETAS, PROXIMA_RECETA FROM RECETAS";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
               
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "RECETAS");
                receta = (from DataRow row in elDataSet.Tables["RECETAS"].Rows
                          select new EntidadRecetas()
                          {
                              RecetaId = Convert.ToInt32(row[0]),
                              InventarioId = Convert.ToInt32(row[1]),
                              IdMedEspecial= Convert.ToInt32(row[2]),
                              NombreReceta = row[3].ToString(),
                              Dosis = row[4].ToString(),
                              FechaRetiro = row[5].ToString(),
                              Duracion = row[6].ToString(),
                              Indicaciones = row[7].ToString(),
                              CantidadRecetas = Convert.ToInt32(row[8]),
                              ProximaReceta = row[9].ToString(),
                          }).ToList();
              
            }
            catch (Exception)
            {
                throw;

            }
            return receta;
        }
    }
}
