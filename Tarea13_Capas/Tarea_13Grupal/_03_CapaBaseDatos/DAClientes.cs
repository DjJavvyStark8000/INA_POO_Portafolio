using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entidades;

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


        //Metodos
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

      
    }
}
