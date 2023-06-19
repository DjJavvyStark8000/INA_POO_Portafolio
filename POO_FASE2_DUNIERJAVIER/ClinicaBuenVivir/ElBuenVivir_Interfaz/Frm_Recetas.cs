using ElBuenVivir_Entidades;
using ElBuenVivir_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Recetas : Form
    {
        public Frm_Recetas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Recetas_Load(object sender, EventArgs e)
        {
            CargarListaRecetas();
        }
        // (0A) Carga la lista datagridview
        public void CargarListaRecetas(string condicion = "")
        {

            BLRecetas logicaReceta = new BLRecetas(Configuracion.getCadenaConeccion);
            List<EntidadRecetas> recetas;
            try
            {
                recetas = logicaReceta.llamarListarReceta(condicion);
                if (recetas.Count > 0)
                {
                    dgrListarReceta.DataSource = recetas;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgrListarReceta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
