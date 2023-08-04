using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLRecetas
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLRecetas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        public List<EntidadRecetas> llamarListarReceta(string condicion = "")
        {
            List<EntidadRecetas> receta;
            DARecetas accesarReceta = new DARecetas(_cadenaConexion);
            try
            {
                receta = accesarReceta.ListarRecetas(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return receta;
        }
    }
}
