using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    internal class EntidadDetalle_Factura
    {
        public int id_factura;
        public int id_producto;
        public int cantidad;


        public EntidadDetalle_Factura()
        {
            id_factura = 0;
            id_producto = 0;
            cantidad = 0;
        }
        public EntidadDetalle_Factura(int id_factura, int id_producto, int cantidad)
        {
            this.id_factura = id_factura;
            this.id_producto = id_producto;
            this.cantidad = cantidad;
        }

        public int Id_Factura { get { return id_factura; } set { id_factura = value; } }
        public int Id_Producto { get {  return id_producto; } set { id_producto = value; } }
        public int Cantidad { get {  return cantidad; } set {  cantidad = value; } }
    }
}
