using ElBuenVivir_Entidades;
using ElBuenVivir_Logica;
using System;
using System.Web.UI;

namespace SitioWeb
{
    public partial class Registracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //guardar paciente
        protected void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            EntidadPaciente unPaciente = new EntidadPaciente();
            BLPaciente logicaPaciente = new BLPaciente(clsConfiguracion.getConnectionString);
            int resultado;
            try
            {
                unPaciente = CrearPaciente();
                resultado = logicaPaciente.LlamarMetodoInsertar(unPaciente);            
                string messageScript = string.Format("alert('Registrado con éxito')");
                ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
            }
            catch (Exception ex)
            {
                // Display the error message in the alert
                string errorMessage = $"Ha ocurrido un error: {ex.Message}";
                string encodedErrorMessage = System.Web.HttpUtility.JavaScriptStringEncode(errorMessage);
                string messageScript = string.Format("alert('{0}')", encodedErrorMessage);
                ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
            }
        }

        //crear el objeto paciente
        public EntidadPaciente CrearPaciente()
        {
            EntidadPaciente unPaciente = new EntidadPaciente();
            BLHistorial logicaHistorial = new BLHistorial(clsConfiguracion.getConnectionString);

            int aux = 0;
            unPaciente.Identificacion = int.TryParse(txtNumeroId.Text, out aux) ? aux : unPaciente.Identificacion;
            unPaciente.Tipo_id = selectTipoId.SelectedItem.ToString();
            unPaciente.Nombre = txtNombrePaciente.Text;
            unPaciente.Apellidos = "";
            unPaciente.FechaNacimiento = Calendario.SelectedDate.ToString("yyyy/MM/dd");//cambiar formato de fecha
            unPaciente.Genero = selectGenero.SelectedItem.ToString();
            unPaciente.Nacionalidad = txtNacionalidad.Text;
            unPaciente.EstadoCivil = selectEstadoCivil.SelectedItem.ToString();
            unPaciente.Laborando = selectLaborando.SelectedItem.ToString();
            unPaciente.Asegurado = selectAsegurado.SelectedItem.ToString();
            unPaciente.Guardian = txtGuardian.Text;
            unPaciente.Telefono = int.TryParse(txtTelefono.Text, out aux) ? aux : unPaciente.Telefono;
            unPaciente.NumeroEmergencia = int.TryParse(txtEmergencia.Text, out aux) ? aux : unPaciente.NumeroEmergencia;
            unPaciente.Correo = txtCorreo.Text;
            unPaciente.Ciudad = selectCiudad.SelectedItem.ToString();
            unPaciente.Provincia = selectProvincia.SelectedItem.ToString();
            unPaciente.DetalleDireccion = txtDetallesDireccion.Text;

            return unPaciente;
        }
    }
}