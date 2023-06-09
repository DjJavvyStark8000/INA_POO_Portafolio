﻿using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLInventario
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLInventario(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (1) llamar acceso de datos por medio de lista
        public List<EntidadInventario> llamarListarInventario(string condicion = "")
        {
            List<EntidadInventario> inventario;
            DAInventario accesarInventario = new DAInventario(_cadenaConexion);
            try
            {
                inventario = accesarInventario.ListarInventario(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return inventario;
        }
    }
}
