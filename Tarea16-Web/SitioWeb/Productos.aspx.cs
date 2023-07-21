using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _02_CapaLogica;
using Entidades;

namespace SitioWeb
{
    public partial class Produtos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarListaProductos();
            }
        }

        //Cargar los datos
        public void CargarListaProductos(string condicion = "")
        {
            BLProductos logicaBuscarProducto = new BLProductos(clsConfiguracion.getConnectionString);
            List<EntidadesProductos> listarProductos;
            try
            {
                listarProductos = logicaBuscarProducto.llamarListaProductos(condicion);
                if (listarProductos.Count > 0)
                {
                    listarProductos = logicaBuscarProducto.llamarListaProductos(condicion);
                    if (listarProductos.Count > 0)
                    {
                        dgrProductos.DataSource = listarProductos;
                        dgrProductos.DataBind();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}