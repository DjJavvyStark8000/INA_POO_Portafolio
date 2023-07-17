using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadPagos
    {
        private int pagosId;
        private decimal monto;
        private string metodoPago;

        public EntidadPagos()
        {
            // Constructor sin parámetros con datos por defecto
            this.pagosId = 0;
            this.monto = 0;
            this.metodoPago = string.Empty;
        }

        public EntidadPagos(int pagosId, decimal monto, string metodoPago)
        {
            // Constructor con parámetros
            this.pagosId = pagosId;
            this.monto = monto;
            this.metodoPago = metodoPago;
        }

        // Propiedades (getters y setters) para los atributos privados
        public int PagosId { get { return pagosId; } set { pagosId = value; } }
        public decimal Monto { get { return monto; } set { monto = value; } }
        public string MetodoPago { get { return metodoPago; } set { metodoPago = value; } }
    }
}
