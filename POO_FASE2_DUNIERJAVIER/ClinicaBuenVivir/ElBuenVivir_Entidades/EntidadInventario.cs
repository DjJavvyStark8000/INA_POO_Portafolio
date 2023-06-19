using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadInventario
    {
        private int inventario_id;
        private string producto;
        private int cantidad;
        private DateTime caducidad;
        private decimal precio_unitario;
        private string proveedor;

        public EntidadInventario(int inventario_id, string producto, int cantidad, DateTime caducidad, decimal precio_unitario, string proveedor)
        {
            this.inventario_id = inventario_id;
            this.producto = producto;
            this.cantidad = cantidad;
            this.caducidad = caducidad;
            this.precio_unitario = precio_unitario;
            this.proveedor = proveedor;
        }

        public EntidadInventario()
        {
            inventario_id = 0;
            producto = "";
            cantidad = 0;
            caducidad = DateTime.MinValue;
            precio_unitario = 0;
            proveedor = "";
        }

        public int Inventario_Id { get => inventario_id; set => inventario_id = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Caducidad { get => caducidad; set => caducidad = value; }
        public decimal Precio_Unitario { get => precio_unitario; set => precio_unitario = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
    }
}
