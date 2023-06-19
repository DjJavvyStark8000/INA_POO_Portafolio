using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ElBuenVivir_Logica;
using ElBuenVivir_Entidades;
using System.Runtime.Intrinsics.X86;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Pacientes : Form
    {
        public Frm_Pacientes()
        {
            InitializeComponent();
        }

        //Mensaje temporal
        private void btnAgregarImagen_Click(object sender, EventArgs e)//mensaje de agregar imagen
        {
            MessageBox.Show("Servicio no disponible", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalirNPaciente_Click(object sender, EventArgs e)
        {
            Close();
        }

        //crear el objeto paciente
        public EntidadPaciente crearPaciente()
        {
            EntidadPaciente unPaciente = new EntidadPaciente();
            int aux = 0;
            if (int.TryParse(txtID.Text, out aux))
                unPaciente.Identificacion = aux;

            unPaciente.Tipo_id = comboTipoID.SelectedText.ToString();
            unPaciente.Nombre = txtNombre.Text;
            unPaciente.Apellidos = $"{txtApellido1.Text} + {txtApellido2.Text}";
            //unPaciente.FechaNacimiento = dateNacimiento.Value.ToString();
            if (radioHombre.Checked)
                unPaciente.Genero = "M";
            if (radioMujer.Checked)
                unPaciente.Genero = "F";

            unPaciente.Nacionalidad = txtNacionalidad.Text;
            unPaciente.Correo = txtCorreo.Text;
            if (int.TryParse(txtTelefono.Text, out aux))
                unPaciente.Telefono = aux;

            unPaciente.Ciudad = comboCiudades.SelectedText.ToString();
            unPaciente.Provincia = comboProvincias.SelectedText.ToString();
            unPaciente.DetalleDireccion = txtDetallesDireccion.Text;
            if (radioSoltero.Checked)
                unPaciente.EstadoCivil = "Soltero/a";
            if (radioCasado.Checked)
                unPaciente.EstadoCivil = "Casado/a";
            if (radioUnion.Checked)
                unPaciente.EstadoCivil = "Unión Libre";

            if (radioLaborandoSi.Checked)
                unPaciente.Laborando = "S";
            if (radioLaborandoNo.Checked)
                unPaciente.Laborando = "N";
            if (int.TryParse(txtEmergencia.Text, out aux))
                unPaciente.NumeroEmergencia = aux;

            unPaciente.Guardian = txtGuardian.Text;
            if (radioAseguradoSi.Checked)
                unPaciente.Asegurado = "S";
            if (radioAseguradoNo.Checked)
                unPaciente.Asegurado = "N";

            return unPaciente;
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            EntidadPaciente unPaciente = new EntidadPaciente();
            BLPaciente logicaPaciente = new BLPaciente(Configuracion.getCadenaConeccion);
            int resultado;
            try
            {
                if (string.IsNullOrEmpty(txtID.Text) |
                    comboTipoID.SelectedIndex == -1 |
                    string.IsNullOrEmpty(txtNombre.Text) |
                    string.IsNullOrEmpty(txtApellido1.Text) |
                    string.IsNullOrEmpty(txtApellido2.Text) |
                    dateNacimiento.Value == DateTimePicker.MinimumDateTime |
                    !radioHombre.Checked && !radioMujer.Checked |
                    string.IsNullOrEmpty(txtNacionalidad.Text) |
                    string.IsNullOrEmpty(txtCorreo.Text) |
                    string.IsNullOrEmpty(txtTelefono.Text) |
                    comboCiudades.SelectedIndex == -1 |
                    comboProvincias.SelectedIndex == -1 |
                    string.IsNullOrEmpty(txtDetallesDireccion.Text) |
                    !radioSoltero.Checked && !radioCasado.Checked && !radioUnion.Checked |
                    !radioLaborandoSi.Checked && !radioLaborandoNo.Checked |
                    string.IsNullOrEmpty(txtEmergencia.Text) |
                    string.IsNullOrEmpty(txtGuardian.Text) |
                    !radioAseguradoSi.Checked && !radioAseguradoNo.Checked
                    )
                {
                    MessageBox.Show("ooops! Faltan datos favor revisar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ShowVariableInfo();
                    unPaciente = crearPaciente();
                    resultado = logicaPaciente.LlamarMetodoInsertar(unPaciente);

                    limpiador();
                    MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void limpiador()
        {
            // limpieza de formulario
            txtID.Text = string.Empty;
            comboTipoID.SelectedIndex = -1;
            txtNombre.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            dateNacimiento.Value = DateTimePicker.MinimumDateTime;
            radioHombre.Checked = false;
            radioMujer.Checked = false;
            txtNacionalidad.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            comboCiudades.SelectedIndex = -1;
            comboProvincias.SelectedIndex = -1;
            txtDetallesDireccion.Text = string.Empty;
            radioSoltero.Checked = false;
            radioCasado.Checked = false;
            radioUnion.Checked = false;
            radioLaborandoSi.Checked = false;
            radioLaborandoNo.Checked = false;
            txtEmergencia.Text = string.Empty;
            txtGuardian.Text = string.Empty;
            radioAseguradoSi.Checked = false;
            radioAseguradoNo.Checked = false;
        }

        private void ShowVariableInfo()
        {
            string message = "Variable Information:\n";
            message += "txtID.Text: " + txtID.Text + "\n";
            message += "comboTipoID.SelectedIndex: " + comboTipoID.SelectedText.ToString() + "\n";
            message += "txtNombre.Text: " + txtNombre.Text + "\n";
            message += "txtApellido1.Text: " + txtApellido1.Text + "\n";
            message += "txtApellido2.Text: " + txtApellido2.Text + "\n";
            message += "dateNacimiento.Value: " + dateNacimiento.Value.ToString() + "\n";
            message += "radioHombre.Checked: " + radioHombre.Checked + "\n";
            message += "radioMujer.Checked: " + radioMujer.Checked + "\n";
            message += "txtNacionalidad.Text: " + txtNacionalidad.Text + "\n";
            message += "txtCorreo.Text: " + txtCorreo.Text + "\n";
            message += "txtTelefono.Text: " + txtTelefono.Text + "\n";
            message += "comboCiudades.SelectedIndex: " + comboCiudades.SelectedText.ToString() + "\n";
            message += "comboProvincias.SelectedIndex: " + comboProvincias.SelectedText.ToString() + "\n";
            message += "txtDetallesDireccion.Text: " + txtDetallesDireccion.Text + "\n";
            message += "radioSoltero.Checked: " + radioSoltero.Checked + "\n";
            message += "radioCasado.Checked: " + radioCasado.Checked + "\n";
            message += "radioUnion.Checked: " + radioUnion.Checked + "\n";
            message += "radioLaborandoSi.Checked: " + radioLaborandoSi.Checked + "\n";
            message += "radioLaborandoNo.Checked: " + radioLaborandoNo.Checked + "\n";
            message += "txtEmergencia.Text: " + txtEmergencia.Text + "\n";
            message += "txtGuardian.Text: " + txtGuardian.Text + "\n";
            message += "radioAseguradoSi.Checked: " + radioAseguradoSi.Checked + "\n";
            message += "radioAseguradoNo.Checked: " + radioAseguradoNo.Checked + "\n";

            MessageBox.Show(message);
        }

        private void Frm_AgregaPaciente_Load(object sender, EventArgs e)
        {
            CargarListaPacientes();
        }

        private void Frm_Pacientes_Load(object sender, EventArgs e)
        {
            CargarListaPacientes();
        }
        // (0A) Carga la lista datagridview
        public void CargarListaPacientes(string condicion = "")
        {

            BLPaciente logicaPacientes = new BLPaciente(Configuracion.getCadenaConeccion);
            List<EntidadPaciente> pacientes;
            try
            {
                pacientes = logicaPacientes.llamarListarPacientes(condicion);
                if (pacientes.Count > 0)
                {
                    dgrListarPacientes.DataSource = pacientes;


                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
