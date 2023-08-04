using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ElBuenVivir_Entidades;
using ElBuenVivir_Logica;

namespace SitioWeb
{
    public partial class Citas : System.Web.UI.Page
    {
        private int horaInicio = 0;
        private int horaFin = 0;
        private int aux = 0;
        private string messageScript = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Make sure this code only runs on the initial page load, not on postbacks
            {
                List<EntidadFuncionario> listaMedicos = ObtenerListaMedicos();

                // Find the DropDownList control
                DropDownList selectMedico = (DropDownList)panel3.FindControl("selectMedico");

                // Clear the existing items in the DropDownList (optional, if you want to refresh the list)
                selectMedico.Items.Clear();

                // Loop through the "listaMedicos" and add each item to the DropDownList
                foreach (EntidadFuncionario medico in listaMedicos)
                {
                    selectMedico.Items.Add(new ListItem(medico.Nombre, medico.Identificacion.ToString()));
                }

                // Generate the list of available time slots
                CompararHorasDisponibles();
                //auto llenar casillas
                txtIdPaciente.Text = Session["IdUsuario"].ToString();
                txtNombreCompleto.Text = Session["NombreCompleto"].ToString();
                string condicion = $"PA.PACIENTE_ID = '{Session["IdUsuario"]}'";
                CargarListarMisCitas(condicion);//cargar gridview con mis citas
            }


        }

        //busca en la base de datos todos los MEDICOS y los guarda en una lista
        private List<EntidadFuncionario> ObtenerListaMedicos(string condicion = "")
        {
            List<EntidadFuncionario> listaMedicos = new List<EntidadFuncionario>();
            BLFuncionarios logicaMedicos = new BLFuncionarios(clsConfiguracion.getConnectionString);

            try
            {
                listaMedicos = logicaMedicos.llamarListarMedicos(condicion);
            }
            catch (Exception)
            {

            }
            return listaMedicos;
        }

