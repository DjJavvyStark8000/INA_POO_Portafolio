using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EntidadesProductos
    {
        private int id_producto;
        private string description;
        private float precio_compra;
        private float precio_venta;
        private string gravado;
        private bool existe;


        public EntidadesProductos()
        {
            id_producto = 0;
            description = "";
            precio_compra = 0;
            precio_venta = 0;
            gravado = "";
            existe = false;
        }
        public EntidadesProductos(int id_producto, string description, float precio_compra, float precio_venta, string gravado, bool existe)
        {
            this.id_producto = id_producto;
            this.description = description;
            this.precio_compra = precio_compra;
            this.precio_venta = precio_venta;
            this.gravado = gravado;
            this.existe = existe;
        }

        public int Id_Producto { get{ return id_producto; }set { id_producto = value; } }
        public string Descripcion { get { return description; } set { description = value; } }
        public float Precio_compra { get { return precio_compra; }set { precio_compra = value; } }
        public float Precio_venta { get { return precio_venta;} set { precio_venta = value; } }
        public string Gravado { get {  return gravado; } set {  gravado = value; } }
        public bool Existe { get { return existe; } set {  existe = value; } }
    }
}
