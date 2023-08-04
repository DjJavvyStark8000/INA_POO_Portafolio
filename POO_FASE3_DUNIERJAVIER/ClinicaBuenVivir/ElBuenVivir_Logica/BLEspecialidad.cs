using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;



namespace ElBuenVivir_Logica
{
    public class BLEspecialidad
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLEspecialidad(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        public List<EntidadEspecialidad> llamarListarEspecialidades(string condicion = "")
        {
            List<EntidadEspecialidad> especialidades;
            DAEspecialidad accesarEspecialidad = new DAEspecialidad(_cadenaConexion);
            try
            {
                especialidades = accesarEspecialidad.ListarEspecialidades(condicion);
            }
            catch (Exception) 
            {
                throw;
            }
            return especialidades;
        }

        // (2) metodo para llamar al metodo insertar ESPECIALIDADES  
        public int LlamarInsertarEspecialidad(EntidadEspecialidad especialidad)
        {
            int id_especial = 0;
            DAEspecialidad unaEspecialidad = new DAEspecialidad(_cadenaConexion);
            try
            {
                id_especial = unaEspecialidad.InsertarEspecialidad(especialidad);
            }
            catch (Exception)
            {
                throw;
            }
            return id_especial;
        }// fin de la clase insertar

        // (3) metodo para llamar al metodo editar ESPECIALIDADES  
        public int LlamarEditarEspecialidad(EntidadEspecialidad especialidad)
        {
            int filasAfectadas = 0;
            DAEspecialidad unaEspecialidad = new DAEspecialidad(_cadenaConexion);
            try
            {
                filasAfectadas = unaEspecialidad.EditarEspecialidad(especialidad);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }

        // (4) metodo para llamar al metodo eliminar ESPECIALIDADES  
        public int LlamarEliminarEspecialidad(int especialidad)
        {
            int id_especial = 0;
            DAEspecialidad unaEspecialidad = new DAEspecialidad(_cadenaConexion);
            try
            {
                id_especial = unaEspecialidad.EliminarEspecialidad(especialidad);
            }
            catch (Exception)
            {
                throw;
            }
            return id_especial;
        }

       
    }
}