        //fecha seleccionada por el paciente
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            // The user clicked on a date, and the selected date is available in the SelectedDate property of the Calendar control.
            DateTime selectedDate = Calendario.SelectedDate;
            List<EntidadDiaHorario> listaDiaHorario = new List<EntidadDiaHorario>();
            BLDiaHorario logicaDiaHorario = new BLDiaHorario(clsConfiguracion.getConnectionString);
            aux = 1;//permite procesar unicamente un cambio en el calendario
            string diaSemana = selectedDate.ToString("dddd", new System.Globalization.CultureInfo("es-ES")).ToUpper();//dia en espanol upper
            if (diaSemana == "MIÉRCOLES") diaSemana = "MIERCOLES";
            if (diaSemana == "SÁBADO") diaSemana = "SABADO";
            // diaSemana.Trim();
            string condicion = $"FUNCIONARIO_ID = '{Session["MedicoId"]}'";

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
                            selectHora.Items.Add("00:00");
                            selectHora.Text = "00:00";
                            selectHora.Enabled = true;
                            if (aux == 1)
                            {
                                CompararHorasDisponibles();
                                aux++;
                            }
                        }
                        else
                        {
                            messageScript = string.Format("alert('No esta disponible este dia')");
                            ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
                        }
                    }
                }
            }
            catch (Exception)
            {
                //// Display the error message in the alert
                //string errorMessage = $"Ha ocurrido un error: {ex.Message}";
                //string encodedErrorMessage = System.Web.HttpUtility.JavaScriptStringEncode(errorMessage);
                //messageScript = string.Format("alert('{0}')", encodedErrorMessage);
                //ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
            }
        }

        //*************************************************************************************************************************

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


        private int ObtenerIdMedico(string nombre)
        {
            int idMedico = -1; // Default value if the MEDICO is not found
            BLFuncionarios logicaMedicos = new BLFuncionarios(clsConfiguracion.getConnectionString);

            try
            {
                List<EntidadFuncionario> listaMedicos = logicaMedicos.llamarListarMedicos();
                EntidadFuncionario medicoEncontrado = listaMedicos.Find(m => m.Nombre == nombre);

                if (medicoEncontrado != null)
                {
                    idMedico = medicoEncontrado.Identificacion; // Assuming the ID property is named 'Id'
                }
            }
            catch (Exception)
            {
                // Handle any exceptions here, if required
            }

            return idMedico;
        }

        protected void DropDownFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // id del medico
            Session["MedicoId"] = ObtenerIdMedico(selectMedico.SelectedItem.ToString());
            Calendario.Enabled = true;
        }

        protected void dropdownHora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //*************************************************************************************************************************
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

            // Llenar el DropDownList con las horas disponibles
            selectHora.DataSource = horasDisponibles;
            selectHora.DataBind();
        }
        //*************************************************************************************************************************
        //busca en la base de datos todos los horarios
        private List<EntidadHorario> ObtenerHorarioBaseDatos()
        {
            List<EntidadHorario> horarioBaseDatos = new List<EntidadHorario>();
            BLHorario logicaHorario = new BLHorario(clsConfiguracion.getConnectionString);

            try
            {
                string fechaSeleccionada = Calendario.SelectedDate.ToString("yyyy/MM/dd");
                horarioBaseDatos = logicaHorario.llamarListarHorario($"FECHA = '{fechaSeleccionada.Trim()}'");
            }
            catch (Exception ex)
            {
                // Display the error message in the alert
                string errorMessage = $"Ha ocurrido un error: {ex.Message}";
                string encodedErrorMessage = System.Web.HttpUtility.JavaScriptStringEncode(errorMessage);
                messageScript = string.Format("alert('{0}')", encodedErrorMessage);
                ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
            }
            return horarioBaseDatos;
        }

        protected void guardarCita_Click(object sender, EventArgs e)
        {
            EntidadCitas laCita = new EntidadCitas();//objeto
            BLCitas logicaCita = new BLCitas(clsConfiguracion.getConnectionString);//conexion

            try
            {//al menos calendario y hora tienen que estar seleccionados
                if (selectHora.SelectedItem.ToString().Trim().Equals("00:00", StringComparison.OrdinalIgnoreCase) && Calendario.SelectedDate <= DateTime.Now)
                {
                    messageScript = string.Format("alert('Fecha y hora son necesarios para la cita')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
                }
                else
                {
                    laCita = CrearCita();//creacion del objeto cita
                    int idCita = logicaCita.LlamarInsertarCita(laCita);
                    Session["IdCita"] = idCita;
                    messageScript = string.Format($"alert('Cita apartada con éxito')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
                    InsertarPlataforma();//
                    string condicion = $"PA.PACIENTE_ID = '{Session["IdUsuario"]}'";
                    CargarListarMisCitas(condicion);//cargar gridview con mis citas
                }
            }
            catch (Exception ex)
            {
                // Display the error message in the alert
                string errorMessage = $"Ha ocurrido un error: {ex.Message}";
                string encodedErrorMessage = System.Web.HttpUtility.JavaScriptStringEncode(errorMessage);
                messageScript = string.Format("alert('{0}')", encodedErrorMessage);
                ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
            }
        }
        //*************************************************************************************************************************
        //Crear cita object
        private EntidadCitas CrearCita()
        {
            EntidadCitas unaCita = new EntidadCitas();
            unaCita.HorarioId = ObtenerHorarioId();
            unaCita.PagosId = ObtenerPagoID();
            unaCita.Estado = selectEstado.SelectedItem.ToString();
            unaCita.Motivo = txtMotivo.Text;
            unaCita.Observaciones = txtObservaciones.Text;
            unaCita.Metodo_Pago = selectMetodoPago.SelectedItem.ToString();

            return unaCita;
        }

        //obtener horario_id
        private int ObtenerHorarioId()
        {
            int getHorarioId = 0;
            EntidadHorario unHorario = new EntidadHorario();//objeto
            BLHorario logicaHorario = new BLHorario(clsConfiguracion.getConnectionString);//conexion
            try
            {
                unHorario = CrearHorario();//crea objeto horario
                getHorarioId = logicaHorario.LlamarInsertarHorario(unHorario);
                //id de harario
                int currentHorariopagos = Convert.ToInt32(Session["horariopagos"]);
                currentHorariopagos++;
                Session["horariopagos"] = currentHorariopagos;
            }
            catch (Exception)
            {

            }
            return getHorarioId;
        }

        //obtener pago id
        private int ObtenerPagoID()
        {
            int getPagosId = 0;
            EntidadPagos unPago = new EntidadPagos();//objeto
            BLPagos logicaPagos = new BLPagos(clsConfiguracion.getConnectionString);//conexion
            try
            {
                unPago = CrearPago();//crea objeto pago
                getPagosId = logicaPagos.LlamarInsertarPago(unPago);
                //id de harario
                int currentHorariopagos = Convert.ToInt32(Session["horariopagos"]);
                currentHorariopagos++;
                Session["horariopagos"] = currentHorariopagos;

            }
            catch (Exception)
            {

            }
            return getPagosId;
        }

        // crear horario object
        private EntidadHorario CrearHorario()
        {
            EntidadHorario unHorario = new EntidadHorario();
            unHorario.FechaHorario = Calendario.SelectedDate.ToString("yyyy/MM/dd");//fecha
            unHorario.HoraInicio = Session["horaDCita"].ToString();//hora entrada
            unHorario.HoraFin = Session["horaDCita"].ToString();//hora salida
            unHorario.MedicoId = Convert.ToInt32(Session["MedicoId"]);//id del medico que atendera en la cita

            return unHorario;
        }

        private EntidadPagos CrearPago()
        {
            EntidadPagos unPago = new EntidadPagos();
            unPago.Monto = decimal.Parse(txtPago.Text);
            unPago.MetodoPago = selectMetodoPago.SelectedItem.ToString();

            return unPago;
        }

        protected void selectHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["horaDCita"] = selectHora.SelectedItem;
        }

        //Cargar los datos
        public void CargarListarMisCitas(string condicion = "")
        {
            BLMisCitas logicaMisCitas = new BLMisCitas(clsConfiguracion.getConnectionString);
            List<EntidadMisCitas> listarMisCitas;
            try
            {
                listarMisCitas = logicaMisCitas.llamarListarMisCitas(condicion);
                if (listarMisCitas.Count > 0)
                {
                    listarMisCitas = logicaMisCitas.llamarListarMisCitas(condicion);
                    if (listarMisCitas.Count > 0)
                    {
                        dgrMisCitas.DataSource = listarMisCitas;
                        dgrMisCitas.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                // Display the error message in the alert
                string errorMessage = $"Ha ocurrido un error: {ex.Message}";
                string encodedErrorMessage = System.Web.HttpUtility.JavaScriptStringEncode(errorMessage);
                messageScript = string.Format("alert('{0}')", encodedErrorMessage);
                ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
            }
        }

        //crea el objeto plataforma
        private EntidadPlataforma CrearPlataforma()
        {
            EntidadPlataforma datosPlataforma = new EntidadPlataforma();
            datosPlataforma.IdPaciente = Convert.ToInt32(Session["IdUsuario"]);
            datosPlataforma.IdCitas = Convert.ToInt32(Session["IdCita"]);
            datosPlataforma.IdFuncionario = Convert.ToInt32(Session["MedicoId"]);
            datosPlataforma.HoraEntrada = DateTime.Now.ToString("HH:mm");
            datosPlataforma.Motivo = txtMotivo.Text;

            return datosPlataforma;
        }

        private void InsertarPlataforma()
        {
            EntidadPlataforma unaPlataforma = new EntidadPlataforma();//objeto
            BLPlataforma logicaPlataforma = new BLPlataforma(clsConfiguracion.getConnectionString);//conexion

            try
            {
                unaPlataforma = CrearPlataforma();
                int resultado = logicaPlataforma.LlamarInsertarDatosPlataforma(unaPlataforma);
            }
            catch (Exception ex)
            {
                // Display the error message in the alert
                string errorMessage = $"Ha ocurrido un error: {ex.Message}";
                string encodedErrorMessage = System.Web.HttpUtility.JavaScriptStringEncode(errorMessage);
                messageScript = string.Format("alert('{0}')", encodedErrorMessage);
                ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
            }
        }

        protected void lnkCancelar_Command(object sender, CommandEventArgs e)
        {
            Session["id"] = int.Parse(e.CommandArgument.ToString());//id que manda el evento
            EliminarPlataforma();
            EliminarCita();
            EliminarHorario();
            EliminarPago();
        }
        //eliminar plataforma
        private void EliminarPlataforma()
        {
            
            BLPlataforma logicaPlataforma = new BLPlataforma(clsConfiguracion.getConnectionString);//conexion
            logicaPlataforma.LlamarEliminarPlataforma(Convert.ToInt32(Session["id"]));          
        }
        //eliminar cita
        private void EliminarCita()
        {
            BLCitas logicaCita = new BLCitas(clsConfiguracion.getConnectionString);//conexion
            List<EntidadCitas> citas;
            string condicion = $"CITAS_ID = '{Session["id"]}'";//vamos a sacar el id del horario y de los pagos
            citas = logicaCita.llamarListarIDSCitas(condicion);
            Session["HorarioId"] = citas[0].HorarioId;
            Session["PagosId"] = citas[0].PagosId;
            logicaCita.LlamarEliminarCita(Convert.ToInt32(Session["id"]));
            condicion = $"PA.PACIENTE_ID = '{Session["IdUsuario"]}'";
            CargarListarMisCitas(condicion);//actualiazar datos
        }

        //eliminar horario
        private void EliminarHorario()
        {
            BLHorario logicaHorario = new BLHorario(clsConfiguracion.getConnectionString);//conexion           
            logicaHorario.LlamarEliminarHorario(Convert.ToInt32(Session["HorarioId"]));         
        }

        //eliminar pago
        private void EliminarPago()
        {
            BLPagos logicaPagos = new BLPagos(clsConfiguracion.getConnectionString);//conexion
            logicaPagos.LlamarEliminarPagos(Convert.ToInt32(Session["PagosId"]));           
        }
    }
}