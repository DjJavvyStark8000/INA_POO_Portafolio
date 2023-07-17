using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLFuncionarios
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLFuncionarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (***************) llamar acceso de datos por medio de lista alos funcionarios
        public List<EntidadFuncionario> llamarListarFuncionarios(string condicion = "")
        {
            List<EntidadFuncionario> funcionario;
            DAFuncionarios accesarFuncionario = new DAFuncionarios(_cadenaConexion);
            try
            {
                funcionario = accesarFuncionario.ListarFuncionarios(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return funcionario;
        }

        // llamar medicos unicamente
        public List<EntidadFuncionario> llamarListarMedicos(string condicion = "")
        {
            List<EntidadFuncionario> unMedico;
            DAFuncionarios accesarMedico = new DAFuncionarios(_cadenaConexion);
            try
            {
                unMedico = accesarMedico.ListarMedicos(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return unMedico;
        }

        //*************************************************************************
        // ****llamar lista especialidades para comboBox***************************
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

        // (2) metodo para llamar al metodo insertar un funcionario
        public int LlamarInsertarFuncionario(EntidadFuncionario funcionario)
        {
            int id_especial = 0;
            DAFuncionarios unFuncionario = new DAFuncionarios(_cadenaConexion);
            try
            {
                id_especial = unFuncionario.InsertarFuncionario(funcionario);
            }
            catch (Exception)
            {
                throw;
            }
            return id_especial;
        }// fin de la clase insertar

        // (3) metodo para llamar al metodo editar el FUNCIONARIOS
        public int LlamarEditarFuncinario(EntidadFuncionario funcinario)
        {
            int filasAfectadas = 0;
            DAFuncionarios unFuncionario = new DAFuncionarios(_cadenaConexion);
            try
            {
                filasAfectadas = unFuncionario.EditarFuncionario(funcinario);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }

        // (4) metodo para llamar al metodo eliminar funcionarios
        public int LlamarEliminarFuncionario(int funcionario)
        {
            int id_funcionario = 0;
            DAFuncionarios unFuncionario = new DAFuncionarios(_cadenaConexion);
            try
            {
                id_funcionario = unFuncionario.EliminarFuncionario(funcionario); 
            }
            catch (Exception)
            {
                throw;
            }
            return id_funcionario;
        }
    }
}
