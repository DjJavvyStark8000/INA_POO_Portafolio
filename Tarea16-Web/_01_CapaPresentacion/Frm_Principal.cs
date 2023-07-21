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


    public partial class Frm_Principal : Form
    {

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Clientes menuCliente = new Frm_Clientes();
            menuCliente.MdiParent = this;
            menuCliente.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Productos menuProducto = new Frm_Productos();
            menuProducto.MdiParent = this;
            menuProducto.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Facturacion menuFacturacion = new Frm_Facturacion();
            menuFacturacion.MdiParent = this;
            menuFacturacion.Show();
        }
    }
}
