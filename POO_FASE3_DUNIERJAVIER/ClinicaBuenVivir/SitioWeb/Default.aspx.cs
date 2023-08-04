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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string selectedRoll = SelectRoll.SelectedValue;
            //Store the selected roll in a Session variable
            Session["SelectedRoll"] = selectedRoll;
            if (Session["SelectedRoll"].ToString() == "Paciente")
            {
                Session["IdUsuario"] = idUsuario.Value;
                string condition = $"PACIENTE_ID = '{idUsuario.Value}'";     //condicion para averiguar is paciente existe     

                if (CargarPaciente(condition))
                {
                    Response.Redirect("Citas.aspx");
                }
                else
                {
                    string messageScript = string.Format("alert('Paciente no existe y nesecita ser registrado')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
                }
            }
            else
            {
                string messageScript = string.Format("alert('Funcionalidades para este Roll no estan disponibles')");
                ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
            }
        }

        public bool CargarPaciente(string condicion = "")
        {
            bool existe = false;
            BLPaciente logicaPacientes = new BLPaciente(clsConfiguracion.getConnectionString);
            List<EntidadPaciente> pacientes;

            try
            {
                pacientes = logicaPacientes.llamarListarPacientes(condicion);
                if (pacientes.Count > 0)
                {
                    existe = true;
                    Session["NombreCompleto"] = pacientes[0].Nombre + " " + pacientes[0].Apellidos;
                }

            }
            catch (Exception ex)
            {
                // Display the error message in the alert
                string errorMessage = $"Ha ocurrido un error: {ex.Message}";
                string encodedErrorMessage = System.Web.HttpUtility.JavaScriptStringEncode(errorMessage);
                string messageScript = string.Format("alert('{0}')", encodedErrorMessage);
                ScriptManager.RegisterStartupScript(this, typeof(string), "Message", messageScript, true);
            }
            return existe;
        }

        protected void Registro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registracion.aspx");
        }
    }  
}