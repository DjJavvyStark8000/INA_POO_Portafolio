using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace ElBuenVivir_AccesoDatos
{
    public class DAPagos
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAPagos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (2) Insertar pagos a la base de datos
        public int InsertarPago(EntidadPagos pago)
        {
            int id = 0;
            // Establecer el objeto conexión
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            // Establecer el comando SQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO PAGOS (MONTO, METODOPAGO) " +
                          "VALUES (@MONTO, @METODOPAGO); SELECT SCOPE_IDENTITY()";

            // Declare the MONTO parameter
            SqlParameter montoParam = new SqlParameter("@MONTO", SqlDbType.Decimal);
            montoParam.Value = pago.Monto;
            comando.Parameters.Add(montoParam);
            comando.Parameters.AddWithValue("@METODOPAGO", pago.MetodoPago);        
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
