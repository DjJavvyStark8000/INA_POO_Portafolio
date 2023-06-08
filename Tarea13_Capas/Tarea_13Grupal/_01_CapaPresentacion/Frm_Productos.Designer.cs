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
            btnGuardar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            lblIGravado = new System.Windows.Forms.Label();
            txtGravado = new System.Windows.Forms.TextBox();
            lblPrecioVenta = new System.Windows.Forms.Label();
            txtPrecioVenta = new System.Windows.Forms.TextBox();
            lblPrecioCompra = new System.Windows.Forms.Label();
            txtPrecioCompra = new System.Windows.Forms.TextBox();
            lblDescripcion = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            txtIDProductos = new System.Windows.Forms.TextBox();
            lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id_Producto, descripcionProducto, precioCompra, precioVenta, gravadoProductos });
            dataGridView1.Location = new System.Drawing.Point(10, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(619, 335);
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
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(473, 544);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 74);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new System.Drawing.Point(554, 544);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(75, 74);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(392, 544);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 74);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(230, 544);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 74);
            button1.TabIndex = 4;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(311, 544);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 74);
            button2.TabIndex = 5;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblIGravado
            // 
            lblIGravado.AutoSize = true;
            lblIGravado.Location = new System.Drawing.Point(539, 66);
            lblIGravado.Name = "lblIGravado";
            lblIGravado.Size = new System.Drawing.Size(52, 15);
            lblIGravado.TabIndex = 43;
            lblIGravado.Text = "Grabado";
            // 
            // txtGravado
            // 
            txtGravado.BackColor = System.Drawing.SystemColors.Info;
            txtGravado.Enabled = false;
            txtGravado.Location = new System.Drawing.Point(539, 84);
            txtGravado.Name = "txtGravado";
            txtGravado.Size = new System.Drawing.Size(109, 23);
            txtGravado.TabIndex = 42;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new System.Drawing.Point(396, 66);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new System.Drawing.Size(72, 15);
            lblPrecioVenta.TabIndex = 41;
            lblPrecioVenta.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BackColor = System.Drawing.SystemColors.Info;
            txtPrecioVenta.Enabled = false;
            txtPrecioVenta.Location = new System.Drawing.Point(396, 84);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new System.Drawing.Size(109, 23);
            txtPrecioVenta.TabIndex = 40;
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new System.Drawing.Point(243, 66);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new System.Drawing.Size(86, 15);
            lblPrecioCompra.TabIndex = 39;
            lblPrecioCompra.Text = "Precio Compra";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.BackColor = System.Drawing.SystemColors.Info;
            txtPrecioCompra.Enabled = false;
            txtPrecioCompra.Location = new System.Drawing.Point(243, 84);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new System.Drawing.Size(109, 23);
            txtPrecioCompra.TabIndex = 38;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(11, 66);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(69, 15);
            lblDescripcion.TabIndex = 37;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = System.Drawing.SystemColors.Info;
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new System.Drawing.Point(11, 84);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(207, 104);
            txtDescripcion.TabIndex = 36;
            // 
            // txtIDProductos
            // 
            txtIDProductos.BackColor = System.Drawing.SystemColors.Info;
            txtIDProductos.Enabled = false;
            txtIDProductos.Location = new System.Drawing.Point(11, 29);
            txtIDProductos.Name = "txtIDProductos";
            txtIDProductos.Size = new System.Drawing.Size(109, 23);
            txtIDProductos.TabIndex = 35;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new System.Drawing.Point(11, 11);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(89, 15);
            lblID.TabIndex = 34;
            lblID.Text = "ID del Producto";
            // 
            // Frm_Productos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(668, 630);
            Controls.Add(lblIGravado);
            Controls.Add(txtGravado);
            Controls.Add(lblPrecioVenta);
            Controls.Add(txtPrecioVenta);
            Controls.Add(lblPrecioCompra);
            Controls.Add(txtPrecioCompra);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(txtIDProductos);
            Controls.Add(lblID);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Name = "Frm_Productos";
            Text = "Frm_Productos";
            Load += Frm_Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravadoProductos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblIGravado;
        private System.Windows.Forms.TextBox txtGravado;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIDProductos;
        private System.Windows.Forms.Label lblID;
    }
}