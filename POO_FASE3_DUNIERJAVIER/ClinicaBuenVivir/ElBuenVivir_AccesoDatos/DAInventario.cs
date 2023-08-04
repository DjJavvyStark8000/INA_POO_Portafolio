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
                                  Caducidad = row[3].ToString(),
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

        // (2) Insertar medicamento a la base de datos
        public int InsertarInventario(EntidadInventario inventario)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string ruta = "INSERT INTO INVENTARIO (PRODUCTO, CANTIDAD, FECHA_CADUCIDAD, PRECIO_UNITARIO, PROVEEDOR) " +
                "VALUES (@PRODUCTO, @CANTIDAD, @FECHA_CADUCIDAD, @PRECIO_UNITARIO, @PROVEEDOR); SELECT SCOPE_IDENTITY()";

            comando.Parameters.AddWithValue("@PRODUCTO", inventario.Producto);
            comando.Parameters.AddWithValue("@CANTIDAD", inventario.Cantidad);
            comando.Parameters.AddWithValue("@FECHA_CADUCIDAD", inventario.Caducidad);
            comando.Parameters.AddWithValue("@PRECIO_UNITARIO", inventario.Precio_Unitario);
            comando.Parameters.AddWithValue("@PROVEEDOR", inventario.Proveedor);
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

        // (3) Editar un medicamento en la base de datos
        public int EditarInventario(EntidadInventario inventario)
        {
            int filasAfectadas = 0;
            // Establecer el objeto de conexión
            SqlConnection conexion = new SqlConnection(_cadenaConexion);


            // Establecer el comando SQL
            SqlCommand comando = new SqlCommand();

            string ruta = "UPDATE INVENTARIO SET PRODUCTO = @PRODUCTO, CANTIDAD = @CANTIDAD, FECHA_CADUCIDAD = @FECHA_CADUCIDAD, " +
                   "PRECIO_UNITARIO = @PRECIO_UNITARIO, PROVEEDOR = @PROVEEDOR WHERE INVENTARIO_ID = " +
                   "(SELECT INVENTARIO_ID FROM INVENTARIO WHERE INVENTARIO_ID = @INVENTARIO_ID)";

            comando.Parameters.AddWithValue("@INVENTARIO_ID", inventario.Inventario_Id);
            comando.Parameters.AddWithValue("@PRODUCTO", inventario.Producto);
            comando.Parameters.AddWithValue("@CANTIDAD", inventario.Cantidad);
            comando.Parameters.AddWithValue("@FECHA_CADUCIDAD", inventario.Caducidad);
            comando.Parameters.AddWithValue("@PRECIO_UNITARIO", inventario.Precio_Unitario);
            comando.Parameters.AddWithValue("@PROVEEDOR", inventario.Proveedor);

            comando.CommandText = ruta;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                filasAfectadas = Convert.ToInt32(comando.ExecuteNonQuery());
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return filasAfectadas;
        }


        // (4) Eliminar un medicamento de la base de datos
        public int EliminarInventario(int inventarioId)
        {
            int id = 0;
            // Establecer el objeto de conexión
            using (SqlConnection cnx = new SqlConnection(_cadenaConexion))
            {
                // Establecer el comando SQL
                SqlCommand comando = new SqlCommand();
                comando.Connection = cnx;
                string ruta = "DELETE FROM INVENTARIO WHERE INVENTARIO_ID = @INVENTARIO_ID";

                comando.Parameters.AddWithValue("@INVENTARIO_ID", inventarioId);
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
                return id;
            }
        }

    }
}
