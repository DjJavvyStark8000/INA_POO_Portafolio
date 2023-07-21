using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entidades;
using System.Linq;
using System.Data;

namespace _03_CapaBaseDatos
{
    public class DAProductos
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAProductos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }


        //Metodos
        public int InsertarProducto(EntidadesProductos producto)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string instruccion = "INSERT INTO PRODUCTOS (DESCRIPCION, PRECIOCOMPRA, PRECIOVENTA, GRAVADO) " +
                "VALUES (@DESCRIPCION, @PRECIOCOMPRA, @PRECIOVENTA, @GRAVADO); SELECT SCOPE_IDENTITY()";
            comando.Parameters.AddWithValue("@DESCRIPCION", producto.Descripcion);
            comando.Parameters.AddWithValue("@PRECIOCOMPRA", producto.Precio_compra);
            comando.Parameters.AddWithValue("@PRECIOVENTA", producto.Precio_venta);
            comando.Parameters.AddWithValue("@GRAVADO", producto.Gravado);
            comando.CommandText = instruccion;

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

        //metodo listar
        public List<EntidadesProductos> ListaProductos(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadesProductos> listaProductos;

            string instruccionDB = "SELECT ID_PRODUCTO, DESCRIPCION, PRECIOCOMPRA, PRECIOVENTA, GRAVADO FROM PRODUCTOS";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(instruccionDB, conexion);
                adapter.Fill(elDataSet, "PRODUCTOS");
                listaProductos = (from DataRow unaFila in elDataSet.Tables["PRODUCTOS"].Rows
                                 select new EntidadesProductos()
                                 {
                                     Id_Producto = (int)unaFila[0],
                                     Descripcion = unaFila[1].ToString(),
                                     Precio_compra = Convert.ToSingle(unaFila[2]),
                                     Precio_venta = Convert.ToSingle(unaFila[3]),
                                     Gravado = unaFila[4].ToString(),
                                 }).ToList();
            }
            catch (Exception)
            {
                Console.Beep();
                throw;
            }
            return listaProductos;
        }

        //info obtenida de consulta se almacena en dataReader
        public EntidadesProductos ObtenerProducto(int id)
        {
            EntidadesProductos producto = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_PRODUCTO, DESCRIPCION, PRECIOCOMPRA, PRECIOVENTA, " +
                "GRAVADO FROM PRODUCTOS WHERE ID_PRODUCTO = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    producto = new EntidadesProductos();
                    dataReader.Read();
                    producto.Id_Producto = dataReader.GetInt32(0);
                    producto.Descripcion = dataReader.GetString(1);
                    producto.Precio_compra = Convert.ToSingle(dataReader.GetDouble(2));
                    producto.Precio_venta = Convert.ToSingle(dataReader.GetDouble(3));
                    producto.Gravado = dataReader.GetString(4);
                    producto.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception) { throw; }
            return producto;
        }

        //EliminarCliente mediante un proceso almacenado
        //********************************************************************************************************************
        public int EliminarRegistroConSP(EntidadesProductos producto)
        {
            int resultado = -1;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            {
                comando.CommandText = "ELIMINAR"; // Controla en procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@ID_PRODUCTO", producto.Id_Producto);

                // Parametros de salida procedimiento almacenado
                comando.Parameters.Add("@MSJ", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;

                //parametro de retorno del sp
                comando.Parameters.Add("@RETORNO", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    //OPTIENE LA VARIABLE DE RETORNO
                    resultado = Convert.ToInt32(comando.Parameters["@RETORNO"].Value);
                    //OPTERNER MENSAJE DEL SP
                    string mensaje = comando.Parameters["@MSJ"].Value.ToString();

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conexion.Close();
                }
                return resultado;
            }
        }

        //Elimiar un cliente sin proceso almacenado
        //public int EliminarProduto(EntidadesProductos producto)
        //{
        //    int afectado = -1;

        //    SqlConnection conexion = new SqlConnection(_cadenaConexion);
        //    SqlCommand comando = new SqlCommand();
        //    {
        //        string sentencia = "DELETE FROM PRODUCTOS";
        //        sentencia = string.Format("{0} WHERE ID_PRODUCTO = {1}", sentencia, producto.Id_Producto);
        //        comando.CommandText = sentencia;
        //        comando.Connection = conexion;

        //        try
        //        {
        //            conexion.Open();
        //            afectado = comando.ExecuteNonQuery();
        //            conexion.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw;
        //        }
        //        finally
        //        {
        //            conexion.Dispose();
        //            comando.Dispose();
        //        }
        //    }

        //    return afectado;
        //}

        //ACTUALIZAR UN PRODUCTO
        public int ModificarCliente(EntidadesProductos producto)
        {
            int filasAfectadas = -1;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            {


                string sentencia = "UPDATE PRODUCTOS SET ID_PRODUCTO=@ID_PRODUCTO, DESCRIPCION = @DESCRIPCION, PRECIOCOMPRA = " +
                    "@PRECIOCOMPRA, PRECIOVENTA = @PRECIOVENTA, GRAVADO = @GRAVADO WHERE ID_PRODUCTO = @ID_PRODUCTO";
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                comando.Parameters.AddWithValue("@ID_PRODUCTO", producto.Id_Producto);
                comando.Parameters.AddWithValue("@DESCRIPCION", producto.Descripcion);
                comando.Parameters.AddWithValue("@PRECIOCOMPRA", producto.Precio_compra);
                comando.Parameters.AddWithValue("@PRECIOVENTA", producto.Precio_venta);
                comando.Parameters.AddWithValue("@GRAVADO", producto.Gravado);

                try
                {
                    conexion.Open();
                    filasAfectadas = comando.ExecuteNonQuery();
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
            }

            return filasAfectadas;
        }

        //este metodo sirve para eliminar un cliente pero sin llamar a un SP
        public int EliminarProducto(EntidadesProductos producto)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM PRODUCTOS";
            sentencia = string.Format("{0} WHERE ID_PRODUCTO ={1}", sentencia, producto.Id_Producto);
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                afectado = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception) { throw; }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return afectado;
        }

        public int Modificar(EntidadesProductos producto)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE PRODUCTOS SET DESCRIPCION=@DESCRIPCION,PRECIOCOMPRA=@PRECIOCOMPRA,PRECIOVENTA=@PRECIOVENTA,GRAVADO=@GRAVADO WHERE ID_PRODUCTO=@ID_PRODUCTO";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_PRODUCTO", producto.Id_Producto);
            comando.Parameters.AddWithValue("@DESCRIPCION", producto.Descripcion);
            comando.Parameters.AddWithValue("@PRECIOCOMPRA", producto.Precio_compra);
            comando.Parameters.AddWithValue("@PRECIOVENTA", producto.Precio_venta);
            comando.Parameters.AddWithValue("@GRAVADO", producto.Gravado);
            try
            {
                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception) { throw; }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return filasAfectadas;

        }//fin modificar
    }
}
