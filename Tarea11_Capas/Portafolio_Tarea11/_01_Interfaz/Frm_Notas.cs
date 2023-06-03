using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace _01_Interfaz
{
    public partial class Frm_Notas : Form
    {


        public Frm_Notas()
        {
            InitializeComponent();
        }

        private void Frm_Notas_Load(object sender, EventArgs e)
        {

        }

        private async void convertirAmarillo()
        {
            lblResultado.BackColor = Color.Yellow;
            lblResultado.Text = string.Empty;
            await Task.Delay(2000);
            lblResultado.BackColor = Color.White;
        }

        private void btnVerResultado_Click(object sender, EventArgs e)
        {
            if (listNotas.Items.Count > 0)
            {
                double totalSumaNotas = sumaNotas();
                ClsPromedio elPromedio = new ClsPromedio();

                if (listNotas.Items.Count > 0)
                {
                    double resultado = elPromedio.calculaPromedio(totalSumaNotas, listNotas.Items.Count);
                    elPromedio.calculaAprobReprob(resultado); // aprob or not
                    string coloR = elPromedio.Color;
                    string condiCion = elPromedio.Condicion;
                    lblResultado.Text = $"{resultado} {condiCion}";
                    Color color = Color.FromName(coloR);
                    lblResultado.BackColor = color;
                }
                else
                {
                    lblResultado.Text = "No hay notas";
                    lblResultado.BackColor = Color.White;
                }
            }
        }


        private double sumaNotas()
        {
            double laSuma = 0;

            if (listNotas.Items.Count > 0)
            {
                foreach (ListViewItem item in listNotas.Items)
                {
                    string notaText = item.SubItems[0].Text; 

                    if (double.TryParse(notaText, out double notaValue))
                    {
                        laSuma += notaValue;
                    }
                }
            }

            return laSuma;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string unaNota = txtDigitaNota.Text;

            // Verificaciones 
            if (string.IsNullOrEmpty(unaNota))
            {
                MessageBox.Show("Por favor, ingrese una nota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!double.TryParse(unaNota, out double nota))
            {
                MessageBox.Show("La nota debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (nota < 0 || nota > 100)
            {
                MessageBox.Show("La nota debe estar entre 0 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar los valores a la lista
            ListViewItem item = new ListViewItem(unaNota);
            listNotas.Items.Add(item);
            txtDigitaNota.Text = string.Empty;//linpia box
            txtDigitaNota.Focus();//enfoca para seguir insertando valores
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //escucha por cambios en el  index
        private void listNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listNotas.SelectedItems.Count > 0)
            {
                string selectedNote = listNotas.SelectedItems[0].Text;
                txtSeleccion.Text = selectedNote;
            }
        }

        //Eliminar y limpiar
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (listNotas.SelectedItems.Count > 0)//tiene valores
            {
                ListViewItem selectedItem = listNotas.SelectedItems[0];
                listNotas.Items.Remove(selectedItem);
                selectedItem.Remove();
                txtSeleccion.Text = string.Empty;
                convertirAmarillo();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una nota para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listNotas.Items.Clear();
            txtSeleccion.Text = string.Empty;
            txtDigitaNota.Text = string.Empty;
            convertirAmarillo();
        }
    }
}
