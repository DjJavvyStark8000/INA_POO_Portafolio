using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _02_CapaLogica;
using Entidades;

namespace _01_CapaPresentacion
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
        }

        //crea un objeto con los datos ingresados en las casillas de texto
        public EntidadesProductos generaProducto()
        {
            EntidadesProductos unProducto = new EntidadesProductos();
            double aux = 0.0;
            unProducto.Descripcion = txtDescripcion.Text;
            if (Double.TryParse(txtPrecioCompra.Text, out aux))
            {
                unProducto.Precio_compra = aux;
            }
            if (Double.TryParse(txtPrecioVenta.Text, out aux))
            {
                unProducto.Precio_venta = aux;
            }
            if (!string.IsNullOrEmpty(txtGravado.Text))
            {
                unProducto.Gravado = txtGravado.Text[0]; // Assigning the first character
            }

            return unProducto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadesProductos unProducto = new EntidadesProductos();
            BLProductos logicaProducto = new BLProductos(Configuracion.getCadenaConeccion);
            int resultado;
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text) | string.IsNullOrEmpty(txtPrecioCompra.Text) | string.IsNullOrEmpty(txtPrecioVenta.Text) | string.IsNullOrEmpty(txtGravado.Text))
                {
                    MessageBox.Show("ooops! Faltan datos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    unProducto = generaProducto();
                    resultado = logicaProducto.LlamarMetodoInsertar(unProducto);
                    LimpiarCasillas();
                    MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Productos_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        public void LimpiarCasillas()
        {
            txtIDProductos.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtGravado.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
