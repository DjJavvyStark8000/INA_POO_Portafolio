using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLHorarioFuncionarios
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLHorarioFuncionarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        public List<EntidadHorarioFuncionarios> llamarListarHorarioFuncionarios(string condicion = "")
        {
            List<EntidadHorarioFuncionarios> horario;
            DAHorarioFuncionarios accesarHorarioFuncionarios = new DAHorarioFuncionarios(_cadenaConexion);
            try
            {
                horario = accesarHorarioFuncionarios.ListarHorarioFuncionarios(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return horario;
        }

        // (2) metodo para llamar al a insertar horario de funcionarios
        public int LlamarInsertarHorarioFuncionarios(EntidadHorarioFuncionarios horario)
        {
            int id_horario = 0;
            DAHorarioFuncionarios unHorario = new DAHorarioFuncionarios(_cadenaConexion);
            try
            {
                id_horario = unHorario.InsertarHorarioFuncionarios(horario);
            }
            catch (Exception)
            {
                throw;
            }
            return id_horario;
        }// fin de la clase insertar

        // (3) metodo para llamar al metodo editar el horario de funcionario
        public int LlamarEditarHorarioFuncionarios(EntidadHorarioFuncionarios horario)
        {
            int filasAfectadas = 0;
            DAHorarioFuncionarios unHorario = new DAHorarioFuncionarios(_cadenaConexion);
            try
            {
                filasAfectadas = unHorario.EditarHorarioFuncionario(horario);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }

        // (4) metodo para llamar al metodo eliminar un horario de un funcionario
        public int LlamarEliminarHorarioFuncionario(int horarioid)
        {
            int id_horario = 0;
            DAHorarioFuncionarios unHorario = new DAHorarioFuncionarios(_cadenaConexion);
            try
            {
                id_horario = unHorario.EliminarHorarioFuncionario(horarioid);
            }
            catch (Exception)
            {
                throw;
            }
            return id_horario;
        }
    }
}
