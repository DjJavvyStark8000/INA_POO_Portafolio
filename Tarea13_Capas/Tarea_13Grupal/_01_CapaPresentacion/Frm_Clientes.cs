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
    public partial class Frm_Clientes : Form
    {


        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {

        }

        //crea un objeto con los datos ingresados en las casillas de texto
        public EntidadClientes generaCliente()
        {
            EntidadClientes unCliente = new EntidadClientes();
            unCliente.Nombre = txtNombre.Text;
            unCliente.Telefono = txtTelefono.Text;
            unCliente.Direccion = txtDireccion.Text;

            return unCliente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadClientes UnCliente = new EntidadClientes();
            BLCliente logicaCliente = new BLCliente(Configuracion.getCadenaConeccion);
            int resultado;
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtTelefono.Text) | string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("ooops! Faltan datos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UnCliente = generaCliente();
                    resultado = logicaCliente.LlamarMetodoInsertar(UnCliente);
                    LimpiarCasillas();
                    MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        public void LimpiarCasillas()
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
