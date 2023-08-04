using ElBuenVivir_Entidades;
using ElBuenVivir_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Recetas : Form
    {
        private string nombreDelPaciente = "";
        private int cantidad = 0;
        private int count = -1;
        public Frm_Recetas(string nombrePaciente)
        {
            InitializeComponent();
            this.nombreDelPaciente = nombrePaciente;//obtengo el nombre del paciente
        }

        private void Frm_Recetas_Load(object sender, EventArgs e)
        {
            //datos por default en algunas casillas
            txtPaciente.Text = nombreDelPaciente;
            txtMedico.Text = VariableGlobal.userName;
            CargarListaInventario();
            string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
            txtFechaRetiro.Text = fechaActual;
            //CargarListaRecetas();
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

       
        //guadar en la base de datos
        private void btnGuardarReceta_Click(object sender, EventArgs e)
        {

        }

        //cantidad de medicamentos
        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(numericCantidad.Value);
            if (cantidad > 0)
            {
                comboMedicamentos.Enabled = true;//cuano hayan medicamentos activar
            }
            else
            {
                comboMedicamentos.Enabled = false;
            }

        }

        //agregar datos de los medicamentos a la textbox
        private void comboMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (count > 0)
            {
                var selectedItem = (EntidadInventario)comboMedicamentos.SelectedItem;
                var selectedProducto = selectedItem.Producto;

                txtDosis.Text += cantidad + " " + selectedProducto + Environment.NewLine;
            }
            count++;
        }

        public void CargarListaInventario(string condicion = "")
        {
            BLInventario logicaInventario = new BLInventario(Configuracion.getCadenaConeccion);
            List<EntidadInventario> inventario;

            try
            {
                inventario = logicaInventario.llamarListarInventario(condicion);

                if (inventario.Count > 0)
                {
                    comboMedicamentos.DataSource = inventario;
                    comboMedicamentos.DisplayMember = "Producto"; // Assuming "Producto" is the property in the EntidadInventario class that holds the product name
                    comboMedicamentos.ValueMember = "Inventario_Id"; // Assuming "ID" is the property in the EntidadInventario class that holds the ID
                    comboMedicamentos.SelectedIndex = 0; // Select the first item by default
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
