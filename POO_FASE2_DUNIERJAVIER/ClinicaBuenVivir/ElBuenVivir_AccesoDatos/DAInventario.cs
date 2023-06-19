using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;

namespace ElBuenVivir_AccesoDatos
{
    public class DAInventario
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAInventario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) Acceso a datos mediante una Lista
        public List<EntidadInventario> ListarInventario(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection laConexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadInventario> inventario;

            string instruccionDB = "SELECT INVENTARIO_ID, PRODUCTO, " +
                "CANTIDAD, FECHA_CADUCIDAD, PRECIO_UNITARIO, PROVEEDOR FROM INVENTARIO";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(instruccionDB, laConexion);
                adapter.Fill(elDataSet, "INVENTARIO");
                inventario = (from DataRow row in elDataSet.Tables["INVENTARIO"].Rows
                              select new EntidadInventario()
                              {
                                  Inventario_Id = Convert.ToInt32(row[0]),
                                  Producto = row[1].ToString(),
                                  Cantidad = Convert.ToInt32(row[2]),
                                  Caducidad = DateTime.Parse(row[3].ToString()),
                                  Precio_Unitario = (decimal)row[4],
                                  Proveedor = row[5].ToString(),
                              }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return inventario;
        }
      
    }
}
