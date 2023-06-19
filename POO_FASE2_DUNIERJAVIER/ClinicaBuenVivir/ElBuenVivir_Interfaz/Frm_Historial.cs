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
    public partial class Frm_Historial : Form
    {
        public Frm_Historial()
        {
            InitializeComponent();
        }

        private void Frm_Historial_Load(object sender, EventArgs e)
        {
            CargarHistorialMedico();
        }

        // (0A) Carga la lista datagridview
        public void CargarHistorialMedico(string condicion = "")
        {

            BLHistorial logicaHistorial = new BLHistorial(Configuracion.getCadenaConeccion);
            List<EntidadHistorial> historial;
            try
            {
                historial = logicaHistorial.llamarListarHistorial(condicion);
                if (historial.Count > 0)
                {
                    dgrHistorial.DataSource = historial;


                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
