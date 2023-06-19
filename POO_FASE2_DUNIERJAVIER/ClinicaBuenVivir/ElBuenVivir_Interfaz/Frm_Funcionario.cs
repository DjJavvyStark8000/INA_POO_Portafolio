using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;
using ElBuenVivir_Logica;
using System.Collections;
using ElBuenVivir_Entidades;
using static System.Windows.Forms.MonthCalendar;
using ElBuenVivir_AccesoDatos;
using System.Runtime.Intrinsics.X86;
using System.Globalization;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Funcionario : Form
    {


        //set some variables
        private static string estadoCivil = "";
        private static int identificacion = 0;
        private static int elTelefono = 0;
        private static List<string> DiasLibres = new List<string>();//guardo los dias libres del funcionario
        private bool frm_loading = true;
        private string accion = "Nuevo";
        public int global = 0;


        public Frm_Funcionario()
        {
            InitializeComponent();
        }

        //Identificacion
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out identificacion) || identificacion < 0)
            {
                txtID.Text = "";
                lblSoloNum.Visible = true;

            }
            else { lblSoloNum.Visible = false; }
        }

        //Nombre y Apellidos
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            GenerarNombreCompleto();
        }

        //Filtrar medico para habilitar especialidad
        private void comboPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPuesto.SelectedItem.ToString() == "Medicina")
            {
                comboSeleccionarEspecialidad.Enabled = true;
            }
            else { comboSeleccionarEspecialidad.Enabled = false; }
        }

        private void GenerarNombreCompleto()
        {
            string nombre = txtNombre.Text.Trim();
            string apellido1 = txtApellido1.Text.Trim();
            string apellido2 = txtApellido2.Text.Trim();
            // Concatenar los valores en el orden deseado
            string nombreCompleto = $"{nombre} {apellido1} {apellido2}";
        }

        //genero      
        private void radioHombre_CheckedChanged(object sender, EventArgs e)
        {
            //genero = radioHombre.Text;
        }

        private void radioMujer_CheckedChanged(object sender, EventArgs e)
        {
            // genero = radioMujer.Text;
        }

        //nacionalidad
        private void txtNacionalidad_TextChanged(object sender, EventArgs e)
        {
            panelEstadoCivil.Enabled = true;
        }

        //Estado civil
        private void radioCasado_CheckedChanged(object sender, EventArgs e)
        {
            estadoCivil = radioCasado.Text;
        }

        private void radioSoltero_CheckedChanged(object sender, EventArgs e)
        {
            estadoCivil = radioSoltero.Text;
        }

        private void radioUnion_CheckedChanged(object sender, EventArgs e)
        {
            estadoCivil = radioUnion.Text;
        }

        private void radioDivorciado_CheckedChanged(object sender, EventArgs e)
        {
            estadoCivil = radioDivorciado.Text;
        }

        private void radioOtro_CheckedChanged(object sender, EventArgs e)
        {
            estadoCivil = radioOtro.Text;
        }

        //Dias libres
        private void checkLunes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkLunes.Checked)
            {
                DiasLibres.Add(checkLunes.Text);//Agregar a la lista
            }
            else
            {
                DiasLibres.Remove(checkLunes.Text);//Remover de la lista
            }

        }

        private void checkMartes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMartes.Checked)
            {
                DiasLibres.Add(checkMartes.Text);//Agregar a la lista
            }
            else
            {
                DiasLibres.Remove(checkMartes.Text);//Remover de la lista
            }
        }

        private void checkMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMiercoles.Checked)
            {
                DiasLibres.Add(checkMiercoles.Text);//Agregar a la lista
            }
            else
            {
                DiasLibres.Remove(checkMiercoles.Text);//Remover de la lista
            }
        }

        private void checkJueves_CheckedChanged(object sender, EventArgs e)
        {
            if (checkJueves.Checked)
            {
                DiasLibres.Add(checkJueves.Text);//Agregar a la lista
            }
            else
            {
                DiasLibres.Remove(checkJueves.Text);//Remover de la lista
            }
        }

        private void checkViernes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkViernes.Checked)
            {
                DiasLibres.Add(checkViernes.Text);//Agregar a la lista
            }
            else
            {
                DiasLibres.Remove(checkViernes.Text);//Remover de la lista
            }
        }

        //Telefono
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTelefono.Text, out elTelefono) || elTelefono < 0)
            {
                txtTelefono.Text = "";
                lblSoloNum2.Visible = true;
            }
            else { lblSoloNum2.Visible = false; }
        }


        //Correo
        private void txtCorreo_TextChanged_1(object sender, EventArgs e)
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

        public static bool RevisarCorreo(string correo)
        {
            //Patron de Regular expression 
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Crear objeto Regex
            Regex regex = new Regex(pattern);

            //verificar si hay un match
            return regex.IsMatch(correo);
        }

        private void Frm_Funcionario_Load(object sender, EventArgs e)
        {
            frm_loading = true;
            LimpiarForm();
            CargarListaFuncionario();
            CargarListaMedico();
            CargarListaEspecialidades();
            frm_loading = false;
        }
        // (*****) Carga la lista datagridview para funcionarios
        public void CargarListaFuncionario(string condicion = "")
        {

            BLFuncionarios logicaFuncionario = new BLFuncionarios(Configuracion.getCadenaConeccion);
            List<EntidadFuncionario> funcionario;
            try
            {
                funcionario = logicaFuncionario.llamarListarFuncionarios(condicion);
                if (funcionario.Count > 0)
                {
                    dgrListarFuncionario.DataSource = funcionario;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // (*****) Carga la lista datagridviewj para medicos
        public void CargarListaMedico(string condicion = "")
        {

            BLMedicos logicaMedico = new BLMedicos(Configuracion.getCadenaConeccion);
            List<EntidadMedicos> medico;
            try
            {
                medico = logicaMedico.llamarListarMedicos(condicion);
                if (medico.Count > 0)
                {
                    dgrListarMedicos.DataSource = medico;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // cargar especialidades
        public void CargarListaEspecialidades(string condicion = "")
        {
            BLEspecialidad logicaEspecialidad = new BLEspecialidad(Configuracion.getCadenaConeccion);
            List<EntidadEspecialidad> especialidades;
            try
            {
                especialidades = logicaEspecialidad.llamarListarEspecialidades(condicion);
                if (especialidades.Count > 0)
                {
                    comboSeleccionarEspecialidad.DataSource = especialidades;
                    comboSeleccionarEspecialidad.DisplayMember = "NOMBRE_ESPECIALIDAD";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboSeleccionarEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSeleccionarEspecialidad.SelectedItem != null & frm_loading == false)
            {
                EntidadEspecialidad especialidadSeleccionada = (EntidadEspecialidad)comboSeleccionarEspecialidad.SelectedItem;
                int idEspecialidad = especialidadSeleccionada.ID_Especialidad;

                MessageBox.Show("ID de la especialidad seleccionada: " + idEspecialidad.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //crear objeto funcionario
        private EntidadFuncionario CrearFuncionario()
        {
            EntidadFuncionario unFuncionario = new EntidadFuncionario();
            // if (accion == "nuevo")
            // {
            int aux;
            if (int.TryParse(txtID.Text, out aux))
            {
                unFuncionario.Identificacion = aux;
            }
            unFuncionario.Puesto = comboPuesto.SelectedIndex.ToString();
            unFuncionario.Nombre = txtNombre.Text;
            unFuncionario.Apellidos = txtApellido1.Text + " " + txtApellido2.Text;
            unFuncionario.FechaNacimiento = dateNacimiento.Value.ToShortDateString();
            if (radioHombre.Checked)
            {
                unFuncionario.Genero = "Masculino";
            }
            else
            {
                unFuncionario.Genero = "Femenino";
            }
            unFuncionario.Nacionalidad = txtNacionalidad.Text;
            if (radioCasado.Checked)
            {
                unFuncionario.EstadoCivil = "Casado/a";
            }
            if (radioSoltero.Checked)
            {
                unFuncionario.EstadoCivil = "Soltero/a";
            }
            if (radioUnion.Checked)
            {
                unFuncionario.EstadoCivil = "Union Libre";
            }
            if (radioDivorciado.Checked)
            {
                unFuncionario.EstadoCivil = "Divorciado/a";
            }
            if (radioOtro.Checked)
            {
                unFuncionario.EstadoCivil = "Otro";
            }
            if (checkLunes.Checked)
            {
                DiasLibres.Add("Lunes");
            }
            if (checkMartes.Checked)
            {
                DiasLibres.Add("Martes");
            }
            if (checkMiercoles.Checked)
            {
                DiasLibres.Add("Miércoles");
            }
            if (checkJueves.Checked)
            {
                DiasLibres.Add("Jueves");
            }
            if (checkViernes.Checked)
            {
                DiasLibres.Add("Viernes");
            }
            string diasLibres = string.Join(", ", DiasLibres);//join los dias en una string
            unFuncionario.DiasLibres = diasLibres;
            unFuncionario.HoraEntrada = dateHoraEntrada.Value.TimeOfDay.ToString();
            unFuncionario.HoraSalida = dateHoraSalida.Value.TimeOfDay.ToString();
            if (int.TryParse(txtTelefono.Text, out aux))
            {
                unFuncionario.Telefono = aux;
            }
            unFuncionario.Correo = txtCorreo.Text;
            unFuncionario.Ciudad = comboCiudades.SelectedItem.ToString();
            unFuncionario.Provincia = comboProvincias.SelectedItem.ToString();
            unFuncionario.DetalleDireccion = txtDetallesDireccion.Text;
            unFuncionario.Anotaciones = txtAnotaciones.Text;
            //}
            //else if (accion == "editar")
            //{

            //}
            return unFuncionario;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadFuncionario unFuncionario = new EntidadFuncionario();//objeto
            BLFuncionarios logicaFuncionario = new BLFuncionarios(Configuracion.getCadenaConeccion);//conexion

            try
            {
                if (!VerificarCamposTexto())//si no tiene texto                   
                {
                    MessageBox.Show("ooops! Faltan datos favor revisar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (accion == "Nuevo")
                    {
                        unFuncionario = CrearFuncionario();//crea objeto
                        int resultado = logicaFuncionario.LlamarInsertarFuncionario(unFuncionario);
                        CargarListaFuncionario();//cargar lista
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // else if (accion == "editar")
                        //  {
                        //unFuncionario = CrearEspecialidad();//crea objeto
                        //int resultado = logicaEspecialidad.LlamarEditarEspecialidad(unaEspecialidad);
                        //CargarListaEspecialidades();//cargar lista
                        //MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //btnGuardar.Enabled = false;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //verificar que todos los campos esten llenos
        public bool VerificarCamposTexto()
        {
            bool todosTienenLetras = true;
            if (string.IsNullOrEmpty(txtID.Text))
            {
                todosTienenLetras = false;
            }
            if (comboPuesto.SelectedIndex == -1)
            {
                todosTienenLetras = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                todosTienenLetras = false;
            }
            if (string.IsNullOrEmpty(txtApellido1.Text))
            {
                todosTienenLetras = false;
            }
            if (string.IsNullOrEmpty(txtApellido2.Text))
            {
                todosTienenLetras = false;
            }
            if (dateNacimiento.Value == DateTime.Now)
            {
                todosTienenLetras = false;
            }
            if (!radioHombre.Checked & !radioMujer.Checked)
            {
                todosTienenLetras = false;
            }
            if (string.IsNullOrEmpty(txtNacionalidad.Text))//
            {
                todosTienenLetras = false;
            }
            if (!radioCasado.Checked & !radioSoltero.Checked & !radioUnion.Checked & !radioDivorciado.Checked & !radioOtro.Checked)
            {
                todosTienenLetras = false;
            }
            if (dateHoraEntrada.Value == dateHoraEntrada.MinDate)
            {
                todosTienenLetras = false;
            }
            if (dateHoraSalida.Value == dateHoraSalida.MinDate)
            {
                todosTienenLetras = false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))//
            {
                todosTienenLetras = false;
            }
            if (string.IsNullOrEmpty(txtCorreo.Text))//
            {
                todosTienenLetras = false;
            }
            if (comboCiudades.SelectedIndex == -1)//
            {
                todosTienenLetras = false;
            }
            if (comboProvincias.SelectedIndex == -1)//
            {
                todosTienenLetras = false;
            }
            if (string.IsNullOrEmpty(txtDetallesDireccion.Text))//
            {
                todosTienenLetras = false;
            }
            if (string.IsNullOrEmpty(txtAnotaciones.Text))//
            {
                todosTienenLetras = false;
            }
            return todosTienenLetras;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        public void LimpiarForm()
        {
            accion = "Nuevo";
            txtID.Text = string.Empty;
            comboPuesto.SelectedIndex = -1;
            txtNombre.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            dateNacimiento.Value = DateTime.Now;
            radioHombre.Checked = false;
            radioMujer.Checked = false;
            txtNacionalidad.Text = string.Empty;
            radioCasado.Checked = false;
            radioSoltero.Checked = false;
            radioUnion.Checked = false;
            radioDivorciado.Checked = false;
            radioOtro.Checked = false;
            checkLunes.Checked = false;
            checkMartes.Checked = false;
            checkMiercoles.Checked = false;
            checkJueves.Checked = false;
            checkViernes.Checked = false;
            dateHoraEntrada.Value = dateHoraEntrada.MinDate;
            dateHoraSalida.Value = dateHoraSalida.MinDate;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            comboCiudades.SelectedIndex = -1;
            comboProvincias.SelectedIndex = -1;
            txtDetallesDireccion.Text = string.Empty;
            txtAnotaciones.Text = string.Empty;
            DiasLibres.Clear();
        }

        private void dgrListarFuncionario_Click(object sender, EventArgs e)
        {

            if (txtID.Enabled & comboPuesto.Enabled & txtNombre.Enabled & txtApellido1.Enabled & txtApellido2.Enabled &
                dateNacimiento.Enabled & radioHombre.Enabled & radioMujer.Enabled & txtNacionalidad.Enabled &
                radioCasado.Enabled & radioSoltero.Enabled & radioUnion.Enabled & radioDivorciado.Enabled &
                radioOtro.Enabled & checkLunes.Enabled & checkMartes.Enabled & checkMiercoles.Enabled &
                checkJueves.Enabled & checkViernes.Enabled & dateHoraEntrada.Enabled & dateHoraSalida.Enabled &
                txtTelefono.Enabled & txtCorreo.Enabled & comboCiudades.Enabled & comboProvincias.Enabled &
                txtDetallesDireccion.Enabled & txtAnotaciones.Enabled)
            {
                txtID.Enabled = false;
                comboPuesto.Enabled = false;
                txtNombre.Enabled = false;
                txtApellido1.Enabled = false;
                txtApellido2.Enabled = false;
                dateNacimiento.Enabled = false;
                radioHombre.Enabled = false;
                radioMujer.Enabled = false;
                txtNacionalidad.Enabled = false;
                radioCasado.Enabled = false;
                radioSoltero.Enabled = false;
                radioUnion.Enabled = false;
                radioDivorciado.Enabled = false;
                radioOtro.Enabled = false;
                checkLunes.Enabled = false;
                checkMartes.Enabled = false;
                checkMiercoles.Enabled = false;
                checkJueves.Enabled = false;
                checkViernes.Enabled = false;
                dateHoraEntrada.Enabled = false;
                dateHoraSalida.Enabled = false;
                txtTelefono.Enabled = false;
                txtCorreo.Enabled = false;
                comboCiudades.Enabled = false;
                comboProvincias.Enabled = false;
                txtDetallesDireccion.Enabled = false;
                txtAnotaciones.Enabled = false;
            }

            LimpiarForm();
            try
            {                                                                                       //obtener datos un click en la fila y pasarlo a cajas de texto
                if (dgrListarFuncionario.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgrListarFuncionario.SelectedRows[0];
                    // Accede a las celdas en el orden correcto utilizando el índice real de la columna
                    DataGridViewCell identificacion = row.Cells[dgrListarFuncionario.Columns["clmidfun"].Index];
                    DataGridViewCell nombre = row.Cells[dgrListarFuncionario.Columns["clmnombrefun"].Index];
                    DataGridViewCell apellido = row.Cells[dgrListarFuncionario.Columns["clmapellidosfun"].Index];
                    DataGridViewCell nacimiento = row.Cells[dgrListarFuncionario.Columns["clmnaciofun"].Index];
                    DataGridViewCell genero = row.Cells[dgrListarFuncionario.Columns["clmgenerofun"].Index];
                    DataGridViewCell nacionalidad = row.Cells[dgrListarFuncionario.Columns["clmpaisfun"].Index];
                    DataGridViewCell estadocivil = row.Cells[dgrListarFuncionario.Columns["clmcivilfun"].Index];
                    DataGridViewCell libres = row.Cells[dgrListarFuncionario.Columns["clmlibresfun"].Index];
                    DataGridViewCell correo = row.Cells[dgrListarFuncionario.Columns["clmcorreofun"].Index];
                    DataGridViewCell telefono = row.Cells[dgrListarFuncionario.Columns["clmtelefonofun"].Index];
                    DataGridViewCell ciudad = row.Cells[dgrListarFuncionario.Columns["clmciudadfun"].Index];
                    DataGridViewCell provincia = row.Cells[dgrListarFuncionario.Columns["clmprovinciafun"].Index];
                    DataGridViewCell direccion = row.Cells[dgrListarFuncionario.Columns["clmdireccionfun"].Index];
                    DataGridViewCell anotaciones = row.Cells[dgrListarFuncionario.Columns["clmanotacionesfun"].Index];
                    DataGridViewCell puesto = row.Cells[dgrListarFuncionario.Columns["clmpuestofun"].Index];
                    DataGridViewCell horain = row.Cells[dgrListarFuncionario.Columns["clmhorainfun"].Index];
                    DataGridViewCell horaout = row.Cells[dgrListarFuncionario.Columns["clmhoraoutfun"].Index];


                    // Obtén los valores de las celdas
                    txtID.Text = identificacion.Value.ToString();
                    comboPuesto.Text = puesto.Value.ToString();
                    txtNombre.Text = nombre.Value.ToString();
                    txtApellido1.Text = apellido.Value.ToString();
                    DateTime nacimientoValue;
                    if (DateTime.TryParse(nacimiento.Value.ToString(), out nacimientoValue))
                    {
                        dateNacimiento.Value = nacimientoValue;
                    }
                    if (genero.Value.ToString() == "Masculino")
                    {
                        radioHombre.Checked = true;
                    }
                    if (genero.Value.ToString() == "Femenino")
                    {
                        radioMujer.Checked = true;
                    }
                    txtNacionalidad.Text = nacimiento.Value.ToString();
                    if (estadocivil.Value.ToString() == "Casado/a")
                    {
                        radioCasado.Checked = true;
                    }
                    if (estadocivil.Value.ToString() == "Soltero/a")
                    {
                        radioSoltero.Checked = true;
                    }
                    if (estadocivil.Value.ToString() == "Union Libre")
                    {
                        radioUnion.Checked = true;
                    }
                    if (estadocivil.Value.ToString() == "Divorciado/a")
                    {
                        radioDivorciado.Checked = true;
                    }
                    if (estadocivil.Value.ToString() == "Otro")
                    {
                        radioOtro.Checked = true;
                    }
                    DateTime entrada;
                    if (DateTime.TryParse(horain.Value.ToString(), out entrada))
                    {
                        dateHoraEntrada.Value = entrada;
                    }
                    DateTime salida;
                    if (DateTime.TryParse(horaout.Value.ToString(), out salida))
                    {
                        dateHoraSalida.Value = salida;
                    }
                    txtTelefono.Text = telefono.Value.ToString();
                    txtCorreo.Text = correo.Value.ToString();
                    comboCiudades.Text = ciudad.Value.ToString();
                    comboProvincias.Text = provincia.Value.ToString();
                    txtDetallesDireccion.Text = direccion.Value.ToString();
                    txtAnotaciones.Text = anotaciones.Value.ToString();

                    string dia = "Lunes";
                    int indice = libres.Value.ToString().IndexOf(dia);
                    if (indice != -1)
                    {
                        checkLunes.Checked = true;
                    }
                    dia = "Martes";
                    indice = libres.Value.ToString().IndexOf(dia);
                    if (indice != -1)
                    {
                        checkMartes.Checked = true;
                    }
                    dia = "Miercoles";
                    indice = libres.Value.ToString().IndexOf(dia);
                    if (indice != -1)
                    {
                        checkMiercoles.Checked = true;
                    }
                    dia = "Jueves";
                    indice = libres.Value.ToString().IndexOf(dia);
                    if (indice != -1)
                    {
                        checkJueves.Checked = true;
                    }
                    dia = "Viernes";
                    indice = libres.Value.ToString().IndexOf(dia);
                    if (indice != -1)
                    {
                        checkViernes.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // (0) set global
        private int GetSetGlobal(int global)
        {
            return global;
        }
    }
}
