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
        EntidadClientes clienteRegistrado;//para actualizar cliente


        public Frm_Clientes()
        {
            InitializeComponent();
        }//??


        //llamar cargar datos cliente
        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
        }

        //crea un objeto con los datos ingresados en las casillas de texto
        public EntidadClientes generaCliente()
        {
            //EntidadClientes unCliente = new EntidadClientes();
            EntidadClientes unCliente;
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                unCliente = clienteRegistrado;
            }
            else
            {
                unCliente = new EntidadClientes();
            }

            unCliente.Nombre = txtNombre.Text;
            unCliente.Telefono = txtTelefono.Text;
            unCliente.Direccion = txtDireccion.Text;

            return unCliente;
        }//??


        //Guardar datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadClientes UnCliente = new EntidadClientes();
            BLCliente logicaCliente = new BLCliente(Configuracion.getCadenaConeccion);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) &&
         !string.IsNullOrEmpty(txtTelefono.Text) &&
         !string.IsNullOrEmpty(txtDireccion.Text))
                {
                    UnCliente = generaCliente();

                    if (!UnCliente.Existe)
                    {
                        // Code to handle the scenario when the client doesn't exist
                    }
                    else
                    {
                        resultado = logicaCliente.Modificar(UnCliente);

                        if (resultado > 0)
                        {
                            LimpiarCasillas();
                            MessageBox.Show("Operacion Realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarListaClientes();
                        }
                        else
                        {
                            MessageBox.Show("No se realizaron cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Los datos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//??

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
        }//??



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }//??

        public void LimpiarCasillas()
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }//??

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }//??

        //abrir buscar formulario
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Frm_Buscar formulario = new Frm_Buscar();
            //formulario.Show();
            formularioBuscar = new Frm_Buscar();
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }//?

        private void Aceptar(Object id, EventArgs e)
        {
            try
            {
                int idCliente = (int)id;
                if (idCliente != -1)//dio cancelar no selecciono nada
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
        }//??


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
                    //agregado para actualizar clinte
                    clienteRegistrado = cliente;
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
        }//??

        //double click en gridview para recuperar id
        private void dgrClientes_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                // Se recupera el ID
                id = (int)dgrClientes.SelectedRows[0].Cells[0].Value;

                // Con el ID recuperado, se puede llamar a la función que carga
                // el cliente desde la base de datos en el formulario
                CargarCliente(id);//llama este cliente

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//??

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadClientes cliente;
            int resultado;
            BLCliente logica = new BLCliente(Configuracion.getCadenaConeccion);

            try
            {
                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    // ver si existe primero
                    cliente = logica.ObtenerCliente(int.Parse(txtID.Text));

                    if (cliente != null)
                    {
                        // se puede eliminar
                        resultado = logica.EliminarConSP(cliente);
                        MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Print the message sent by the stored procedure

                        LimpiarCasillas();
                        CargarListaClientes();
                    }
                    else
                    {
                        MessageBox.Show("El cliente no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCasillas();
                        CargarListaClientes();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente antes de eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
