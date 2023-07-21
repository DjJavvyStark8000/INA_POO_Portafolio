namespace _01_CapaPresentacion
{
    partial class Frm_Buscar_Producto
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
            btnCancelarProducto = new System.Windows.Forms.Button();
            btnAceptarProducto = new System.Windows.Forms.Button();
            btnBuscarProducto = new System.Windows.Forms.Button();
            txtBuscarProducto = new System.Windows.Forms.TextBox();
            lblBuscarProducto = new System.Windows.Forms.Label();
            dgrProductos = new System.Windows.Forms.DataGridView();
            id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gravadoProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgrProductos).BeginInit();
            SuspendLayout();
            // 
            // btnCancelarProducto
            // 
            btnCancelarProducto.Location = new System.Drawing.Point(546, 538);
            btnCancelarProducto.Name = "btnCancelarProducto";
            btnCancelarProducto.Size = new System.Drawing.Size(75, 23);
            btnCancelarProducto.TabIndex = 11;
            btnCancelarProducto.Text = "Cancelar";
            btnCancelarProducto.UseVisualStyleBackColor = true;
            btnCancelarProducto.Click += btnCancelarProducto_Click;
            // 
            // btnAceptarProducto
            // 
            btnAceptarProducto.Location = new System.Drawing.Point(465, 538);
            btnAceptarProducto.Name = "btnAceptarProducto";
            btnAceptarProducto.Size = new System.Drawing.Size(75, 23);
            btnAceptarProducto.TabIndex = 10;
            btnAceptarProducto.Text = "Aceptar";
            btnAceptarProducto.UseVisualStyleBackColor = true;
            btnAceptarProducto.Click += btnAceptarProducto_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new System.Drawing.Point(26, 66);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            btnBuscarProducto.TabIndex = 8;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new System.Drawing.Point(26, 37);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new System.Drawing.Size(393, 23);
            txtBuscarProducto.TabIndex = 7;
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new System.Drawing.Point(26, 21);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new System.Drawing.Size(94, 15);
            lblBuscarProducto.TabIndex = 6;
            lblBuscarProducto.Text = "Buscar Producto";
            // 
            // dgrProductos
            // 
            dgrProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id_Producto, descripcionProducto, precioCompra, precioVenta, gravadoProductos });
            dgrProductos.Location = new System.Drawing.Point(12, 104);
            dgrProductos.Name = "dgrProductos";
            dgrProductos.RowTemplate.Height = 25;
            dgrProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgrProductos.Size = new System.Drawing.Size(627, 364);
            dgrProductos.TabIndex = 12;
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
            // Frm_Buscar_Producto
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(651, 573);
            Controls.Add(dgrProductos);
            Controls.Add(btnCancelarProducto);
            Controls.Add(btnAceptarProducto);
            Controls.Add(btnBuscarProducto);
            Controls.Add(txtBuscarProducto);
            Controls.Add(lblBuscarProducto);
            Name = "Frm_Buscar_Producto";
            Text = "Buscar_Produto";
            Load += Frm_Buscar_Produto_Load;
            ((System.ComponentModel.ISupportInitialize)dgrProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnAceptarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.DataGridView dgrProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravadoProductos;
    }
}