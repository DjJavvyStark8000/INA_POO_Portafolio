using System;
using System.Collections.Generic;
using System.Text;
using _03_CapaBaseDatos;
using Entidades;

namespace _02_CapaLogica
{
    internal class BLEncabezadoFactura
    {
        private int id_factura;
        private DateTime fecha;
        private int id_cliente;
        private double subtotal;
        private double impuesto;
        private double monto_descuento;


        public BLEncabezadoFactura()
        {
            id_factura = 0;
            fecha = DateTime.MinValue;
            id_cliente = 0;
            subtotal = 0.0;
            impuesto = 0.0;
            monto_descuento = 0.0;
        }
        public BLEncabezadoFactura(int id_factura, DateTime fecha, int id_cliente, double subtotal, double impuesto, double monto_descueno)
        {
            this.id_factura = id_factura;
            this.fecha = fecha;
            this.id_cliente = id_cliente;
            this.subtotal = subtotal;
            this.impuesto = impuesto;
            this.monto_descuento = monto_descueno;
        }

        public int Id_factura { get { return id_factura; } set { id_factura = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int Id_cliente { get { return id_cliente; } set { id_cliente = value; } }
        public double Subtotal { get { return subtotal; } set { subtotal = value; } }
        public double Impuesto { get { return impuesto; } set { impuesto = value; } }
        public double Monto_descuento
        {
            get { return monto_descuento; }
            set { monto_descuento = value; }
        }
    }
}
