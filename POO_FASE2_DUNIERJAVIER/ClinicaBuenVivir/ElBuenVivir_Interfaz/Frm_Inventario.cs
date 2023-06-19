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
    public partial class Frm_Inventario : Form
    {
        public Frm_Inventario()
        {
            InitializeComponent();
        }

        private void Frm_Inventario_Load(object sender, EventArgs e)
        {
            CargarListaInventario();
        }

        // (0A) Carga la lista datagridview
        public void CargarListaInventario(string condicion = "")
        {

            BLInventario logicaInventario = new BLInventario(Configuracion.getCadenaConeccion);
            List<EntidadInventario> inventario;
            try
            {
                inventario = logicaInventario.llamarListarInventario(condicion);
                if (inventario.Count > 0)
                {
                    dgrListaMedicamentos.DataSource = inventario;


                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
