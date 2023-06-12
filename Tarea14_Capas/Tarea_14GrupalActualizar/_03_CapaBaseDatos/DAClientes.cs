using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Entidades;
using System.Linq;

namespace _03_CapaBaseDatos
{
    public class DAClientes
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DAClientes(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }


        //Metodos insertar
        public int InsertarCliente(EntidadClientes cliente)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string instruccion = "INSERT INTO CLIENTES (NOMBRE, TELEFONO, DIRECCION) " +
                "VALUES (@NOMBRE, @TELEFONO, @DIRECCION); SELECT SCOPE_IDENTITY()";
            comando.Parameters.AddWithValue("@NOMBRE", cliente.Nombre);
            comando.Parameters.AddWithValue("@TELEFONO", cliente.Telefono);
            comando.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);
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
        public List<EntidadClientes> ListaClientes(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<EntidadClientes> listaClientes;

            string instruccionDB = "SELECT ID_CLIENTE, NOMBRE, TELEFONO, DIRECCION FROM CLIENTES";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(instruccionDB, conexion);
                adapter.Fill(elDataSet, "CLIENTES");
                listaClientes = (from DataRow unaFila in elDataSet.Tables["CLIENTES"].Rows
                                 select new EntidadClientes()
                                 {
                                     Id_Cliente = (int) unaFila[0],
                                     Nombre = unaFila[1].ToString(),
                                     Telefono = unaFila[2].ToString(),
                                     Direccion = unaFila[3].ToString()
                                 }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return listaClientes;
        }

        //info obtenida de consulta se almacena en dataReader
        public EntidadClientes ObtenerCliente(int id)
        {
            EntidadClientes cliente = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_CLIENTE,NOMBRE,TELEFONO,DIRECCION FROM CLIENTES WHERE ID_CLIENTE = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    cliente = new EntidadClientes();
                    dataReader.Read();
                    cliente.Id_Cliente = dataReader.GetInt32(0);
                    cliente.Nombre = dataReader.GetString(1);
                    cliente.Telefono = dataReader.GetString(2);
                    cliente.Direccion = dataReader.GetString(3);
                   // cliente.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception) { throw; }
            return cliente;
        }


    }
}
