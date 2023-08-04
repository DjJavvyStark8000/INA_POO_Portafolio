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
using System.Text.RegularExpressions;
using System.Linq;
using ElBuenVivir_AccesoDatos;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Pacientes : Form
    {
        private static int identificacion = 0;
        private static int elTelefono = 0;
        private static int elTelefonoEmergencia = 0;
        private string accion = "nuevo";
        public Frm_Pacientes()
        {
            InitializeComponent();
        }

        //validadcion identificacion
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out identificacion) || identificacion < 0)
            {
                txtID.Text = "";
                lblSoloNum.Visible = true;

            }
            else { lblSoloNum.Visible = false; }
        }
        //validadacion telefono
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTelefono.Text, out elTelefono) || elTelefono < 0)
            {
                txtTelefono.Text = "";
                lblSoloNum2.Visible = true;
            }
            else { lblSoloNum2.Visible = false; }
        }
        //validadacion telefono emergencia
        private void txtEmergencia_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTelefono.Text, out elTelefonoEmergencia) || elTelefonoEmergencia < 0)
            {
                txtEmergencia.Text = "";
                lblSoloNum3.Visible = true;
            }
            else { lblSoloNum3.Visible = false; }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (RevisarCorreo(txtCorreo.Text))
            {
                lblValidarCorreo.ForeColor = Color.Black;
            }
            else
            {
                lblValidarCorreo.ForeColor = Color.Red;
            }
        }
        //validar correo con REGEX
        public static bool RevisarCorreo(string correo)
        {
            //Patron de Regular expression 
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Crear objeto Regex
            Regex regex = new Regex(pattern);

            //verificar si hay un match
            return regex.IsMatch(correo);
        }

        //Cargar formularil
        private void Frm_Pacientes_Load(object sender, EventArgs e)
        {
            LimpiarForm();
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

        //crear el objeto paciente
        public EntidadPaciente CrearPaciente()
        {
            EntidadPaciente unPaciente = new EntidadPaciente();
            BLHistorial logicaHistorial = new BLHistorial(Configuracion.getCadenaConeccion);

            if (accion == "nuevo" || accion == "editar")
            {
                int aux = 0;
                unPaciente.Identificacion = int.TryParse(txtID.Text, out aux) ? aux : unPaciente.Identificacion;
                unPaciente.Tipo_id = comboTipoID.SelectedItem.ToString();
                unPaciente.Nombre = txtNombrePaciente.Text;
                unPaciente.Apellidos = $"{txtApellido1.Text} + {txtApellido2.Text}";
                unPaciente.FechaNacimiento = dateNacimiento.Value.ToString("yyyy/MM/dd");//cambiar formato de fecha
                unPaciente.Genero = radioHombre.Checked ? "Masculino" : "Femenino";
                unPaciente.Nacionalidad = txtNacionalidad.Text;
                unPaciente.EstadoCivil = comboEstadoCivil.SelectedItem.ToString();
                unPaciente.Laborando = radioLaborandoSi.Checked ? "Si" : "No";
                unPaciente.Asegurado = radioAseguradoSi.Checked ? "Si" : "No";
                unPaciente.Guardian = txtGuardian.Text;
                unPaciente.Telefono = int.TryParse(txtTelefono.Text, out aux) ? aux : unPaciente.Telefono;
                unPaciente.NumeroEmergencia = int.TryParse(txtEmergencia.Text, out aux) ? aux : unPaciente.NumeroEmergencia;
                unPaciente.Correo = txtCorreo.Text;
                unPaciente.Ciudad = comboCiudades.SelectedItem.ToString();
                unPaciente.Provincia = comboProvincias.SelectedItem.ToString();
                unPaciente.DetalleDireccion = txtDetallesDireccion.Text;
            }
           
            return unPaciente;
        }

        //insertar un nuevo paciente 
        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            EntidadPaciente unPaciente = new EntidadPaciente();
            BLPaciente logicaPaciente = new BLPaciente(Configuracion.getCadenaConeccion);
            int resultado;
            try
            {
                if (!VerificarCamposTexto())
                {
                    MessageBox.Show("ooops! Faltan datos favor revisar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(accion);
                    if (accion == "nuevo")
                    {
                        unPaciente = CrearPaciente();
                        resultado = logicaPaciente.LlamarMetodoInsertar(unPaciente);
                        CargarListaPacientes();//refrescar lista
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarForm();
                    }
                    else if (accion == "editar")
                    {
                        unPaciente = CrearPaciente();
                        resultado = logicaPaciente.LlamarEditarPaciente(unPaciente);
                        CargarListaPacientes();//refrescar lista
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarForm();
                        btnGuardarPaciente.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //editar un paciente
        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                accion = "editar";
                if (!txtID.Enabled & !comboTipoID.Enabled & !txtNombrePaciente.Enabled & !txtApellido1.Enabled & !txtApellido2.Enabled &
                !dateNacimiento.Enabled & !radioHombre.Enabled & !radioMujer.Enabled & !txtNacionalidad.Enabled & !comboEstadoCivil.Enabled &
                !radioLaborandoSi.Enabled & !radioLaborandoNo.Enabled & !radioAseguradoSi.Enabled & !radioAseguradoNo.Enabled & !txtGuardian.Enabled &
                !txtTelefono.Enabled & !txtEmergencia.Enabled & !txtCorreo.Enabled & !comboCiudades.Enabled & !comboProvincias.Enabled &
                !txtDetallesDireccion.Enabled)
                {
                    ActivarCasillas();
                }
                else
                {
                    MessageBox.Show("No existen datos para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //verificar que todos los campos esten llenos
        public bool VerificarCamposTexto()
        {
            bool todoLleno = true;

            if (string.IsNullOrEmpty(txtID.Text)
                || comboTipoID.SelectedIndex == -1
                || string.IsNullOrEmpty(txtNombrePaciente.Text)
                || string.IsNullOrEmpty(txtApellido1.Text)
                || string.IsNullOrEmpty(txtApellido2.Text)
                || dateNacimiento.Value == DateTime.Now
                || (!radioHombre.Checked && !radioMujer.Checked)
                || string.IsNullOrEmpty(txtNacionalidad.Text)
                || comboEstadoCivil.SelectedIndex == -1
                || (!radioLaborandoSi.Checked && !radioLaborandoNo.Checked)
                || (!radioAseguradoSi.Checked && !radioAseguradoNo.Checked)
                || string.IsNullOrEmpty(txtGuardian.Text)
                || string.IsNullOrEmpty(txtEmergencia.Text)
                || string.IsNullOrEmpty(txtTelefono.Text)
                || string.IsNullOrEmpty(txtCorreo.Text)
                || comboCiudades.SelectedIndex == -1
                || comboProvincias.SelectedIndex == -1
                || string.IsNullOrEmpty(txtDetallesDireccion.Text))
            {
                todoLleno = false;
            }
            return todoLleno;
        }

        //limpiar form
        public void LimpiarForm()
        {
            accion = "nuevo";
            txtID.Text = string.Empty;
            comboTipoID.SelectedIndex = -1;
            txtNombrePaciente.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            dateNacimiento.Value = DateTime.Now;
            radioHombre.Checked = false;
            radioMujer.Checked = false;
            txtNacionalidad.Text = string.Empty;
            comboEstadoCivil.SelectedIndex = -1;
            radioLaborandoSi.Checked = false;
            radioLaborandoNo.Checked = false;
            radioAseguradoSi.Checked = false;
            radioAseguradoNo.Checked = false;
            txtGuardian.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmergencia.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            comboCiudades.SelectedIndex = -1;
            comboProvincias.SelectedIndex = -1;
            txtDetallesDireccion.Text = string.Empty;
        }

        //onclick de las celdas llenar las casillas
        private void dgrListarPacientes_Click(object sender, EventArgs e)
        {
            if (EstanDisponibles())
            {
                DesactivarCasillas();
            }
            LimpiarForm();
            try
            {
                //obtener datos un click en la fila y pasarlo a cajas de texto
                if (dgrListarPacientes.SelectedRows.Count > 0)
                {
                    var row = dgrListarPacientes.SelectedRows[0];

                    DataGridViewCell identificacion = row.Cells["paciente_id"];
                    DataGridViewCell tipoId = row.Cells["tipo_id"];
                    DataGridViewCell nombrePaciente = row.Cells["nombre"];
                    DataGridViewCell apellido = row.Cells["apellidos"];
                    DataGridViewCell nacimiento = row.Cells["fecha_nacimiento"];
                    DataGridViewCell genero = row.Cells["genero"];
                    DataGridViewCell nacionalidad = row.Cells["nacionalidad"];
                    DataGridViewCell estadocivil = row.Cells["estado_civil"];
                    DataGridViewCell laborando = row.Cells["laborando"];
                    DataGridViewCell asegurado = row.Cells["asegurado"];
                    DataGridViewCell guardian = row.Cells["guardian"];
                    DataGridViewCell emergencia = row.Cells["emergencia"];
                    DataGridViewCell correo = row.Cells["correo"];
                    DataGridViewCell telefono = row.Cells["telefono"];
                    DataGridViewCell ciudad = row.Cells["ciudad"];
                    DataGridViewCell provincia = row.Cells["provincia"];
                    DataGridViewCell direccion = row.Cells["direccion"];

                    txtID.Text = identificacion.Value?.ToString();
                    comboTipoID.Items.Add(tipoId.Value?.ToString());//add the item and then selected
                    comboTipoID.Text = tipoId.Value?.ToString();
                    txtNombrePaciente.Text = nombrePaciente.Value?.ToString();
                    string[] unApellido = apellido.Value?.ToString().Split(' ');//separar el apellido
                    string primerApellido = unApellido[0];
                    string segundoApellido = unApellido[1];
                    txtApellido1.Text = primerApellido;
                    txtApellido2.Text = segundoApellido;
                    dateNacimiento.Value = DateTime.TryParse(nacimiento.Value?.ToString(), out DateTime nacimientoValue) ? nacimientoValue : dateNacimiento.Value;
                    radioHombre.Checked = genero.Value?.ToString() == "Masculino";
                    radioMujer.Checked = genero.Value?.ToString() == "Femenino";
                    radioLaborandoSi.Checked = laborando.Value?.ToString() == "Si";
                    radioLaborandoNo.Checked = laborando.Value?.ToString() == "No";
                    radioAseguradoSi.Checked = asegurado.Value?.ToString() == "Si";
                    radioAseguradoNo.Checked = asegurado.Value?.ToString() == "No";
                    txtNacionalidad.Text = nacionalidad.Value?.ToString();
                    comboEstadoCivil.Items.Add(estadocivil.Value?.ToString());//add the item and then selected
                    comboEstadoCivil.Text = estadocivil.Value?.ToString();
                    txtGuardian.Text = guardian.Value?.ToString();
                    txtTelefono.Text = telefono.Value?.ToString();
                    txtEmergencia.Text = emergencia.Value?.ToString();
                    txtCorreo.Text = correo.Value?.ToString();
                    comboCiudades.Items.Add(ciudad.Value?.ToString());//add the item and then selected
                    comboCiudades.Text = ciudad.Value?.ToString();
                    comboProvincias.Items.Add(provincia.Value?.ToString());//add the item and then selected
                    comboProvincias.Text = provincia.Value?.ToString();
                    txtDetallesDireccion.Text = direccion.Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //casillar disponibles?
        private bool EstanDisponibles()
        {
            bool disponibles = false;
            if (txtID.Enabled & comboTipoID.Enabled & txtNombrePaciente.Enabled & txtApellido1.Enabled & txtApellido2.Enabled &
                            dateNacimiento.Enabled & radioHombre.Enabled & radioMujer.Enabled & txtNacionalidad.Enabled &
                            comboEstadoCivil.Enabled & radioLaborandoSi.Enabled & radioLaborandoNo.Enabled & radioAseguradoSi.Enabled &
                            radioAseguradoNo.Enabled & txtGuardian.Enabled & txtTelefono.Enabled & txtEmergencia.Enabled & txtCorreo.Enabled &
                            comboCiudades.Enabled & comboProvincias.Enabled & txtDetallesDireccion.Enabled)
            {
                disponibles = true;
            }
            return disponibles;
        }

        //desactivar todas las casillas
        private void DesactivarCasillas()
        {
            txtID.Enabled = false;
            comboTipoID.Enabled = false;
            txtNombrePaciente.Enabled = false;
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            dateNacimiento.Enabled = false;
            radioHombre.Enabled = false;
            radioMujer.Enabled = false;
            txtNacionalidad.Enabled = false;
            comboEstadoCivil.Enabled = false;
            radioLaborandoSi.Enabled = false;
            radioLaborandoNo.Enabled = false;
            radioAseguradoSi.Enabled = false;
            radioAseguradoNo.Enabled = false;
            txtGuardian.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmergencia.Enabled = false;
            txtCorreo.Enabled = false;
            comboCiudades.Enabled = false;
            comboProvincias.Enabled = false;
            txtDetallesDireccion.Enabled = false;
        }

        //activar casillas
        private void ActivarCasillas()
        {
            txtID.Enabled = true;
            comboTipoID.Enabled = true;
            txtNombrePaciente.Enabled = true;
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            dateNacimiento.Enabled = true;
            radioHombre.Enabled = true;
            radioMujer.Enabled = true;
            txtNacionalidad.Enabled = true;
            comboEstadoCivil.Enabled = true;
            radioLaborandoSi.Enabled = true;
            radioLaborandoNo.Enabled = true;
            radioAseguradoSi.Enabled = true;
            radioAseguradoNo.Enabled = true;
            txtGuardian.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmergencia.Enabled = true;
            txtCorreo.Enabled = true;
            comboCiudades.Enabled = true;
            comboProvincias.Enabled = true;
            txtDetallesDireccion.Enabled = true;
        }




        private void btnSalirNPaciente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            //filtrar los datos y recuperar el cliente deseado
            string busqueda = "";
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    //el nombre tiene en la cadena tiene que ser igual al de al entidad de la base de datos en c# 
                    busqueda = string.Format("PACIENTE_ID LIKE '%{0}%'", txtID.Text.ToString().Trim());
                }
                else
                {
                    MessageBox.Show("Debe de escribir al menos una letra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                }
                CargarListaPacientes(busqueda);//pasamos lo que vamos a filtrar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
