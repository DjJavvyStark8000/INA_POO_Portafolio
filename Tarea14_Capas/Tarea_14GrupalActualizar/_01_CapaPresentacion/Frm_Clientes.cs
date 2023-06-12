using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
using _02_CapaLogica;
using Entidades;

namespace _01_CapaPresentacion
{
    public partial class Frm_Clientes : Form
    {

        Frm_Buscar formularioBuscar;//variable global
        

        public Frm_Clientes()
        {
            InitializeComponent();
        }


        //llamar cargar datos cliente
        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
        }

        //crea un objeto con los datos ingresados en las casillas de texto
        public EntidadClientes generaCliente()
        {
            EntidadClientes unCliente = new EntidadClientes();
            unCliente.Nombre = txtNombre.Text;
            unCliente.Telefono = txtTelefono.Text;
            unCliente.Direccion = txtDireccion.Text;

            return unCliente;
        }


        //Guardar datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadClientes UnCliente = new EntidadClientes();
            BLCliente logicaCliente = new BLCliente(Configuracion.getCadenaConeccion);
            int resultado;
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtTelefono.Text) | string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("ooops! Faltan datos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UnCliente = generaCliente();
                    resultado = logicaCliente.LlamarMetodoInsertar(UnCliente);
                    LimpiarCasillas();
                    MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cargar los datos
        public void CargarListaClientes(string condicion = "")
        {
            BLCliente logicaBuscar = new BLCliente(Configuracion.getCadenaConeccion);
            List<EntidadClientes> listarClientes;
            try
            {
                listarClientes = logicaBuscar.llamarListaClientes(condicion);
                if (listarClientes.Count > 0)
                {
                    dgrClientes.DataSource = listarClientes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        public void LimpiarCasillas()
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //abrir buscar formulario
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Frm_Buscar formulario = new Frm_Buscar();
            //formulario.Show();
            formularioBuscar = new Frm_Buscar();
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        private void Aceptar(Object id, EventArgs e)
        {
            try
            {
                int idCliente = (int) id;
                if(idCliente != -1)//dio cancelar no selecciono nada
                {
                    // MessageBox.Show(idCliente.ToString());
                    CargarCliente(idCliente);
                }
                else
                {
                    LimpiarCasillas();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //cargar cliente desde el frmcliente
        private void CargarCliente(int id)
        {
            EntidadClientes cliente = new EntidadClientes();
            BLCliente traerCliente = new BLCliente(Configuracion.getCadenaConeccion);
            try
            {
                cliente = traerCliente.ObtenerCliente(id);
                if (cliente != null)
                {
                    txtID.Text = cliente.Id_Cliente.ToString();
                    txtNombre.Text = cliente.Nombre;
                    txtTelefono.Text = cliente.Telefono;
                    txtDireccion.Text = cliente.Direccion;
                }
                else
                {
                    MessageBox.Show("el cliente nose encuentra en la base de datos", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
