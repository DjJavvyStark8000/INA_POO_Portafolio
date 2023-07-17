using ElBuenVivir_Entidades;
using ElBuenVivir_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;
using TextBox = System.Windows.Forms.TextBox;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Inventario : Form
    {
        public int global;//guarda el id de la columna
        private string accion;

        public Frm_Inventario()
        {
            InitializeComponent();
        }

        private void Frm_Inventario_Load(object sender, EventArgs e)
        {
            Authentication();//authentication
            // Even handlers para controlar cambios de texto en todas las cajas
            txtCodigoMedicamento.TextChanged += TextBox_TextChanged;
            txtNombreMedicamento.TextChanged += TextBox_TextChanged;
            txtCantidadMedicamentos.TextChanged += TextBox_TextChanged;
            // Handler for the dateCaducidad's ValueChanged event
            dateCaducidad.ValueChanged += DateValue_ValueChanged;
            txtPrecioUnitario.TextChanged += TextBox_TextChanged;
            txtProveedor.TextChanged += TextBox_TextChanged;
            CargarListaInventario();
        }

        // (0A) Carga la lista datagridview
        public void CargarListaInventario(string condicion = "")
        {

            BLInventario logicaInventario = new BLInventario(Configuracion.getCadenaConeccion);
            List<EntidadInventario> inventario;
            try
            {
                inventario = logicaInventario.llamarListarInventario(condicion);
                if (inventario.Count > 0)
                {
                    dgrListaMedicamentos.DataSource = inventario;


                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler acciones para todas las cajas
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (VerificarCampos())//si no tiene texto                   
                {
                    btnGuardarInventario.Enabled = false;
                }
                else
                {
                    lblRequeridos.ForeColor = Color.Black;
                    lblRequeridos.Text = "Listo ya puedes Guardar";
                    if (txtNombreMedicamento.Enabled & txtCantidadMedicamentos.Enabled & txtPrecioUnitario.Enabled & txtProveedor.Enabled & dateCaducidad.Enabled)
                    {
                        btnGuardarInventario.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DateValue_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            try
            {
                if (VerificarCampos()) // Check if fields are empty
                {
                    btnGuardarInventario.Enabled = false;
                }
                else
                {
                    lblRequeridos.ForeColor = Color.Black;
                    lblRequeridos.Text = "Listo ya puedes Guardar";

                    if (txtNombreMedicamento.Enabled && txtCantidadMedicamentos.Enabled && txtPrecioUnitario.Enabled && txtProveedor.Enabled && dateCaducidad.Enabled)
                    {
                        btnGuardarInventario.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //checar si campos estan en uso o no
        public bool VerificarCampos()
        {
            bool tienenDatos = false; // Assume no fields have data initially
            if (string.IsNullOrEmpty(txtCodigoMedicamento.Text) ||
                string.IsNullOrEmpty(txtNombreMedicamento.Text) ||
                string.IsNullOrEmpty(txtCantidadMedicamentos.Text) ||
                //dateCaducidad.Value != DateTime.MinValue ||  // Check if dateCaducidad has a value other than the default
                string.IsNullOrEmpty(txtPrecioUnitario.Text) ||
                string.IsNullOrEmpty(txtProveedor.Text))
            {

                tienenDatos = true; // Set tienenDatos to true if any field has data
            }

            return tienenDatos;
        }

        //Vaciar todas la casillas
        private void LimpiarCasillas()
        {
            accion = "nuevo";
            txtCodigoMedicamento.Text = string.Empty;
            txtNombreMedicamento.Text = string.Empty;
            txtCantidadMedicamentos.Text = string.Empty;
            dateCaducidad.Value = DateTime.Now; // Establecer la fecha actual o un valor predeterminado
            txtPrecioUnitario.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            HabilitarCasillas();
        }

        //activar casillas
        private void HabilitarCasillas()
        {
            if (!txtCantidadMedicamentos.Enabled &&
                !dateCaducidad.Enabled &&
                !txtPrecioUnitario.Enabled &&
                !txtProveedor.Enabled)
            {
                txtNombreMedicamento.Enabled = true;
                txtCantidadMedicamentos.Enabled = true;
                dateCaducidad.Enabled = true;
                txtPrecioUnitario.Enabled = true;
                txtProveedor.Enabled = true;
            }
        }

        private void InhabilitarCasillas()
        {
            if (txtCantidadMedicamentos.Enabled &&
                dateCaducidad.Enabled &&
                txtPrecioUnitario.Enabled &&
                txtProveedor.Enabled)
            {
                txtCantidadMedicamentos.Enabled = false;
                dateCaducidad.Enabled = false;
                txtPrecioUnitario.Enabled = false;
                txtProveedor.Enabled = false;
            }
        }

        //03 editar inventario
        private void btnEditarEspecialidad_Click(object sender, EventArgs e)
        {
            try
            {
                accion = "editar";
                HabilitarCasillas();//si estan desabilitadas pues se habilitan
                if (VerificarCampos())
                {
                    MessageBox.Show("No hay nada que editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ACTIVAR O DESACTIVAR FUNCIONALIDADES DEPENDIENDO DEL USUARIO
        private void Authentication()
        {
            if (Configuracion.getUsuario != "Admin")
            {
                btnGuardarInventario.Enabled = false;
                btnEliminarInventario.Enabled = false;
                btnEditarInventario.Enabled = false;
                btnNuevoInventario.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgrListaMedicamentos_Click(object sender, EventArgs e)
        {
            InhabilitarCasillas();

            try
            {  //obtener datos un click en la fila y pasarlo a cajas de texto
                if (dgrListaMedicamentos.SelectedRows.Count > 0)
                {
                    // Pasar los valores de las celdas al formulario
                    DataGridViewRow selectedRow = dgrListaMedicamentos.SelectedRows[0];
                    DataGridViewCell idmedicamento = selectedRow.Cells[dgrListaMedicamentos.Columns["inventario_id"].Index];
                    global = (int)idmedicamento.Value;
                    GetSetGlobal(global);//the onclick id
                    txtCodigoMedicamento.Text = idmedicamento.Value.ToString();
                    DataGridViewCell nombreMedicamento = selectedRow.Cells[dgrListaMedicamentos.Columns["producto"].Index];
                    txtNombreMedicamento.Text = nombreMedicamento.Value.ToString();
                    DataGridViewCell cantidadMedicamentos = selectedRow.Cells[dgrListaMedicamentos.Columns["cantidad"].Index];
                    txtCantidadMedicamentos.Text = cantidadMedicamentos.Value.ToString();
                    DataGridViewCell dateCaducidadCell = selectedRow.Cells[dgrListaMedicamentos.Columns["fecha_caducidad"].Index];
                    string dateValue = dateCaducidadCell.Value.ToString();
                    DateTime desiredDate = DateTime.ParseExact(dateValue, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                    dateCaducidad.Value = desiredDate;
                    DataGridViewCell precioUnitario = selectedRow.Cells[dgrListaMedicamentos.Columns["precio"].Index];
                    txtPrecioUnitario.Text = precioUnitario.Value.ToString();
                    DataGridViewCell proveedor = selectedRow.Cells[dgrListaMedicamentos.Columns["proveedor"].Index];
                    txtProveedor.Text = proveedor.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // (0) set global 
        private int GetSetGlobal(int global)
        {
            return global;
        }

        //BUSCAR UN MEDICAMENTO
        private void btnBuscarMedicamento_Click(object sender, EventArgs e)
        {
            //filtrar los datos y recuperar el cliente deseado
            string busqueda = "";
            try
            {
                if (!string.IsNullOrEmpty(txtNombreMedicamento.Text))
                {
                    //el nombre tiene en la cadena tiene que ser igual al de al entidad de la base de datos en c# 
                    busqueda = string.Format("Producto LIKE '%{0}%'", txtNombreMedicamento.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe de escribir al menos una letra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreMedicamento.Focus();
                }
                CargarListaInventario(busqueda);//pasamos lo que vamos a filtrar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //(4) ELIMINAR DEL INVENTARIO
        private void btnEliminarInventario_Click(object sender, EventArgs e)
        {
            BLInventario logicaInventario = new BLInventario(Configuracion.getCadenaConeccion);//conexion
            if (yesORnot("Desea elimirar este registro?"))
            {
                logicaInventario.LlamarEliminarInventario(GetSetGlobal(global));//globlaL es el id de la especialidad por borrar
                CargarListaInventario();//actualiazar datos
                MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCasillas();
            }
        }

        static bool yesORnot(string aviso)
        {
            DialogResult result = MessageBox.Show(aviso, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool respuesta = (result == DialogResult.Yes);
            return respuesta;
        }

        private void btnNuevoInventario_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        private void btnGuardarInventario_Click(object sender, EventArgs e)
        {
            EntidadInventario unInventario = new EntidadInventario();//objeto
            BLInventario logicaInventario = new BLInventario(Configuracion.getCadenaConeccion);//conexion
            try
            {
                if (VerificarCampos())//si no tiene datos                  
                {
                    MessageBox.Show("ooops! Faltan datos favor revisar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (accion == "nuevo")
                    {
                        unInventario = CrearInventario();//crea objeto
                        int resultado = logicaInventario.LlamarInsertarInventario(unInventario);
                        CargarListaInventario();//refrescar
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardarInventario.Enabled = false;
                        InhabilitarCasillas();//datos enviados inhabilitar
                    }
                    else if (accion == "editar")
                    {
                        unInventario = CrearInventario();//crea objeto
                        int resultado = logicaInventario.LlamarEditarInventario(unInventario);
                        CargarListaInventario();//refrescar
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardarInventario.Enabled = false;
                        InhabilitarCasillas();//datos enviados inhabilitar
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //crear objeto inventario
        private EntidadInventario CrearInventario()
        {
            EntidadInventario unInventario = new EntidadInventario();
            if (accion == "nuevo")
            {//todas la casillas forman el objeto
                int cantidadMed;
                decimal precioUnit;
                unInventario.Producto = txtNombreMedicamento.Text;
                if (int.TryParse(txtCantidadMedicamentos.Text, out cantidadMed))
                {
                    unInventario.Cantidad = cantidadMed;
                }
                unInventario.Caducidad = dateCaducidad.Value.ToString("yyyy/MM/dd");
                if (decimal.TryParse(txtPrecioUnitario.Text, out precioUnit))
                {
                    unInventario.Precio_Unitario = precioUnit;
                }
                unInventario.Proveedor = txtProveedor.Text;
            }
            else if (accion == "editar")
            {//todas las casillas forman el objeto
                int id;
                int cantidadMed;
                decimal precioUnit;
                if (int.TryParse(txtCodigoMedicamento.Text, out id))
                {
                    unInventario.Inventario_Id = id;
                }
                unInventario.Producto = txtNombreMedicamento.Text;
                if (int.TryParse(txtCantidadMedicamentos.Text, out cantidadMed))
                {
                    unInventario.Cantidad = cantidadMed;
                }
                unInventario.Caducidad = dateCaducidad.Value.ToString("yyyy/MM/dd");
                if (decimal.TryParse(txtPrecioUnitario.Text, out precioUnit))
                {
                    unInventario.Precio_Unitario = precioUnit;
                }
                unInventario.Proveedor = txtProveedor.Text;

            }
            return unInventario;
        }

    }
}
