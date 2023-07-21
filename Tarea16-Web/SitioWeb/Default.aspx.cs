using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _02_CapaLogica;
using Entidades;
using System.Data;


namespace SitioWeb
{
    public partial class Default : System.Web.UI.Page
    {
        //Cargar los datos
        public void CargarListaClientes(string condicion = "")
        {
            BLCliente logicaBuscar = new BLCliente(clsConfiguracion.getConnectionString);
            List<EntidadClientes> listarClientes;
            try
            {
                listarClientes = logicaBuscar.llamarListaClientes(condicion);
                if (listarClientes.Count > 0)
                {
                    listarClientes = logicaBuscar.llamarListaClientes(condicion);
                    if (listarClientes.Count > 0)
                    {
                        dgrClientes.DataSource = listarClientes;
                        dgrClientes.DataBind();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarListaClientes(); 
            }
           
        }

        protected void btnIrAProductos_Click(object sender, EventArgs e)
        {       
            Response.Redirect("Productos.aspx");
        }
    }
}