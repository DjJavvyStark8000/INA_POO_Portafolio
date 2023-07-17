using ElBuenVivir_Entidades;
using ElBuenVivir_Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Plataforma : Form
    {
        private int idPaciente = 0;
        private int idCita = 0;
        private string nombreCompleto = "";
        private string horaEntrada;
        private string motivoVisita;

        public Frm_Plataforma()
        {
            InitializeComponent();
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            Frm_Pacientes agregaPaciente = new Frm_Pacientes();
            agregaPaciente.Owner = this;//define quien el el padre
            agregaPaciente.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            RoleUsuario role = new RoleUsuario();
            role.Owner = this;
            role.ShowDialog();
            role.Close();
            VariableGlobal.globalUser = 1;
            CargarListaPacientes();
            //Usiario en el titulo
            this.Text = $"Clínica El Buen Vivir | Plataforma | {Configuracion.getUsuario}";

        }

        // (0A) Carga la lista datagridview
        public void CargarListaPacientes(string condicion = "")
        {

            BLPaciente logicaPaciente = new BLPaciente(Configuracion.getCadenaConeccion);
            List<EntidadPaciente> pacientes;
            try
            {
                pacientes = logicaPaciente.llamarListarPacientes(condicion);
                if (pacientes.Count > 0)
                {
                    //no generar columnas extras
                    dgrVerPacientes.AutoGenerateColumns = false;
                    dgrVerPacientes.DataSource = pacientes;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            Frm_Citas agendaCita = new Frm_Citas(idPaciente, nombreCompleto);
            agendaCita.Owner = this;//define quien el el padre
            agendaCita.ShowDialog();
            motivoVisita = "Sacar una cita";
        }

        private void btnAccessarInvertario_Click(object sender, EventArgs e)
        {
            Frm_Inventario agregaMedicamento = new Frm_Inventario();
            agregaMedicamento.Owner = this;
            agregaMedicamento.ShowDialog();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Frm_Funcionario agregaFuncionario = new Frm_Funcionario();
            agregaFuncionario.Owner = this;
            agregaFuncionario.ShowDialog();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Frm_Especialidad gestionaEspecialidades = new Frm_Especialidad();
            gestionaEspecialidades.Owner = this;
            gestionaEspecialidades.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Frm_Inventario gestionaInventario = new Frm_Inventario();
            gestionaInventario.Owner = this;
            gestionaInventario.ShowDialog();
        }



        private void btnRecetas_Click(object sender, EventArgs e)
        {
            //Frm_Recetas gestionaReceta = new Frm_Recetas();
            //gestionaReceta.Owner = this;
            //gestionaReceta.ShowDialog();
        }

        private void btn_Horarios_Click(object sender, EventArgs e)
        {
            Frm_Citas gestionarHorarios = new Frm_Citas(idPaciente, nombreCompleto);
            gestionarHorarios.Owner = this;
            gestionarHorarios.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Frm_Historial gestionarHistorial = new Frm_Historial(idPaciente, nombreCompleto);
            gestionarHistorial.Owner = this;
            gestionarHistorial.ShowDialog();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            lblIngresoId.Visible = true;
            txtPacienteID.Visible = true;
            btnBuscarId.Visible = true;
            txtPacienteID.Focus();
        }

        //buscar un paciente por medio de su id
        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            string busqueda = "";
            try
            {
                if (!string.IsNullOrEmpty(txtPacienteID.Text))
                {
                    // Valid numeric input, proceed with the search
                    busqueda = string.Format("PACIENTE_ID LIKE '%{0}%'", txtPacienteID.Text);
                    CargarListaPacientes(busqueda);
                }
                else
                {
                    MessageBox.Show("Debe escribir al menos un valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPacienteID.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //debe ser numero
        private void txtIngresarId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPacienteID.Text))
            {
                int id;
                if (!int.TryParse(txtPacienteID.Text.Trim(), out id))
                {
                    MessageBox.Show("El valor ingresado no es válido. Debe ingresar un número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPacienteID.Text = string.Empty;
                    txtPacienteID.Focus();
                }
            }
        }

        //click en la celda nos puede llevar a agendar cita o registrar la llegada de un paciente
        private void dgrVerPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener datos un click en la fila y pasarlo a cajas de texto
                if (dgrVerPacientes.SelectedRows.Count > 0 && Configuracion.getUsuario == "Admin" || Configuracion.getUsuario == "Funcionario")
                {
                    var row = dgrVerPacientes.SelectedRows[0];
                    //activar botones de agendar cita y registrar llegada de peciente
                    btnAgendarCita.Enabled = true;
                    btnRegistrarPaciente.Enabled = true;
                    DataGridViewCell identificacion = row.Cells["clmcedula"];
                    DataGridViewCell nombre = row.Cells["clmnombre"];
                    DataGridViewCell apellidos = row.Cells["clmapellidos"];
                    txtPacienteID.Text = identificacion.Value.ToString();
                    idPaciente = Convert.ToInt32(identificacion.Value.ToString());
                    nombreCompleto = nombre.Value.ToString() + " " + apellidos.Value.ToString();
                }else if(dgrVerPacientes.SelectedRows.Count > 0 && Configuracion.getUsuario == "Médico") 
                {
                    var row = dgrVerPacientes.SelectedRows[0];
                    DataGridViewCell identificacion = row.Cells["clmcedula"];
                    DataGridViewCell nombre = row.Cells["clmnombre"];
                    DataGridViewCell apellidos = row.Cells["clmapellidos"];
                    txtPacienteID.Text = identificacion.Value.ToString();
                    idPaciente = Convert.ToInt32(identificacion.Value.ToString());
                    nombreCompleto = nombre.Value.ToString() + " " + apellidos.Value.ToString();
                    Frm_Historial gestionarHistorial = new Frm_Historial(idPaciente, nombreCompleto);
                    gestionarHistorial.Owner = this;
                    gestionarHistorial.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            motivoVisita = "Registrar llegada de paciente";
        }

        //crea el objeto plataforma
        private EntidadPlataforma CrearPlataforma()
        {
            EntidadPlataforma datosPlataforma = new EntidadPlataforma();
            datosPlataforma.IdPaciente = idPaciente;
            datosPlataforma.IdCitas = idCita;
            datosPlataforma.IdFuncionario = VariableGlobal.funcionarioId;
            datosPlataforma.HoraEntrada = horaEntrada;
            datosPlataforma.Motivo = motivoVisita;

            return datosPlataforma;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        //Guardar datos de la plataforma
        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            EntidadPlataforma unaPlataforma = new EntidadPlataforma();//objeto
            BLPlataforma logicaPlataforma = new BLPlataforma(Configuracion.getCadenaConeccion);//conexion

            try
            {
                if (!VerificarCamposTexto())//si no tiene texto                   
                {
                    MessageBox.Show("ooops! Faltan datos favor revisar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    unaPlataforma = CrearPlataforma();
                    int resultado = logicaPlataforma.LlamarInsertarDatosPlataforma(unaPlataforma);
                    MostrarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarCamposTexto()
        {
            bool camposLlenos = false;
            idCita = Convert.ToInt32(Frm_Citas.CitasIdCita);//desde el formulario de citas
            horaEntrada = DateTime.Now.ToString("HH:mm");//fecha de entrada
            if (idCita != 0)
                camposLlenos = true;//la cita si fue registrada

            return camposLlenos;

        }

        private void MostrarDatos()
        {
            EntidadPlataforma datosPlataforma = CrearPlataforma();

            string mensaje = $"ID Paciente: {datosPlataforma.IdPaciente}" +
                             $"\nID Citas: {datosPlataforma.IdCitas}" +
                             $"\nID Funcionario: {datosPlataforma.IdFuncionario}" +
                             $"\nHora Entrada: {datosPlataforma.HoraEntrada}" +
                             $"\nMotivo Visita: {datosPlataforma.Motivo}";

            MessageBox.Show(mensaje, "Datos de Plataforma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
