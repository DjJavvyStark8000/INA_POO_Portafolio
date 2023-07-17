using System;
using System.Collections.Generic;
using System.Text;
using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;

namespace ElBuenVivir_Logica
{
    public class BLPaciente : Persona
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLPaciente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //listar pacientes
        // (1) llamar acceso de datos por medio de lista
        public List<EntidadPaciente> llamarListarPacientes(string condicion = "")
        {
            List<EntidadPaciente> pacientes;
            DAPaciente accesarPacientes = new DAPaciente(_cadenaConexion);
            try
            {
               pacientes = accesarPacientes.ListarPacientes(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return pacientes;
        }

        //metodo para llamar al metodo insertar de la capa3accesodatos
        public int LlamarMetodoInsertar(EntidadPaciente paciente)
        {
            int id_paciente = 0;
            DAPaciente unPaciente = new DAPaciente(_cadenaConexion);
            try
            {
                id_paciente = unPaciente.InsertarPaciente(paciente);
            }
            catch (Exception)
            {
                throw;
            }
            return id_paciente;
        }// fin de la clase insertar

        // (3) metodo para llamar al metodo editar pacientes
        public int LlamarEditarPaciente(EntidadPaciente paciente)
        {
            int filasAfectadas = 0;
            DAPaciente unPaciente = new DAPaciente(_cadenaConexion);
            try
            {
                filasAfectadas = unPaciente.EditarPaciente(paciente);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }
    }
}
