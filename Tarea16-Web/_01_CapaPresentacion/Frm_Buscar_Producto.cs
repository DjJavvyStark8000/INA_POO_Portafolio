using _02_CapaLogica;
using _03_CapaBaseDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _01_CapaPresentacion
{
    public partial class Frm_Buscar_Producto : Form
    {

        public event EventHandler Aceptar;//evento ************************************
        int globlal_id_producto;
        public Frm_Buscar_Producto()
        {
            InitializeComponent();
        }

        //Cargar los datos
        public void CargarListaProductos(string condicion = "")
        {
            BLProductos logicaBuscar = new BLProductos(Configuracion.getCadenaConeccion);
            List<EntidadesProductos> listarProductos;
            try
            {
                listarProductos = logicaBuscar.llamarListaProductos(condicion);
                if (listarProductos.Count > 0)
                {
                    dgrProductos.DataSource = listarProductos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Frm_Buscar_Produto_Load(object sender, EventArgs e)
        {
            CargarListaProductos();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtBuscarProducto.Text))
                {
                    condicion = string.Format("Descripcion LIKE '%{0}%'", txtBuscarProducto.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir algo antes de buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscarProducto.Focus();
                }
                CargarListaProductos(condicion);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptarProducto_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void Seleccionar()
        {       
            if (dgrProductos.SelectedRows.Count > 0)
            {
                globlal_id_producto = (int)dgrProductos.SelectedRows[0].Cells[0].Value;
                Aceptar(globlal_id_producto, null);
                Close();
            }
        }

        private void dgrProductos_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }
    }
}
