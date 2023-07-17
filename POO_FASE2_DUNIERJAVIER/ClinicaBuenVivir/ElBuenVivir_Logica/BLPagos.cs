using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Logica
{
    public class BLPagos
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public BLPagos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // (2a) metodo para llamar al metodo insertar un pago
        public int LlamarInsertarPago(EntidadPagos pago)
        {
            int id_pago = 0;
            DAPagos unPago = new DAPagos(_cadenaConexion);
            try
            {
                id_pago = unPago.InsertarPago(pago);
            }
            catch (Exception)
            {
                throw;
            }
            return id_pago;
        }// fin de la clase insertar
    }
}
