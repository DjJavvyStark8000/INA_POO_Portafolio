namespace _01_CapaPresentacion
{
    partial class Frm_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new System.Windows.Forms.DataGridView();
            id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gravadoProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id_Producto, descripcionProducto, precioCompra, precioVenta, gravadoProductos });
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(542, 426);
            dataGridView1.TabIndex = 0;
            // 
            // id_Producto
            // 
            id_Producto.DataPropertyName = "ID_PRODUCTO";
            id_Producto.HeaderText = "ID_PRODUCTO";
            id_Producto.Name = "id_Producto";
            // 
            // descripcionProducto
            // 
            descripcionProducto.DataPropertyName = "DESCRIPCION";
            descripcionProducto.HeaderText = "DESCRIPCION";
            descripcionProducto.Name = "descripcionProducto";
            // 
            // precioCompra
            // 
            precioCompra.DataPropertyName = "PRECIO_COMPRA";
            precioCompra.HeaderText = "PRECIO_COMPRA";
            precioCompra.Name = "precioCompra";
            // 
            // precioVenta
            // 
            precioVenta.DataPropertyName = "PRECIO_VENTA";
            precioVenta.HeaderText = "PRECIO_VENTA";
            precioVenta.Name = "precioVenta";
            // 
            // gravadoProductos
            // 
            gravadoProductos.DataPropertyName = "GRAVADO";
            gravadoProductos.HeaderText = "GRAVADO";
            gravadoProductos.Name = "gravadoProductos";
            // 
            // Frm_Productos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(563, 450);
            Controls.Add(dataGridView1);
            Name = "Frm_Productos";
            Text = "Frm_Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravadoProductos;
    }
}