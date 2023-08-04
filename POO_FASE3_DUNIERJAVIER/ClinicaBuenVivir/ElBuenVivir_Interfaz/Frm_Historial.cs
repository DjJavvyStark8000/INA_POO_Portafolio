using ElBuenVivir_AccesoDatos;
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
        private int paciente_ID = 0;
        private string elNombreCompleto = "";
        //private int count = 0;
        private string accion = "nuevo";
       // private int cantidad = 0;
        public Frm_Historial(int idPaciente, string nombreCompleto)
        {
            InitializeComponent();
            this.paciente_ID = idPaciente;
            this.elNombreCompleto = nombreCompleto;

        }

        private void Frm_Historial_Load(object sender, EventArgs e)
        {
            CargarHistorialMedico();
            HabilitarCasillas();
            //imprimir en casillas desde plataforma
            txtNombrePaciente.Text = elNombreCompleto;
            txtIdPaciente.Text = paciente_ID.ToString();
            string fechaActual = DateTime.Now.ToString("yyyy/MM/dd");
            txtFechaRegistro.Text = fechaActual;
        }

        // (0A) Carga la lista datagridview
        public void CargarHistorialMedico(string condicion = "")
        {

            BLHistorial logicaHistorial = new BLHistorial(Configuracion.getCadenaConeccion);
            List<EntidadHistorial> historial;
            try
            {
                condicion = $"HISTORIAL_ID = {paciente_ID}";
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
   

        //Salir de aqui
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //craer objeto historial
        private EntidadHistorial CrearHistorial()
        {
            EntidadHistorial unHistorial = new EntidadHistorial();
            if (accion == "nuevo")
            {//todas la casillas forman el objeto
                unHistorial.PacienteId = Convert.ToInt32(txtIdPaciente.Text);
                unHistorial.FechaRegistro = txtFechaRegistro.Text;
                unHistorial.Antecedentes = txtAntecedentes.Text;
                unHistorial.Medicamentos = txtListaMedicamentos.Text;
                unHistorial.Diagnosticos = txtDiagnostico.Text;
                unHistorial.ResultadoPruebas = txtResultadoPruebas.Text;
                unHistorial.Observaciones = txtObservaciones.Text;
            }
            else if (accion == "editar")
            {//todas las casillas forman el objeto


            }
            return unHistorial;
        }

        //guardar en la base de datos un historial medico
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadHistorial unHistorial = new EntidadHistorial();//objeto
            BLHistorial logicaHistorial = new BLHistorial(Configuracion.getCadenaConeccion);//conexion
            try
            {
                if (VerificarCampos())//si no tiene datos                  
                {
                    MessageBox.Show("ooops! Faltan datos favor revisar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (accion == "nuevo")
                    {
                        unHistorial = CrearHistorial();//crea objeto
                        int resultado = logicaHistorial.LlamarInsertarHistorial(unHistorial);
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardar.Enabled = false;
                        InhabilitarCasillas();//datos enviados inhabilitar
                        LimpiarCasillas();
                    }
                    else if (accion == "editar")
                    {
                        unHistorial = CrearHistorial();//crea objeto
                        int resultado = logicaHistorial.LlamarInsertarHistorial(unHistorial);
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardar.Enabled = false;
                        InhabilitarCasillas();//datos enviados inhabilitar
                        LimpiarCasillas();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //checar si campos estan en uso o no
        public bool VerificarCampos()
        {
            bool tienenDatos = false; // Assume no fields have data initially
            if (string.IsNullOrEmpty(txtDiagnostico.Text))
            {

                tienenDatos = true; // Set tienenDatos to true if any field has data
            }

            return tienenDatos;
        }
        //activar casillas
        private void HabilitarCasillas()
        {
            if (!txtAntecedentes.Enabled &&
                !txtResultadoPruebas.Enabled &&
                !txtDiagnostico.Enabled &&
                !txtObservaciones.Enabled)
            {
                txtAntecedentes.Enabled = true;
                txtResultadoPruebas.Enabled = true;
                txtDiagnostico.Enabled = true;
                txtObservaciones.Enabled = true;
            }
        }

        private void InhabilitarCasillas()
        {
            if (txtAntecedentes.Enabled &&
                txtResultadoPruebas.Enabled &&
                txtDiagnostico.Enabled &&
                txtObservaciones.Enabled)
            {
                txtAntecedentes.Enabled = false;
                txtResultadoPruebas.Enabled = false;
                txtDiagnostico.Enabled = false;
                txtObservaciones.Enabled = false;
            }
        }

        //Limpiar casillas
        private void LimpiarCasillas()
        {
            txtAntecedentes.Text = string.Empty;
            txtResultadoPruebas.Text = string.Empty;
            txtDiagnostico.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
        }

        //No vamos a editar por ahora creo que ya hay suficientes ejemplos
        private void btnEditarHistorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Editar no esta disponible", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Hacer una receta
        private void btnReceta_Click(object sender, EventArgs e)
        {
            string elnombrePaciente = txtNombrePaciente.Text;
            Frm_Recetas crearReceta = new Frm_Recetas(elnombrePaciente);
            crearReceta.Owner = this;//define quien el el padre
            crearReceta.ShowDialog();

        }
    }
}
