using _02_CapaLogica;
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
    public partial class Frm_Buscar : Form
    {

        public event EventHandler Aceptar;//evento ************************************
        int globlal_id_cliente;

        public Frm_Buscar()
        {
            InitializeComponent();
        }

        //Cargar los datos
        public void CargarListaClientes(string condicion = "")
        {
            BLCliente logicaBuscar = new BLCliente(Configuracion.getCadenaConeccion);
            List<EntidadClientes> listarClientes;
            try
            {
                listarClientes = logicaBuscar.llamarListaClientes(condicion);
                if (listarClientes.Count > 0)
                {
                    dgrClientes.DataSource = listarClientes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Buscar_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtBuscarCliente.Text))
                {
                    condicion = string.Format("Nombre LIKE '%{0}%'", txtBuscarCliente.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir algo antes de buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscarCliente.Focus();
                }
                CargarListaClientes(condicion);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void Seleccionar()
        {
           
            if (dgrClientes.SelectedRows.Count > 0)
            {              
                globlal_id_cliente = (int)dgrClientes.SelectedRows[0].Cells[0].Value;
                Aceptar(globlal_id_cliente, null);
                Close();
            }
        }

        private void dgrClientes_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }

        private void tempmessage() {
            MessageBox.Show("OK");
        }
    }
}
