using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using ElBuenVivir_Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Citas : Form
    {
        private string horaDCita = string.Empty;//hora seleccionada para la cita
        private string nombreCompleto = "";
        private string accion = "nuevo";
        private int idPaciente = 0;
        private int medicoId;
        private int aux = 0;
        private bool cargando;
        private int horaInicio = 0;
        private int horaFin = 0;
        private int checkHorarioPagos = 0;//existe un id de horario y de pago para proseguir
        public static string CitasIdCita { get; set; }//un valor que tengo que mandar a plataforma

        public Frm_Citas(int idPaciente, string nombrePaciente)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;//id desde plataforma
            this.nombreCompleto = nombrePaciente;
            comboMedicos.SelectedIndexChanged += comboMedicos_SelectedIndexChanged;//seleccionar medico y obtener su id
        }


        public void Frm_Horarios_Load(object sender, EventArgs e)
        {
            cargando = true;
            LimpiarCasillas();
            txtID.Text = idPaciente.ToString();//id desde plataforma
            txtNombreCompleto.Text = nombreCompleto.ToString();
            //cargar medicos en combobox
            List<EntidadFuncionario> listaMedicos = ObtenerListaMedicos();
            comboMedicos.DisplayMember = "Nombre"; // Reemplaza "NombreMedico" por la propiedad que deseas mostrar en el ComboBox
            comboMedicos.DataSource = listaMedicos;
            //CargarListaCitas();
            cargando = false;
        }

        // (0A) Carga la lista datagridview
        public void CargarListaCitas(string condicion = "")
        {
            BLCitas logicaCita = new BLCitas(Configuracion.getCadenaConeccion);
            List<EntidadCitas> cita;
            try
            {
                cita = logicaCita.llamarListarCitas(condicion);
                if (cita.Count > 0)
                {
                    //dgrListarCitas.DataSource = cita;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //crear horario object
        private EntidadHorario CrearHorario()
        {
            TimeSpan intervalo = TimeSpan.FromMinutes(30);//4 linas de convercion agregando 30minutos a la hora de entrada de la cita
            DateTime dt = DateTime.ParseExact(horaDCita, "HH:mm", null);
            dt = dt.Add(intervalo);
            string horaSalida = dt.ToString("HH:mm");
            EntidadHorario unHorario = new EntidadHorario();
            unHorario.FechaHorario = dateFechaCita.Value.Date.ToString("yyyy/MM/dd");//fecha
            unHorario.HoraInicio = horaDCita;//hora entrada
            unHorario.HoraFin = horaSalida;//hora salida
            unHorario.MedicoId = medicoId;//id del medico que atendera en la cita
            return unHorario;
        }

        //crear pago object
        private EntidadPagos CrearPago()
        {
            EntidadPagos unPago = new EntidadPagos();
            unPago.Monto = decimal.Parse(txtMontoPagar.Text);
            unPago.MetodoPago = comboMetodoPago.SelectedItem.ToString();

            return unPago;
        }

        //la hora seleccionada de la cita antes de enviar al db para obterner un id
        private void comboHorasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            horaDCita = comboHorasDisponibles.SelectedItem.ToString();//hora seleccionada para la cita

        }

        //Crear cita object
        private EntidadCitas CrearCita()
        {
            EntidadCitas unaCita = new EntidadCitas();
            unaCita.HorarioId = ObtenerHorarioId();
            unaCita.PagosId = ObtenerPagoID();
            unaCita.Estado = comboEstado.SelectedItem.ToString();
            unaCita.Motivo = txtMotivo.Text;
            unaCita.Observaciones = txtObservaciones.Text;
            unaCita.Metodo_Pago = comboMetodoPago.SelectedItem.ToString();

            return unaCita;
        }

        //obtener horario_id
        private int ObtenerHorarioId()
        {
            int getHorarioId = 0;
            EntidadHorario unHorario = new EntidadHorario();//objeto
            BLHorario logicaHorario = new BLHorario(Configuracion.getCadenaConeccion);//conexion
            try
            {
                unHorario = CrearHorario();//crea objeto horario
                getHorarioId = logicaHorario.LlamarInsertarHorario(unHorario);
                if (getHorarioId > 0) checkHorarioPagos++;// 2 significa que puede progeguir
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return getHorarioId;
        }

        //obtener pago id
        private int ObtenerPagoID()
        {
            int getPagosId = 0;
            EntidadPagos unPago = new EntidadPagos();//objeto
            BLPagos logicaPagos = new BLPagos(Configuracion.getCadenaConeccion);//conexion
            try
            {
                unPago = CrearPago();//crea objeto pago
                getPagosId = logicaPagos.LlamarInsertarPago(unPago);
                if (getPagosId > 0) checkHorarioPagos++;//2 significa que puede progeguir
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return getPagosId;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadCitas laCita = new EntidadCitas();//objeto
            BLCitas logicaCita = new BLCitas(Configuracion.getCadenaConeccion);//conexion

            try
            {
                if (!VerificarCamposTexto() && checkHorarioPagos != 2)//si no tiene texto o no hay ids de horario y pagos            
                {
                    MessageBox.Show("ooops! Faltan datos favor revisar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (accion == "nuevo")
                    {
                        //Estos datos se mandan a la base de datos y regresa id de cita para plataforma                                     
                        laCita = CrearCita();//creacion del objeto cita
                        int idCita = logicaCita.LlamarInsertarCita(laCita);
                        txtNumCita.Text = idCita.ToString();//numero obtenido del db
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CompararHorasDisponibles()
        {
            // Obtener la lista de horas disponibles
            List<string> horasDisponibles = new List<string>();

            // Obtener la lista de horas generadas
            List<string> listaHoras = GenerarListaHoras();

            // Obtener la lista de horarios de la base de datos
            List<EntidadHorario> horariosBaseDatos = ObtenerHorarioBaseDatos();

            // Iterar sobre la lista de horas generadas
            foreach (string hora in listaHoras)
            {
                // Verificar si la hora no está en la lista de horarios de la base de datos
                if (!horariosBaseDatos.Any(horario => horario.HoraInicio == hora))
                {
                    // La hora no está en la base de datos, agregarla a la lista de horas disponibles
                    horasDisponibles.Add(hora);
                }
            }

            // Llenar el ComboBox con las horas disponibles
            comboHorasDisponibles.DataSource = horasDisponibles;
        }

        //busca en la base de datos todos los horarios
        private List<EntidadHorario> ObtenerHorarioBaseDatos()
        {
            List<EntidadHorario> horarioBaseDatos = new List<EntidadHorario>();
            BLHorario logicaHorario = new BLHorario(Configuracion.getCadenaConeccion);

            try
            {
                string fechaSeleccionada = dateFechaCita.Value.ToString("yyyy/MM/dd");
                horarioBaseDatos = logicaHorario.llamarListarHorario($"FECHA = '{fechaSeleccionada.Trim()}'");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return horarioBaseDatos;
        }

        //genera una lista de horas cada 30 minutos
        private List<string> GenerarListaHoras()
        {
            List<string> horas = new List<string>();
            TimeSpan intervalo = TimeSpan.FromMinutes(30);
            TimeSpan horaActual = TimeSpan.FromHours(horaInicio);

            while (horaActual <= TimeSpan.FromHours(horaFin))
            {
                string hora = horaActual.ToString(@"hh\:mm");
                horas.Add(hora);
                horaActual = horaActual.Add(intervalo);
            }
            return horas;
        }

        //busca en la base de datos todos los MEDICOS y los guarda en una lista
        private List<EntidadFuncionario> ObtenerListaMedicos(string condicion = "")
        {
            List<EntidadFuncionario> listaMedicos = new List<EntidadFuncionario>();
            BLFuncionarios logicaMedicos = new BLFuncionarios(Configuracion.getCadenaConeccion);

            try
            {
                listaMedicos = logicaMedicos.llamarListarMedicos(condicion);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaMedicos;
        }

        //*******************************************************************************************************************************************
        //limpiar casilla
        private void LimpiarCasillas()
        {
            // Clear textboxes
            txtID.Text = string.Empty;
            txtNumCita.Text = string.Empty;
            txtMotivo.Text = string.Empty;
            txtNombreCompleto.Clear();
            txtObservaciones.Text = string.Empty;
            comboMedicos.SelectedItem = null;
            comboEstado.SelectedItem = null;
            comboMetodoPago.SelectedItem = null;

        }

        //verificar campos
        public bool VerificarCamposTexto()
        {
            bool todosTienenLetras = true;

            if (string.IsNullOrEmpty(txtMotivo.Text) ||
                string.IsNullOrEmpty(txtObservaciones.Text) ||
                string.IsNullOrEmpty(txtID.Text) ||
                string.IsNullOrEmpty(horaDCita) ||
                comboEstado.SelectedIndex == -1 ||
                comboMetodoPago.SelectedIndex == -1)
            {
                todosTienenLetras = false;
            }

            return todosTienenLetras;
        }

        //salir del form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //valores del datetimepicker han cambiado y revisar si el medico esta disponible
        private void dateFechaCita_ValueChanged(object sender, EventArgs e)
        {
            List<EntidadDiaHorario> listaDiaHorario = new List<EntidadDiaHorario>();
            BLDiaHorario logicaDiaHorario = new BLDiaHorario(Configuracion.getCadenaConeccion);
            aux = 1;//permite procesar unicamente un cambio en el datetimepicker
            string diaSemana = dateFechaCita.Value.ToString("dddd", new System.Globalization.CultureInfo("es-ES")).ToUpper();//dia en espanol upper
            if (diaSemana == "MIÉRCOLES") diaSemana = "MIERCOLES";
            if (diaSemana == "SÁBADO") diaSemana = "SABADO";
            // diaSemana.Trim();
            string condicion = $"FUNCIONARIO_ID = '{medicoId}'";

            try
            {
                // diccionario de dias y sus propiedades
                Dictionary<string, Func<EntidadDiaHorario, string>> dayMappings = new Dictionary<string, Func<EntidadDiaHorario, string>>()
                {
                    { "LUNES", (diaHorario) => diaHorario.Lunes },
                    { "MARTES", (diaHorario) => diaHorario.Martes },
                    { "MIERCOLES", (diaHorario) => diaHorario.Miercoles },
                    { "JUEVES", (diaHorario) => diaHorario.Jueves },
                    { "VIERNES", (diaHorario) => diaHorario.Viernes },
                    { "SABADO", (diaHorario) => diaHorario.Sabado },
                    { "DOMINGO", (diaHorario) => diaHorario.Domingo }
                };

                listaDiaHorario = logicaDiaHorario.llamarListarHorarioDia(condicion, diaSemana);
                foreach (EntidadDiaHorario diaHorario in listaDiaHorario)
                {
                    // propiedad segun el dia de la semana
                    if (dayMappings.TryGetValue(diaSemana, out var getProperty))
                    {
                        string horario = getProperty(diaHorario);
                        if (horario != "--Libre--")
                        {
                            string[] partes = horario.Split('-');
                            string horaInicioString = partes[0].Split(':')[0];
                            string horaFinString = partes[1].Split(':')[0];
                            horaInicio = int.Parse(horaInicioString);
                            horaFin = int.Parse(horaFinString);
                            comboHorasDisponibles.Items.Add("00:00");//add the item and then selected
                            comboHorasDisponibles.Text = "00:00";
                            comboHorasDisponibles.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("No esta disponible este dia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //se generan una lista firtrada de horas dependiedo unicamente de la ultima fecha seleccionada en el datetimepicker
        private void comboHorasDisponibles_Click(object sender, EventArgs e)
        {
            if (aux == 1)
            {
                CompararHorasDisponibles();
                aux++;
            }
        }

        //cuando se selecciona un medico se almacena su id para el horario
        private void comboMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cargando)
            {
                // Obtener el médico seleccionado del ComboBox
                EntidadFuncionario medicoSeleccionado = comboMedicos.SelectedItem as EntidadFuncionario;
                medicoId = medicoSeleccionado.Identificacion;//id del medico seleccionado para la cita
                dateFechaCita.Enabled = true;
            }
        }

        //cuando este formlulario se cierre envie el id de la cita
        private void Frm_Citas_FormClosing(object sender, FormClosingEventArgs e)
        {
            CitasIdCita = txtNumCita.Text;
        }

        private void Frm_Citas_Load(object sender, EventArgs e)
        {

        }     
    }
}
