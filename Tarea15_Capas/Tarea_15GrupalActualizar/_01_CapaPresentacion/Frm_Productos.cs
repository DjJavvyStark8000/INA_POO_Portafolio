using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using _02_CapaLogica;
using _03_CapaBaseDatos;
using Entidades;

namespace _01_CapaPresentacion
{
    public partial class Frm_Productos : Form
    {

        Frm_Buscar_Producto formularioBuscar;//variable global
        EntidadesProductos productoRegistrado;//para actualizar producto

        public Frm_Productos()
        {
            InitializeComponent();
        }//??

        //crea un objeto con los datos ingresados en las casillas de texto
        public EntidadesProductos generaProducto()
        {
            EntidadesProductos unProducto = new EntidadesProductos();
            if (!string.IsNullOrEmpty(txtIDProductos.Text))
            {
                unProducto = productoRegistrado;
                MessageBox.Show("3");
            }
            else
            {
                unProducto = new EntidadesProductos();
                MessageBox.Show("4");
            }
            float aux = 0;
            unProducto.Descripcion = txtDescripcion.Text;
            if (float.TryParse(txtPrecioCompra.Text, out aux))
            {
                unProducto.Precio_compra = aux;
            }
            if (float.TryParse(txtPrecioVenta.Text, out aux))
            {
                unProducto.Precio_venta = aux;
            }
            if (!string.IsNullOrEmpty(txtGravado.Text))
            {
                unProducto.Gravado = txtGravado.Text; // Assigning the first character
            }

            return unProducto;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadesProductos UnProducto = new EntidadesProductos();
            BLProductos logicaProducto = new BLProductos(Configuracion.getCadenaConeccion);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtDescripcion.Text) &&
                    !string.IsNullOrEmpty(txtPrecioCompra.Text) &&
                    !string.IsNullOrEmpty(txtPrecioVenta.Text) &&
                    !string.IsNullOrEmpty(txtGravado.Text))
                {
                    UnProducto = generaProducto();

                    if (!UnProducto.Existe)
                    {
                        resultado = logicaProducto.LlamarMetodoInsertar(UnProducto);
                        MessageBox.Show("1");
                    }
                    else
                    {
                        resultado = logicaProducto.Modificar(UnProducto);
                        MessageBox.Show("2");

                        if (resultado > 0)
                        {
                            LimpiarCasillas();
                            MessageBox.Show("Operacion Realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarListaProductos();
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
        }

        //Cargar los datos
        public void CargarListaProductos(string condicion = "")
        {
            BLProductos logicaProducto = new BLProductos(Configuracion.getCadenaConeccion);
            List<EntidadesProductos> listarProductos;
            try
            {
                listarProductos = logicaProducto.llamarListaProductos(condicion);
                if (listarProductos.Count > 0)
                {
                    dgrProductos.DataSource = listarProductos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            CargarListaProductos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        public void LimpiarCasillas()
        {
            txtIDProductos.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtGravado.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Frm_Buscar formulario = new Frm_Buscar();
            //formulario.Show();
            formularioBuscar = new Frm_Buscar_Producto();
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        private void Aceptar(Object id, EventArgs e)
        {
            try
            {
                int idProducto = (int)id;
                if (idProducto != -1)//dio cancelar no selecciono nada
                {
                    // MessageBox.Show(idProducto.ToString());
                    CargarProducto(idProducto);
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


        //cargar producto desde el frmproducto
        private void CargarProducto(int id)
        {
            EntidadesProductos producto = new EntidadesProductos();
            BLProductos traerProducto = new BLProductos(Configuracion.getCadenaConeccion);
            try
            {
                producto = traerProducto.ObtenerProducto(id);
                if (producto != null)
                {
                    txtIDProductos.Text = producto.Id_Producto.ToString();
                    txtDescripcion.Text = producto.Descripcion.ToString();
                    txtPrecioCompra.Text = producto.Precio_compra.ToString();
                    txtPrecioVenta.Text = producto.Precio_venta.ToString();
                    txtGravado.Text = producto.Gravado.ToString();
                    //agregado para actualizar clinte
                    productoRegistrado = producto;
                }
                else
                {
                    MessageBox.Show("El Producto nose encuentra en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgrBuscarProductos_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                // Se recupera el ID
                id = (int)dgrProductos.SelectedRows[0].Cells[0].Value;

                // Con el ID recuperado, se puede llamar a la función que carga
                // el PRODUCTO desde la base de datos en el formulario
                CargarProducto(id);//llama este PRODUTO

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadesProductos producto;
            int resultado;
            BLProductos logicaProducto = new BLProductos(Configuracion.getCadenaConeccion);

            try
            {
                if (!string.IsNullOrEmpty(txtIDProductos.Text))
                {
                    // ver si existe primero
                    producto = logicaProducto.ObtenerProducto(int.Parse(txtIDProductos.Text));

                    if (producto != null)
                    {
                        // se puede eliminar
                        resultado = logicaProducto.EliminarConSP(producto);
                        MessageBox.Show(logicaProducto.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        LimpiarCasillas();
                        CargarListaProductos();
                    }
                    else
                    {
                        MessageBox.Show("El producto no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCasillas();
                        CargarListaProductos();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un producto antes de eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgrBuscarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //public EntidadesProductos generaProducto()
        //{
        //    Entidad_Productos producto;
        //    if (!string.IsNullOrEmpty(txtProducto.Text))
        //    {
        //        producto = productoRegistrado;
        //    }
        //    else
        //    {
        //        producto = new Entidad_Productos();
        //    }
        //    producto.Descripcion = txtDescripcion.Text;
        //    producto.Precio_Compra = Convert.ToSingle(txtPrecioCompra.Text);
        //    producto.Precio_Venta = Convert.ToSingle(txtPrecioVenta.Text);
        //    producto.Gravado = txtGravado.Text;
        //    return producto;
        //}
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            EntidadesProductos producto = new EntidadesProductos();
            BLProductos logica = new BLProductos(Configuracion.getCadenaConeccion);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtPrecioCompra.Text) && !string.IsNullOrEmpty(txtPrecioVenta.Text) && !string.IsNullOrEmpty(txtGravado.Text))
                {
                    producto = generaProducto();
                    if (!producto.Existe)
                    {
                        resultado = logica.LlamarMetodoInsertar(producto);
                    }
                    else
                    {
                        resultado = logica.Modificar(producto);
                    }
                    if (resultado > 0)
                    {
                        LimpiarCasillas();
                        MessageBox.Show("Operacion realizada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarListaProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se Realizaron cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
