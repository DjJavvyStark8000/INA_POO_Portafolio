using ElBuenVivir_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Plataforma : Form
    {

        public Frm_Plataforma()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            VariableGlobal.globalUser = 1;
        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            Frm_Citas agendaCita = new Frm_Citas();
            agendaCita.Owner = this;//define quien el el padre
            agendaCita.ShowDialog();
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

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void cargarListaPacientes(string condicion = "", string orden = "")
        {
            BLBuscarPaciente logicaPaciente = new BLBuscarPaciente(Configuracion.getCadenaConeccion);
            DataSet DSPacientes;

            try
            {
                DSPacientes = logicaPaciente.llamarListarPacientes(condicion, orden);
                dgrVerPaciente.DataSource = DSPacientes;
                dgrVerPaciente.DataMember = DSPacientes.Tables["PACIENTES"].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            Frm_Recetas gestionaReceta = new Frm_Recetas();
            gestionaReceta.Owner = this;
            gestionaReceta.ShowDialog();
        }

        private void btn_Horarios_Click(object sender, EventArgs e)
        {
            Frm_Citas gestionarHorarios = new Frm_Citas();
            gestionarHorarios.Owner = this;
            gestionarHorarios.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Frm_Historial gestionarHistorial = new Frm_Historial();
            gestionarHistorial.Owner = this;
            gestionarHistorial.ShowDialog();
        }
    }
}
