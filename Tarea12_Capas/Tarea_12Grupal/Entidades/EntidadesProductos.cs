using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    internal class EntidadesProductos
    {
        private int id_producto;
        private string description;
        private double precio_compra;
        private double precio_venta;
        private char gravado;


        public EntidadesProductos()
        {
            id_producto = 0;
            description = "";
            precio_compra = 0.0;
            precio_venta = 0.0;
            gravado = 'n';
        }
        public EntidadesProductos(int id_producto, string description, double precio_compra, double precio_venta, char gravado)
        {
            this.id_producto = id_producto;
            this.description = description;
            this.precio_compra = precio_compra;
            this.precio_venta = precio_venta;
            this.gravado = gravado;
        }

        public int Id_Producto { get{ return id_producto; }set { id_producto = value; } }
        public string Description { get { return description; } set { description = value; } }
        public double Precio_compra { get { return precio_compra; }set { precio_compra = value; } }
        public double Precio_venta { get { return precio_venta;} set { precio_venta = value; } }
        public char Gravado { get {  return gravado; } set {  gravado = value; } }
    }
}
