using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ElBuenVivir_Logica;
using ElBuenVivir_Entidades;
using System.Linq;

using CheckBox = System.Windows.Forms.CheckBox;
using System.Data;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Funcionario : Form
    {


        //set some variables
        private static int identificacion = 0;
        private static int elTelefono = 0;
        private bool frm_loading = true;
        private string accion = "nuevo";
        public int global = 0;
        private string diaSemana;
        private string horaEntrada;
        private string horaSalida;
        private int idDeHorario = 0;
        private static List<string> Horasxdia = Enumerable.Repeat("--Libre--", 7).ToList();//horas por default

        public Frm_Funcionario()
        {
            InitializeComponent();
            //Event handlers para horario
            checkLunes.CheckedChanged += DayOfWeek_CheckedChanged;
            checkMartes.CheckedChanged += DayOfWeek_CheckedChanged;
            checkMiercoles.CheckedChanged += DayOfWeek_CheckedChanged;
            checkJueves.CheckedChanged += DayOfWeek_CheckedChanged;
            checkViernes.CheckedChanged += DayOfWeek_CheckedChanged;
            checkSabado.CheckedChanged += DayOfWeek_CheckedChanged;
            checkDomingo.CheckedChanged += DayOfWeek_CheckedChanged;
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
                    // dgrListarFuncionario.AutoGenerateColumns = false;//esconder columnas no deseadas
                    dgrListarFuncionario.DataSource = funcionario;
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

        // (*****) Carga la lista datagridview para funcionarios
        public void CargarListaHorarios(string condicion = "", int horarioID = 0)
        {
            BLHorarioFuncionarios logicaHorario = new BLHorarioFuncionarios(Configuracion.getCadenaConeccion);
            List<EntidadHorarioFuncionarios> horarios;
            try
            {
                horarios = logicaHorario.llamarListarHorarioFuncionarios(condicion);
                if (horarios.Count > 0)
                {
                    if (horarioID != 0)
                    {
                        // Filtrar la lista de horarios para mostrar únicamente el horario con el ID indicado
                        horarios = horarios.Where(horario => horario.HorarioId == horarioID).ToList();
                        // actualizar lista de horas para poder editarlas
                        for (int i = 0; i < horarios.Count; i++)
                        {
                            Horasxdia[0] = horarios[i].Lunes;
                            Horasxdia[1] = horarios[i].Martes;
                            Horasxdia[2] = horarios[i].Miercoles;
                            Horasxdia[3] = horarios[i].Jueves;
                            Horasxdia[4] = horarios[i].Viernes;
                            Horasxdia[5] = horarios[i].Sabado;
                            Horasxdia[6] = horarios[i].Domingo;
                        }
                    }

                    dgrHorasSemana.DataSource = horarios;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        //crear objeto horarioFuncionario
        private EntidadHorarioFuncionarios CrearHorarioFuncionario()
        {
            EntidadHorarioFuncionarios unHorarioFuncionario = new EntidadHorarioFuncionarios();
            if (accion == "editar") unHorarioFuncionario.HorarioId = idDeHorario;
            unHorarioFuncionario.Lunes = Horasxdia[0];//object para retornar //***
            unHorarioFuncionario.Martes = Horasxdia[1];//***
            unHorarioFuncionario.Miercoles = Horasxdia[2];//***
            unHorarioFuncionario.Jueves = Horasxdia[3];//***
            unHorarioFuncionario.Viernes = Horasxdia[4];//***
            unHorarioFuncionario.Sabado = Horasxdia[5];//***
            unHorarioFuncionario.Domingo = Horasxdia[6];//***

            return unHorarioFuncionario;
        }
        //crear objeto funcionario
        private EntidadFuncionario CrearFuncionario()
        {
            int idHorario = 0;
            EntidadHorarioFuncionarios unHorario = new EntidadHorarioFuncionarios();
            EntidadFuncionario unFuncionario = new EntidadFuncionario();
            BLHorarioFuncionarios logicaHorarioFuncionarios = new BLHorarioFuncionarios(Configuracion.getCadenaConeccion);
            unHorario = CrearHorarioFuncionario();// un horario de funcionario

            int aux;
            unFuncionario.Identificacion = int.TryParse(txtID.Text, out aux) ? aux : unFuncionario.Identificacion;
            if (accion == "nuevo")
            {
                idHorario = logicaHorarioFuncionarios.LlamarInsertarHorarioFuncionarios(unHorario);
                unFuncionario.HorarioId = idHorario;//skalar de la tabla de horario de la base de datos
            }
            else if (accion == "editar")
            {
                logicaHorarioFuncionarios.LlamarEditarHorarioFuncionarios(unHorario);
                unFuncionario.HorarioId = idHorario;
                unFuncionario.HorarioId = idDeHorario;//directamente de la tabla
            }
            unFuncionario.Puesto = comboPuesto.SelectedItem.ToString();
            unFuncionario.Nombre = txtNombre.Text;
            unFuncionario.Apellidos = txtApellido1.Text + " " + txtApellido2.Text;
            unFuncionario.FechaNacimiento = dateNacimiento.Value.ToString("yyyy/MM/dd");//cambiar formato de fecha
            unFuncionario.Genero = radioHombre.Checked ? "Masculino" : "Femenino";
            unFuncionario.Nacionalidad = txtNacionalidad.Text;
            unFuncionario.EstadoCivil = comboEstadoCivil.SelectedItem.ToString();
            unFuncionario.Telefono = int.TryParse(txtTelefono.Text, out aux) ? aux : unFuncionario.Telefono;
            unFuncionario.Correo = txtCorreo.Text;
            unFuncionario.Ciudad = comboCiudades.SelectedItem.ToString();
            unFuncionario.Provincia = comboProvincias.SelectedItem.ToString();
            unFuncionario.DetalleDireccion = txtDetallesDireccion.Text;
            unFuncionario.Anotaciones = txtAnotaciones.Text;
            return unFuncionario;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadFuncionario unFuncionario = new EntidadFuncionario();//objeto funcionario
            BLFuncionarios logicaFuncionario = new BLFuncionarios(Configuracion.getCadenaConeccion);//conexion

            try
            {
                if (!VerificarCamposTexto())//si no tiene texto                   
                {
                    MessageBox.Show("ooops! Faltan datos favor revisar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int resultado = 0;
                    if (accion == "nuevo")
                    {
                        unFuncionario = CrearFuncionario();//un funcionario
                        resultado = logicaFuncionario.LlamarInsertarFuncionario(unFuncionario);
                        CargarListaFuncionario();//cargar lista
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarForm();
                    }
                    else if (accion == "editar")
                    {
                        unFuncionario = CrearFuncionario();//un funcionario
                        logicaFuncionario.LlamarEditarFuncinario(unFuncionario);                                    
                        CargarListaFuncionario();//cargar lista
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardar.Enabled = false;
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

            if (string.IsNullOrEmpty(txtID.Text)
                || comboPuesto.SelectedIndex == -1
                || string.IsNullOrEmpty(txtNombre.Text)
                || string.IsNullOrEmpty(txtApellido1.Text)
                || string.IsNullOrEmpty(txtApellido2.Text)
                || dateNacimiento.Value == DateTime.Now
                || (!radioHombre.Checked && !radioMujer.Checked)
                || string.IsNullOrEmpty(txtNacionalidad.Text)
                || comboEstadoCivil.SelectedIndex == -1
                || string.IsNullOrEmpty(txtTelefono.Text)
                || string.IsNullOrEmpty(txtCorreo.Text)
                || comboCiudades.SelectedIndex == -1
                || comboProvincias.SelectedIndex == -1
                || string.IsNullOrEmpty(txtDetallesDireccion.Text)
                || string.IsNullOrEmpty(txtAnotaciones.Text))
            {
                todosTienenLetras = false;
            }

            return todosTienenLetras;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarForm();
        }


        //editar funcionario boton
        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                accion = "editar";
                if (!txtID.Enabled & !comboPuesto.Enabled & !txtNombre.Enabled & !txtApellido1.Enabled & !txtApellido2.Enabled &
                !dateNacimiento.Enabled & !radioHombre.Enabled & !radioMujer.Enabled & !txtNacionalidad.Enabled &
                !comboEstadoCivil.Enabled & !checkLunes.Enabled & !checkMartes.Enabled & !checkMiercoles.Enabled &
                !checkJueves.Enabled & !checkViernes.Enabled & !checkSabado.Enabled & !checkDomingo.Enabled &
                !txtTelefono.Enabled & !txtCorreo.Enabled & !comboCiudades.Enabled & !comboProvincias.Enabled &
                !txtDetallesDireccion.Enabled & !txtAnotaciones.Enabled)
                {
                    ActivarForm();
                    ShowControlValues();
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
        //limpiar form
        public void LimpiarForm()
        {
            accion = "nuevo";
            txtID.Text = string.Empty;
            comboPuesto.Text = string.Empty;
            comboPuesto.SelectedIndex = -1;
            txtNombre.Text = string.Empty;
            txtApellido1.Text = string.Empty;
            txtApellido2.Text = string.Empty;
            dateNacimiento.Value = DateTime.Now;
            radioHombre.Checked = false;
            radioMujer.Checked = false;
            txtNacionalidad.Text = string.Empty;
            comboEstadoCivil.Text = string.Empty;
            comboEstadoCivil.SelectedIndex = -1;
            checkLunes.Checked = false;
            checkMartes.Checked = false;
            checkMiercoles.Checked = false;
            checkJueves.Checked = false;
            checkViernes.Checked = false;
            checkSabado.Checked = false;
            checkDomingo.Checked = false;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            comboCiudades.Text = string.Empty;
            comboProvincias.Text = string.Empty;
            comboCiudades.SelectedIndex = -1;
            comboProvincias.SelectedIndex = -1;
            txtDetallesDireccion.Text = string.Empty;
            txtAnotaciones.Text = string.Empty;
            dgrHorasSemana.DataSource = null;//en conjunto se puede limpiar el data grid view
            dgrHorasSemana.Rows.Clear();
            Horasxdia = new List<string>(); // Asignar una nueva lista vacía
            Horasxdia.AddRange(Enumerable.Repeat("--Libre--", 7));//llenar con valores predeterminados otra vez
        }

        //activar casillas en el form
        private void ActivarForm()
        {
            txtID.Enabled = (accion != "editar");
            comboPuesto.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            dateNacimiento.Enabled = true;
            radioHombre.Enabled = true;
            radioMujer.Enabled = true;
            txtNacionalidad.Enabled = true;
            comboEstadoCivil.Enabled = true;
            checkLunes.Enabled = true;
            checkMartes.Enabled = true;
            checkMiercoles.Enabled = true;
            checkJueves.Enabled = true;
            checkViernes.Enabled = true;
            checkSabado.Enabled = true;
            checkDomingo.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            comboCiudades.Enabled = true;
            comboProvincias.Enabled = true;
            txtDetallesDireccion.Enabled = true;
            txtAnotaciones.Enabled = true;
            dgrHorasSemana.Enabled = true;
        }
        //temporarl
        private void ShowControlValues()
        {
            string message = $"txtID.Text: {txtID.Text}\n" +
                             $"Global tiene: {global}\n" +
                             $"Id de Horario: {idDeHorario.ToString()}\n" +
                             $"comboPuesto.SelectedItem: {comboPuesto.SelectedItem}\n" +
                             $"txtNombre.Text: {txtNombre.Text}\n" +
                             $"txtApellido1.Text: {txtApellido1.Text}\n" +
                             $"txtApellido2.Text: {txtApellido2.Text}\n" +
                             $"dateNacimiento.Value: {dateNacimiento.Value}\n" +
                             $"radioHombre.Checked: {radioHombre.Checked}\n" +
                             $"radioMujer.Checked: {radioMujer.Checked}\n" +
                             $"txtNacionalidad.Text: {txtNacionalidad.Text}\n" +
                             $"comboEstadoCivil.SelectedItem: {comboEstadoCivil.SelectedItem}\n" +
                             $"checkLunes.Checked: {checkLunes.Checked}\n" +
                             $"checkMartes.Checked: {checkMartes.Checked}\n" +
                             $"checkMiercoles.Checked: {checkMiercoles.Checked}\n" +
                             $"checkJueves.Checked: {checkJueves.Checked}\n" +
                             $"checkViernes.Checked: {checkViernes.Checked}\n" +
                             $"checkSabado.Checked: {checkSabado.Checked}\n" +
                             $"checkDomingo.Checked: {checkDomingo.Checked}\n" +
                             $"txtTelefono.Text: {txtTelefono.Text}\n" +
                             $"txtCorreo.Text: {txtCorreo.Text}\n" +
                             $"comboCiudades.SelectedItem: {comboCiudades.SelectedItem}\n" +
                             $"comboProvincias.SelectedItem: {comboProvincias.SelectedItem}\n" +
                             $"txtDetallesDireccion.Text: {txtDetallesDireccion.Text}\n" +
                             $"txtAnotaciones.Text: {txtAnotaciones.Text}";
            MessageBox.Show(message);
        }

        //listar funcionarios del datagridview a las casillar para editar
        private void dgrListarFuncionario_Click(object sender, EventArgs e)
        {
            if (txtID.Enabled & comboPuesto.Enabled & txtNombre.Enabled & txtApellido1.Enabled & txtApellido2.Enabled &
                dateNacimiento.Enabled & radioHombre.Enabled & radioMujer.Enabled & txtNacionalidad.Enabled &
                comboEstadoCivil.Enabled & checkLunes.Enabled & checkMartes.Enabled & checkMiercoles.Enabled &
                checkJueves.Enabled & checkViernes.Enabled & checkSabado.Enabled & checkDomingo.Enabled &
                txtTelefono.Enabled & txtCorreo.Enabled & comboCiudades.Enabled & comboProvincias.Enabled &
                txtDetallesDireccion.Enabled & txtAnotaciones.Enabled & dgrHorasSemana.Enabled)
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
                comboEstadoCivil.Enabled = false;
                checkLunes.Enabled = false;
                checkMartes.Enabled = false;
                checkMiercoles.Enabled = false;
                checkJueves.Enabled = false;
                checkViernes.Enabled = false;
                checkSabado.Enabled = false;
                checkDomingo.Enabled = false;
                txtTelefono.Enabled = false;
                txtCorreo.Enabled = false;
                comboCiudades.Enabled = false;
                comboProvincias.Enabled = false;
                txtDetallesDireccion.Enabled = false;
                txtAnotaciones.Enabled = false;
                dgrHorasSemana.Enabled = false;
            }

            LimpiarForm();
            try
            {
                //obtener datos un click en la fila y pasarlo a cajas de texto
                if (dgrListarFuncionario.SelectedRows.Count > 0)
                {
                    var row = dgrListarFuncionario.SelectedRows[0];

                    DataGridViewCell identificacion = row.Cells["clmidfun"];
                    DataGridViewCell puesto = row.Cells["clmpuestofun"];
                    DataGridViewCell horarioId = row.Cells["clmhorarioidfun"];
                    DataGridViewCell nombre = row.Cells["clmnombrefun"];
                    DataGridViewCell apellido = row.Cells["clmapellidosfun"];
                    DataGridViewCell nacimiento = row.Cells["clmnaciofun"];
                    DataGridViewCell genero = row.Cells["clmgenerofun"];
                    DataGridViewCell nacionalidad = row.Cells["clmpaisfun"];
                    DataGridViewCell estadocivil = row.Cells["clmcivilfun"];
                    DataGridViewCell correo = row.Cells["clmcorreofun"];
                    DataGridViewCell telefono = row.Cells["clmtelefonofun"];
                    DataGridViewCell ciudad = row.Cells["clmciudadfun"];
                    DataGridViewCell provincia = row.Cells["clmprovinciafun"];
                    DataGridViewCell direccion = row.Cells["clmdireccionfun"];
                    DataGridViewCell anotaciones = row.Cells["clmanotacionesfun"];

                    txtID.Text = identificacion.Value?.ToString();
                    global = Convert.ToInt32(identificacion.Value);//se nesecita para eliminar un funcionario
                    comboPuesto.Items.Add(puesto.Value?.ToString());//add the item and then selected
                    comboPuesto.SelectedItem = puesto.Value?.ToString();
                    txtNombre.Text = nombre.Value?.ToString();
                    string[] unApellido = apellido.Value?.ToString().Split(' ');//separar el apellido
                    string primerApellido = unApellido[0];
                    string segundoApellido = unApellido[1];
                    txtApellido1.Text = primerApellido;
                    txtApellido2.Text = segundoApellido;
                    dateNacimiento.Value = DateTime.TryParse(nacimiento.Value?.ToString(), out DateTime nacimientoValue) ? nacimientoValue : dateNacimiento.Value;
                    radioHombre.Checked = genero.Value?.ToString() == "Masculino";
                    radioMujer.Checked = genero.Value?.ToString() == "Femenino";
                    txtNacionalidad.Text = nacionalidad.Value?.ToString();
                    comboEstadoCivil.Items.Add(estadocivil.Value?.ToString());//add the item and then selected
                    comboEstadoCivil.SelectedItem = estadocivil.Value?.ToString();
                    txtTelefono.Text = telefono.Value?.ToString();
                    txtCorreo.Text = correo.Value?.ToString();
                    comboCiudades.Items.Add(ciudad.Value?.ToString());//add the item and then selected
                    comboCiudades.SelectedItem = ciudad.Value?.ToString();
                    comboProvincias.Items.Add(provincia.Value?.ToString());//add the item and then selected
                    comboProvincias.SelectedItem = provincia.Value?.ToString();
                    txtDetallesDireccion.Text = direccion.Value?.ToString();
                    txtAnotaciones.Text = anotaciones.Value?.ToString();
                    idDeHorario = (int)horarioId.Value;//recupera el id lo manda por parametro para cargar el horario 
                    CargarListaHorarios("", idDeHorario);//recupera el horario en el data grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Casilla de ingreso de horario control
        private void DayOfWeek_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            bool visibilidad = false;
            if (checkBox.Checked)
            {
                CheckBox[] checkBoxes = { checkLunes, checkMartes, checkMiercoles, checkJueves, checkViernes, checkSabado, checkDomingo };
                //deshabilita las casillas para que no hayan problemas
                foreach (var boxes in checkBoxes)
                {
                    if (boxes.Text != checkBox.Text)
                    {
                        boxes.Enabled = false;
                    }
                }
                visibilidad = true;
                lblEntrada.ForeColor = Color.Red;
                lblSalida.ForeColor = Color.Red;
                diaSemana = checkBox.Text;//el dia que se elige
                horaEntrada = string.Empty;//limpiar las horas cada vez para comparar....
                horaSalida = string.Empty;//.....si estan llenos ambos campos se puede guardar.
            }
            else if (!checkBox.Checked)
            {
                CheckBox[] checkBoxes = { checkLunes, checkMartes, checkMiercoles, checkJueves, checkViernes, checkSabado, checkDomingo };
                //inhabilida la casillas para seleccionar libremente
                foreach (var boxes in checkBoxes)
                {
                    if (boxes.Text != checkBox.Text)
                    {
                        boxes.Enabled = true;
                    }
                }
                visibilidad = false;
                lblEntrada.ForeColor = Color.Black;
                lblSalida.ForeColor = Color.Black;
                checkBox.Checked = false;
                diaSemana = string.Empty;//dia de la semana ya no se elige
                btnGuardarDia.Visible = false;
                btnTodosIguales.Visible = false;
            }

            //casilla de horario visible o invisibles
            lblEntrada.Visible = visibilidad;
            lblSalida.Visible = visibilidad;
            comboEntrada.Visible = visibilidad;
            comboSalida.Visible = visibilidad;
        }
        //informacion de horario de entrada
        private void comboEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEntrada.ForeColor = Color.Black;
            horaEntrada = comboEntrada.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(horaSalida))//si la salida ya esta
            {
                btnGuardarDia.Visible = true;
                btnTodosIguales.Visible = true;
            }
        }

        //informacion de horario de salida
        private void comboSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSalida.ForeColor = Color.Black;
            horaSalida = comboSalida.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(horaEntrada))//si la entrada ya esta
            {
                btnGuardarDia.Visible = true;
                btnTodosIguales.Visible = true;
            }

        }

        //guardar los datos en una lista e imprimir en datagridview
        private void btnGuardarDia_Click(object sender, EventArgs e)
        {

            string horasTrabajo = $"{horaEntrada}-{horaSalida}";
            string nombreCelda = string.Empty;

            switch (diaSemana)
            {
                case "Lunes":
                    nombreCelda = "lunes";
                    Horasxdia[0] = horasTrabajo;
                    break;
                case "Martes":
                    nombreCelda = "martes";
                    Horasxdia[1] = horasTrabajo;
                    break;
                case "Miércoles":
                    nombreCelda = "miercoles";
                    Horasxdia[2] = horasTrabajo;
                    break;
                case "Jueves":
                    nombreCelda = "jueves";
                    Horasxdia[3] = horasTrabajo;
                    break;
                case "Viernes":
                    nombreCelda = "viernes";
                    Horasxdia[4] = horasTrabajo;
                    break;
                case "Sábado":
                    nombreCelda = "sabado";
                    Horasxdia[5] = horasTrabajo;
                    break;
                case "Domingo":
                    nombreCelda = "domingo";
                    Horasxdia[6] = horasTrabajo;
                    break;
            }
            DataGridViewCell celda = dgrHorasSemana.Rows[0].Cells[nombreCelda];
            celda.Value = horasTrabajo;

            CheckBox[] checkBoxes = { checkLunes, checkMartes, checkMiercoles, checkJueves, checkViernes, checkSabado, checkDomingo };
            //inhabilida la casillas para seleccionar libremente
            foreach (var boxes in checkBoxes)
            {
                boxes.Enabled = true;
            }
            EsconderBotonesHorario();
        }

        //llenar toda la semana con los primeros datos
        private void btnTodosIguales_Click(object sender, EventArgs e)
        {
            string horasTrabajo = $"{horaEntrada}-{horaSalida}";
            CheckBox[] checkBoxes = { checkLunes, checkMartes, checkMiercoles, checkJueves, checkViernes, checkSabado, checkDomingo };
            string[] semana = new string[] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
            foreach (var boxes in checkBoxes)
            {
                boxes.Checked = true;
                boxes.Enabled = false;
                DataGridViewCell celda = dgrHorasSemana.Rows[0].Cells[semana[Array.IndexOf(checkBoxes, boxes)]];
                celda.Value = horasTrabajo;
            }
            EsconderBotonesHorario();
        }

        //desaparece algunos elementos de horario tempotalmente
        private void EsconderBotonesHorario()
        {
            lblEntrada.ForeColor = Color.Black;
            lblSalida.ForeColor = Color.Black;
            lblEntrada.Visible = false;
            lblSalida.Visible = false;
            diaSemana = string.Empty;//dia de la semana ya no se elige
            horaEntrada = string.Empty;
            horaSalida = string.Empty;
            btnGuardarDia.Visible = false;
            btnTodosIguales.Visible = false;
            comboEntrada.Visible = false;
            comboSalida.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarFuncionario_Click(object sender, EventArgs e)
        {
            BLHorarioFuncionarios logicaHorarioFuncionarios = new BLHorarioFuncionarios(Configuracion.getCadenaConeccion);
            BLFuncionarios logicaFuncionario = new BLFuncionarios(Configuracion.getCadenaConeccion);//conexion
            if (yesORnot("Desea elimirar este registro?"))
            {
                logicaHorarioFuncionarios.LlamarEliminarHorarioFuncionario(idDeHorario);
                logicaFuncionario.LlamarEliminarFuncionario(global);//global es el id de la especialidad por borrar
                CargarListaFuncionario();//actualiazar datos
                MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarForm();
            }
        }

        //eliminar si o no?
        static bool yesORnot(string aviso)
        {
            DialogResult result = MessageBox.Show(aviso, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool respuesta = (result == DialogResult.Yes);
            return respuesta;
        }

        //buscar funcionario
        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            //filtrar los datos y recuperar el cliente deseado
            string busqueda = "";
            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    //el nombre tiene en la cadena tiene que ser igual al de al entidad de la base de datos en c# 
                    busqueda = string.Format("FUNCIONARIO_ID LIKE '%{0}%'", txtID.Text.ToString().Trim());
                }
                else
                {
                    MessageBox.Show("Debe de escribir al menos una letra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Focus();
                }
                CargarListaFuncionario(busqueda);//pasamos lo que vamos a filtrar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
