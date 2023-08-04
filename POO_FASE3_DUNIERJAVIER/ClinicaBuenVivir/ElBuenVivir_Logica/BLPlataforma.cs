using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLPlataforma
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLPlataforma(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        //public List<EntidadEspecialidad> llamarListarEspecialidades(string condicion = "")
        //{
        //    List<EntidadEspecialidad> especialidades;
        //    DAEspecialidad accesarEspecialidad = new DAEspecialidad(_cadenaConexion);
        //    try
        //    {
        //        especialidades = accesarEspecialidad.ListarEspecialidades(condicion);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return especialidades;
        //}

        // (2) metodo para llamar al metodo insertar ESPECIALIDADES  
        public int LlamarInsertarDatosPlataforma(EntidadPlataforma datosPlataforma)
        {
            int id_plataforma = 0;
            DAPlataforma unDatoPlataforma = new DAPlataforma(_cadenaConexion);
            try
            {
                id_plataforma = unDatoPlataforma.InsertarDatosPlataforma(datosPlataforma);
            }
            catch (Exception)
            {
                throw;
            }
            return id_plataforma;
        }// fin de la clase insertar

        // (4) metodo para llamar al metodo eliminar plataforma
        public int LlamarEliminarPlataforma(int plataforma)
        {
            int id_plataforma = 0;
            DAPlataforma unaPlataforma = new DAPlataforma(_cadenaConexion);
            try
            {
                id_plataforma = unaPlataforma.EliminarPlataforma(plataforma);
            }
            catch (Exception)
            {
                throw;
            }
            return id_plataforma;
        }
    }
}
