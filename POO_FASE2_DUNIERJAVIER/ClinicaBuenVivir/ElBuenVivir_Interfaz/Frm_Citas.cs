using ElBuenVivir_Entidades;
using ElBuenVivir_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Citas : Form
    {
        private List<int> horasDisponibles;
        private string horaDCita = string.Empty;
        private string accion = "nuevo";
        private int medEspId = 0;
        private int horarioId = 0;

        public Frm_Citas()
        {
            InitializeComponent();
            dgrHorasDisponibles.CellFormatting += dgrHorasDisponibles_CellFormatting;
        }

        public void Frm_Horarios_Load(object sender, EventArgs e)
        {
            //horasDisponibles = CargarListaHorarios("", new DateTime(2023, 6, 18));
            //llenarHoras();
            //DisableUnavailableDates();
            CargarListaCitas();
            CargarListaMedicos();
        }

        // cargar Medicos del al base de datos a un combobox
        public void CargarListaMedicos(string condicion = "")
        {
            BLMedicos logicaMedicos = new BLMedicos(Configuracion.getCadenaConeccion);
            List<EntidadMedicos> medicos;
            try
            {
                medicos = logicaMedicos.llamarListarMedicos(condicion);
                if (medicos.Count > 0)
                {
                    comboMedicos.DataSource = medicos;
                    comboMedicos.DisplayMember = "Nombre";
                    comboMedicos.ValueMember = "Identificacion";

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //cuando busca un dia carga las horas
        private void dateFechaCita_ValueChanged(object sender, EventArgs e)
        {

            LlenarHoras(dateFechaCita.Value.Date, "");
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

        private void LlenarHoras(DateTime fecha, string condicion = "")
        {
            // Obtener la lista de horarios desde la base de datos
            BLHorarios logicaHorarios = new BLHorarios(Configuracion.getCadenaConeccion);
            List<EntidadHorario> horariosDisponibles = logicaHorarios.llamarListarHorarios(condicion);

            // Limpia el DataGridView antes de insertar los datos
            dgrHorasDisponibles.Rows.Clear();

            // Recorre las horas de 6 a 17 con incrementos de 30 minutos
            for (int hora = 6; hora <= 17; hora++)
            {
                bool ocupado = false;

                // Verifica si la hora actual está dentro de algún horario disponible
                foreach (EntidadHorario horario in horariosDisponibles)
                {
                    DateTime horaInicio = DateTime.Parse(horario.HoraInicio);
                    DateTime horaSalida = DateTime.Parse(horario.HoraFin);
                    DateTime fechaHorario = DateTime.Parse(horario.Fecha);

                    // Verifica si la hora actual está dentro del rango de horario
                    if (fecha.Date == fechaHorario.Date && hora >= horaInicio.Hour && hora <= horaSalida.Hour)
                    {
                        ocupado = true;
                        break;
                    }
                }

                // Inserta la hora y el estado correspondiente en una nueva fila
                dgrHorasDisponibles.Rows.Add(hora.ToString("00") + ":00", ocupado ? "Ocupado" : "Disponible");
                dgrHorasDisponibles.Rows.Add(hora.ToString("00") + ":30", ocupado ? "Ocupado" : "Disponible");
            }
        }


        private void dgrHorasDisponibles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1) // Verificar las columnas de hora y estado
            {
                DataGridViewCell estadoCell = dgrHorasDisponibles.Rows[e.RowIndex].Cells[1]; // Obtener la celda adyacente de estado

                if (estadoCell.Value != null && estadoCell.Value != DBNull.Value)
                {
                    string estado = estadoCell.Value.ToString();

                    if (estado == "Ocupado")
                    {
                        e.CellStyle.BackColor = Color.Gray; // Establecer el color de fondo en rojo para las celdas ocupadas
                    }
                    else if (estado == "Disponible")
                    {
                        e.CellStyle.BackColor = Color.LightGray; // Establecer el color de fondo en verde para las celdas disponibles
                    }
                }
            }
        }

        private void dgrHorasDisponibles_Click(object sender, EventArgs e)
        {
            if (dgrHorasDisponibles.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgrHorasDisponibles.SelectedRows[0];
                // Accede a las celdas en el orden correcto utilizando el índice real de la columna
                DataGridViewCell horaCita = row.Cells[dgrHorasDisponibles.Columns["horas"].Index];
                DataGridViewCell estado = row.Cells[dgrHorasDisponibles.Columns["estado"].Index];
                if (estado.Value.ToString() == "Disponible")
                {

                    MessageBox.Show($"Cita a las: {horaCita.Value.ToString()}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    horaDCita = horaCita.Value.ToString();
                    //obtenerId();
                    //LlenarHoras(dateFechaCita.Value.Date, "");
                }
                else
                {
                    MessageBox.Show("No disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }


        //crear horario object
        private EntidadHorario CrearHorario()
        {
            EntidadHorario unHorario = new EntidadHorario();
            unHorario.Fecha = dateFechaCita.Value.Date.ToShortDateString();
            unHorario.HoraInicio = horaDCita;
            unHorario.HoraFin = horaDCita;
            return unHorario;
        }

        //Crear cita object
        private EntidadCitas CrearCita() 
        {
            EntidadCitas unaCita = new EntidadCitas();
            unaCita.IdMedicosEspecialidades = medEspId;
            unaCita.HorarioId = horarioId;
            unaCita.Estado = comboEstado.SelectedItem.ToString();
            unaCita.Motivo = txtMotivo.Text;
            unaCita.Observaciones = txtObservaciones.Text;
            unaCita.Metodo_Pago = comboMetodoPago.SelectedItem.ToString();
            if (checkPagoSi.Checked)
            {
                unaCita.Pagado = "Si";
            }
            else { unaCita.Pagado = "No"; }
            return unaCita;
        }

        //obtener horario_id
        private void obtenerId()
        {
            EntidadHorario unHorario = new EntidadHorario();//objeto
            BLCitas logicaHorario = new BLCitas(Configuracion.getCadenaConeccion);//conexion
            try
            {
                if (!VerificarCamposTexto())//si no tiene texto                   
                {
                    MessageBox.Show("ooops! Faltan datos favor revisar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (accion == "nuevo")
                    {
                        unHorario = CrearHorario();//crea objeto horario
                        horarioId = logicaHorario.LlamarInsertarHorario(unHorario);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadCitas lacita = new EntidadCitas();//objeto
            BLCitas logicaCita = new BLCitas(Configuracion.getCadenaConeccion);//conexion
    
            try
            {
                if (!VerificarCamposTexto())//si no tiene texto                   
                {
                    MessageBox.Show("ooops! Faltan datos favor revisar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (accion == "nuevo")
                    {
                        //Estos datos se mandan a la base de datos y regresa id de cita para plataforma
                        //asociar con paciente pero no me da tiempo de seguir
                        obtenerId();
                        EntidadCitas cita = new EntidadCitas();
                        cita = CrearCita();
                        string mensaje = "Datos de la cita:\n";
                        mensaje += "IdMedicosEspecialidades: " + cita.IdMedicosEspecialidades + "\n";
                        mensaje += "HorarioId: " + cita.HorarioId + "\n";
                        mensaje += "Estado: " + cita.Estado + "\n";
                        mensaje += "Motivo: " + cita.Motivo + "\n";
                        mensaje += "Observaciones: " + cita.Observaciones + "\n";
                        mensaje += "Método de Pago: " + cita.Metodo_Pago + "\n";
                        mensaje += "Pagado: " + cita.Pagado;

                        MessageBox.Show(mensaje);
                        //lacita = CrearCita();//crea objeto horario
                        //int cita_id = logicaCita.(lacita);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //verificar campos
        public bool VerificarCamposTexto()
        {
            bool todosTienenLetras = true;
            if (string.IsNullOrEmpty(txtMotivo.Text))
            {
                todosTienenLetras = false;
            }
            if (string.IsNullOrEmpty(txtObservaciones.Text))
            {
                todosTienenLetras = false;
            }
            if (string.IsNullOrEmpty(txtID.Text))
            {
                todosTienenLetras = false;
            }
            if (string.IsNullOrEmpty(horaDCita))
            {
                todosTienenLetras = false;
            }
            if (comboEstado.SelectedIndex == -1)
            {
                todosTienenLetras = false;
            }
            if (comboMetodoPago.SelectedIndex == -1)
            {
                todosTienenLetras = false;
            }
            if (!checkPagoSi.Checked & !checkPagoNo.Checked)
            {
                todosTienenLetras = false;
            }


            return todosTienenLetras;
        }

        
        private void comboMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedItem != null)
            {
                string selectedID = comboBox.SelectedValue.ToString();
                if (int.TryParse(selectedID, out int medicoID))
                {
                    BLMedicos_Especialidades logicaMedicosEspecialidades = new BLMedicos_Especialidades(Configuracion.getCadenaConeccion);
                    medEspId = 0;
                    try
                    {
                        medEspId = logicaMedicosEspecialidades.llamarIdMedicosEspecialidades(medicoID);
                        
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
