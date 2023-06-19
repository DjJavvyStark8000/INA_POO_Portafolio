using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ElBuenVivir_Logica;
using ElBuenVivir_AccesoDatos;
using ElBuenVivir_Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Linq;
using TextBox = System.Windows.Forms.TextBox;

namespace ElBuenVivir_Interfaz
{
    public partial class Frm_Especialidad : Form
    {
        public int global;
        private string accion;

        public Frm_Especialidad()
        {
            InitializeComponent();

        }


        // Event handler acciones para todas las cajas
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (!VerificarCamposTexto())//si no tiene texto                   
                {
                    btnGuardar.Enabled = false;
                }
                else
                {
                    lblRequeridos.ForeColor = Color.Black;
                    lblRequeridos.Text = "Listo ya puedes Guardar";
                    if (txtDescripcion.Enabled & txtArea.Enabled & txtCosto.Enabled & txtDisponibilidad.Enabled & txtObservaciones.Enabled)
                    {
                        btnGuardar.Enabled = true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // () Hacer click enel dataGridView acciones
        private void dgrEspecialidades_Click(object sender, EventArgs e)
        {
            //desabilidar casillas
            if (txtDescripcion.Enabled & txtArea.Enabled & txtCosto.Enabled & txtDisponibilidad.Enabled & txtObservaciones.Enabled)
            {
                txtDescripcion.Enabled = false;
                txtArea.Enabled = false;
                txtCosto.Enabled = false;
                txtDisponibilidad.Enabled = false;
                txtObservaciones.Enabled = false;
            }
            if (dgrEspecialidades.SelectedRows.Count > 0)
            {
                global = (int)dgrEspecialidades.SelectedRows[0].Cells[0].Value;
                GetSetGlobal(global);//sends value
            }
            //..................
            try
            {                                                                                       //obtener datos un click en la fila y pasarlo a cajas de texto
                if (dgrEspecialidades.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgrEspecialidades.SelectedRows[0];

                    int id;
                    if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out id))
                    {
                        txtIdEspecialidad.Text = id.ToString();
                    }
                    txtNombreEspecialidad.Text = selectedRow.Cells[1].Value.ToString();
                    txtDescripcion.Text = selectedRow.Cells[2].Value.ToString();
                    txtArea.Text = selectedRow.Cells[3].Value.ToString();

                    decimal editacosto;
                    if (decimal.TryParse(selectedRow.Cells[4].Value.ToString(), out editacosto))
                    {
                        txtCosto.Text = editacosto.ToString();
                    }
                    txtDisponibilidad.Text = selectedRow.Cells[5].Value.ToString();
                    txtObservaciones.Text = selectedRow.Cells[6].Value.ToString();
                }

                //actualizarEspecialidad = CrearEspecialidad();
                //int resultado = logicaEspecialidad.LlamarEditarEspecialidad(actualizarEspecialidad);
                //CargarListaEspecialidades();//cargar lista
                //MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        //Carga automaticatica la lista
        private void Frm_Especialidad_Load(object sender, EventArgs e)
        {
            // Even handlers para controlar cambios de texto en todas las cajas
            txtIdEspecialidad.TextChanged += TextBox_TextChanged;
            txtNombreEspecialidad.TextChanged += TextBox_TextChanged;
            txtDescripcion.TextChanged += TextBox_TextChanged;
            txtArea.TextChanged += TextBox_TextChanged;
            txtCosto.TextChanged += TextBox_TextChanged;
            txtDisponibilidad.TextChanged += TextBox_TextChanged;
            txtObservaciones.TextChanged += TextBox_TextChanged;

            //cargar lista
            CargarListaEspecialidades();


        }

        // (0A) Carga la lista datagridview
        public void CargarListaEspecialidades(string condicion = "")
        {

            BLEspecialidad logicaEspecialidad = new BLEspecialidad(Configuracion.getCadenaConeccion);
            List<EntidadEspecialidad> especialidades;
            try
            {
                especialidades = logicaEspecialidad.llamarListarEspecialidades(condicion);
                if (especialidades.Count > 0)
                {
                    dgrEspecialidades.DataSource = especialidades;


                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // (1) Buscar especialidad
        private void btnBuscarEspecial_Click(object sender, EventArgs e)
        {
            //filtrar los datos y recuperar el cliente deseado
            string busqueda = "";
            try
            {
                if (!string.IsNullOrEmpty(txtNombreEspecialidad.Text))
                {
                    //el nombre tiene en la cadena tiene que ser igual al de al entidad de la base de datos en c# 
                    busqueda = string.Format("Nombre_Especialidad LIKE '%{0}%'", txtNombreEspecialidad.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe de escribir al menos una letra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreEspecialidad.Focus();
                }
                CargarListaEspecialidades(busqueda);//pasamos lo que vamos a filtrar
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // (2) Insertar especialidad
        private void btnInsertarEspecialidad_Click(object sender, EventArgs e)
        {

        }

        //crear especialidad
        private EntidadEspecialidad CrearEspecialidad()
        {
            EntidadEspecialidad unaEspecialidad = new EntidadEspecialidad();
            if (accion == "nuevo")
            {
                decimal aux = 0;
                unaEspecialidad.Nombre_Especialidad = txtNombreEspecialidad.Text;
                unaEspecialidad.Descripcion = txtDescripcion.Text;
                unaEspecialidad.Area = txtArea.Text;
                if (decimal.TryParse(txtCosto.Text, out aux))
                {
                    unaEspecialidad.Costo = aux;
                }
                unaEspecialidad.Disponibilidad = txtDisponibilidad.Text;
                unaEspecialidad.Observaciones = txtObservaciones.Text;
            }
            else if (accion == "editar")
            {
                decimal costo = 0;
                int id;
                if (int.TryParse(txtIdEspecialidad.Text, out id))
                {
                    unaEspecialidad.ID_Especialidad = id;
                }
                unaEspecialidad.Nombre_Especialidad = txtNombreEspecialidad.Text;
                unaEspecialidad.Descripcion = txtDescripcion.Text;
                unaEspecialidad.Area = txtArea.Text;
                if (decimal.TryParse(txtCosto.Text, out costo))
                {
                    unaEspecialidad.Costo = costo;
                }
                unaEspecialidad.Disponibilidad = txtDisponibilidad.Text;
                unaEspecialidad.Observaciones = txtObservaciones.Text;
            }
            return unaEspecialidad;
        }

        // (03) Editar especialidad
        private void btnEditarEspecialidad_Click(object sender, EventArgs e)
        {
            try
            {
                accion = "editar";
                if (!txtDescripcion.Enabled &
                    !txtArea.Enabled &
                    !txtCosto.Enabled &
                    !txtDisponibilidad.Enabled &
                    !txtObservaciones.Enabled &
                    !string.IsNullOrEmpty(txtDescripcion.Text) &
                    !string.IsNullOrEmpty(txtArea.Text) &
                    !string.IsNullOrEmpty(txtCosto.Text) &
                    !string.IsNullOrEmpty(txtDisponibilidad.Text) &
                    !string.IsNullOrEmpty(txtObservaciones.Text))
                {
                    txtDescripcion.Enabled = true;
                    txtArea.Enabled = true;
                    txtCosto.Enabled = true;
                    txtDisponibilidad.Enabled = true;
                    txtObservaciones.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No existen datos para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // (4) Eliminar especialidad
        private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
        {
            BLEspecialidad logicaEspecialidad = new BLEspecialidad(Configuracion.getCadenaConeccion);//conexion
            if (yesORnot("Desea elimirar este registro?"))
            {
                logicaEspecialidad.LlamarEliminarEspecialidad(GetSetGlobal(global));//globla es el id de la especialidad por borrar
                CargarListaEspecialidades();//actualiazar datos
                MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCasillas();
            }
        }

        //VERIFICACION DE EXISTENCIA
        public bool ExisteEspecialidad(EntidadEspecialidad especialidad)
        {
            // Llamar a la capa de lógica de negocio
            BLEspecialidad logicaEspecialidad = new BLEspecialidad(Configuracion.getCadenaConeccion);//conexion
            bool existe = logicaEspecialidad.LlamarEspecialidadExiste(especialidad);

            return false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        static bool yesORnot(string aviso)
        {
            DialogResult result = MessageBox.Show(aviso, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            bool respuesta = (result == DialogResult.Yes);
            return respuesta;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadEspecialidad unaEspecialidad = new EntidadEspecialidad();//objeto
            BLEspecialidad logicaEspecialidad = new BLEspecialidad(Configuracion.getCadenaConeccion);//conexion

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
                        unaEspecialidad = CrearEspecialidad();//crea objeto
                        int resultado = logicaEspecialidad.LlamarInsertarEspecialidad(unaEspecialidad);
                        CargarListaEspecialidades();//cargar lista
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardar.Enabled = false;
                    }
                    else if (accion == "editar")
                    {
                        unaEspecialidad = CrearEspecialidad();//crea objeto
                        int resultado = logicaEspecialidad.LlamarEditarEspecialidad(unaEspecialidad);
                        CargarListaEspecialidades();//cargar lista
                        MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardar.Enabled = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //limpiar
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCasillas();
        }

        private void limpiarCasillas()
        {
            accion = "nuevo";//se va a enviar un nuevo dato al servidor
            txtIdEspecialidad.Text = string.Empty;
            txtNombreEspecialidad.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtArea.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtDisponibilidad.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            if (!txtDescripcion.Enabled & !txtArea.Enabled & !txtCosto.Enabled & !txtDisponibilidad.Enabled & !txtObservaciones.Enabled)
            {
                txtDescripcion.Enabled = true;
                txtArea.Enabled = true;
                txtCosto.Enabled = true;
                txtDisponibilidad.Enabled = true;
                txtObservaciones.Enabled = true;
            }
        }

        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        public bool VerificarCamposTexto()
        {
            bool todosTienenLetras = true;
            if (string.IsNullOrEmpty(txtNombreEspecialidad.Text))
            {
                todosTienenLetras = false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                todosTienenLetras = false;
            }

            if (string.IsNullOrEmpty(txtArea.Text))
            {
                todosTienenLetras = false;
            }

            if (string.IsNullOrEmpty(txtCosto.Text))
            {
                todosTienenLetras = false;
            }

            if (string.IsNullOrEmpty(txtDisponibilidad.Text))
            {
                todosTienenLetras = false;
            }

            if (string.IsNullOrEmpty(txtObservaciones.Text))
            {
                todosTienenLetras = false;
            }

            return todosTienenLetras;
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto es válido como número decimal
            if (!string.IsNullOrEmpty(txtCosto.Text) && !decimal.TryParse(txtCosto.Text, out decimal costo))
            {
                // Si el texto no es un número decimal válido, puedes mostrar un mensaje de error o realizar alguna acción adicional.
                MessageBox.Show("Por favor, ingrese un número decimal válido en el campo de costo.");
                txtCosto.Text = string.Empty; // Puedes limpiar el contenido del campo si no es válido.
            }
        }
    }
}
