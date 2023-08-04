namespace ElBuenVivir_Interfaz
{
    partial class Frm_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inventario));
            txtNombreMedicamento = new System.Windows.Forms.TextBox();
            lblNombreMedicamento = new System.Windows.Forms.Label();
            groupMedicamentos = new System.Windows.Forms.GroupBox();
            lblRequeridos = new System.Windows.Forms.Label();
            lblProveedor = new System.Windows.Forms.Label();
            txtProveedor = new System.Windows.Forms.TextBox();
            lblPrecioUnitario = new System.Windows.Forms.Label();
            txtPrecioUnitario = new System.Windows.Forms.TextBox();
            lblCodigoMedicamento = new System.Windows.Forms.Label();
            txtCodigoMedicamento = new System.Windows.Forms.TextBox();
            dateCaducidad = new System.Windows.Forms.DateTimePicker();
            lblExpira = new System.Windows.Forms.Label();
            txtCantidadMedicamentos = new System.Windows.Forms.TextBox();
            lblCantidad = new System.Windows.Forms.Label();
            dgrListaMedicamentos = new System.Windows.Forms.DataGridView();
            inventario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fecha_caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupListaMed = new System.Windows.Forms.GroupBox();
            btnGuardarInventario = new System.Windows.Forms.Button();
            btnBuscarMedicamento = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEditarInventario = new System.Windows.Forms.Button();
            btnEliminarInventario = new System.Windows.Forms.Button();
            btnNuevoInventario = new System.Windows.Forms.Button();
            groupMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrListaMedicamentos).BeginInit();
            groupListaMed.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreMedicamento
            // 
            txtNombreMedicamento.Location = new System.Drawing.Point(23, 107);
            txtNombreMedicamento.Name = "txtNombreMedicamento";
            txtNombreMedicamento.Size = new System.Drawing.Size(180, 26);
            txtNombreMedicamento.TabIndex = 8;
            // 
            // lblNombreMedicamento
            // 
            lblNombreMedicamento.AutoSize = true;
            lblNombreMedicamento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombreMedicamento.Location = new System.Drawing.Point(23, 90);
            lblNombreMedicamento.Name = "lblNombreMedicamento";
            lblNombreMedicamento.Size = new System.Drawing.Size(149, 14);
            lblNombreMedicamento.TabIndex = 7;
            lblNombreMedicamento.Text = "Nombre del Medicamento";
            // 
            // groupMedicamentos
            // 
            groupMedicamentos.Controls.Add(lblRequeridos);
            groupMedicamentos.Controls.Add(lblProveedor);
            groupMedicamentos.Controls.Add(txtProveedor);
            groupMedicamentos.Controls.Add(lblPrecioUnitario);
            groupMedicamentos.Controls.Add(txtPrecioUnitario);
            groupMedicamentos.Controls.Add(lblCodigoMedicamento);
            groupMedicamentos.Controls.Add(txtCodigoMedicamento);
            groupMedicamentos.Controls.Add(dateCaducidad);
            groupMedicamentos.Controls.Add(lblExpira);
            groupMedicamentos.Controls.Add(lblNombreMedicamento);
            groupMedicamentos.Controls.Add(txtNombreMedicamento);
            groupMedicamentos.Controls.Add(txtCantidadMedicamentos);
            groupMedicamentos.Controls.Add(lblCantidad);
            groupMedicamentos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupMedicamentos.Location = new System.Drawing.Point(12, 12);
            groupMedicamentos.Name = "groupMedicamentos";
            groupMedicamentos.Size = new System.Drawing.Size(229, 413);
            groupMedicamentos.TabIndex = 13;
            groupMedicamentos.TabStop = false;
            groupMedicamentos.Text = "Medicamentos";
            // 
            // lblRequeridos
            // 
            lblRequeridos.AutoSize = true;
            lblRequeridos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRequeridos.ForeColor = System.Drawing.Color.Red;
            lblRequeridos.Location = new System.Drawing.Point(23, 361);
            lblRequeridos.Name = "lblRequeridos";
            lblRequeridos.Size = new System.Drawing.Size(196, 14);
            lblRequeridos.TabIndex = 34;
            lblRequeridos.Text = "*Todos los campos son requeridos";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblProveedor.Location = new System.Drawing.Point(23, 315);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new System.Drawing.Size(61, 14);
            lblProveedor.TabIndex = 18;
            lblProveedor.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            txtProveedor.Enabled = false;
            txtProveedor.Location = new System.Drawing.Point(23, 332);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new System.Drawing.Size(180, 26);
            txtProveedor.TabIndex = 19;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPrecioUnitario.Location = new System.Drawing.Point(23, 260);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new System.Drawing.Size(88, 14);
            lblPrecioUnitario.TabIndex = 16;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Enabled = false;
            txtPrecioUnitario.Location = new System.Drawing.Point(23, 277);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new System.Drawing.Size(180, 26);
            txtPrecioUnitario.TabIndex = 17;
            // 
            // lblCodigoMedicamento
            // 
            lblCodigoMedicamento.AutoSize = true;
            lblCodigoMedicamento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCodigoMedicamento.Location = new System.Drawing.Point(23, 34);
            lblCodigoMedicamento.Name = "lblCodigoMedicamento";
            lblCodigoMedicamento.Size = new System.Drawing.Size(118, 14);
            lblCodigoMedicamento.TabIndex = 13;
            lblCodigoMedicamento.Text = "ID del Medicamento";
            // 
            // txtCodigoMedicamento
            // 
            txtCodigoMedicamento.Enabled = false;
            txtCodigoMedicamento.Location = new System.Drawing.Point(23, 51);
            txtCodigoMedicamento.Name = "txtCodigoMedicamento";
            txtCodigoMedicamento.Size = new System.Drawing.Size(180, 26);
            txtCodigoMedicamento.TabIndex = 12;
            // 
            // dateCaducidad
            // 
            dateCaducidad.CustomFormat = "yyyy/MM/dd";
            dateCaducidad.Enabled = false;
            dateCaducidad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateCaducidad.Location = new System.Drawing.Point(23, 223);
            dateCaducidad.Name = "dateCaducidad";
            dateCaducidad.Size = new System.Drawing.Size(180, 22);
            dateCaducidad.TabIndex = 11;
            // 
            // lblExpira
            // 
            lblExpira.AutoSize = true;
            lblExpira.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblExpira.Location = new System.Drawing.Point(23, 206);
            lblExpira.Name = "lblExpira";
            lblExpira.Size = new System.Drawing.Size(64, 14);
            lblExpira.TabIndex = 10;
            lblExpira.Text = "Caducidad";
            // 
            // txtCantidadMedicamentos
            // 
            txtCantidadMedicamentos.Enabled = false;
            txtCantidadMedicamentos.Location = new System.Drawing.Point(23, 163);
            txtCantidadMedicamentos.Name = "txtCantidadMedicamentos";
            txtCantidadMedicamentos.Size = new System.Drawing.Size(180, 26);
            txtCantidadMedicamentos.TabIndex = 9;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCantidad.Location = new System.Drawing.Point(23, 146);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(55, 14);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad";
            // 
            // dgrListaMedicamentos
            // 
            dgrListaMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgrListaMedicamentos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgrListaMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrListaMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { inventario_id, producto, cantidad, fecha_caducidad, precio, proveedor });
            dgrListaMedicamentos.Location = new System.Drawing.Point(18, 34);
            dgrListaMedicamentos.Name = "dgrListaMedicamentos";
            dgrListaMedicamentos.RowTemplate.Height = 25;
            dgrListaMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgrListaMedicamentos.Size = new System.Drawing.Size(816, 341);
            dgrListaMedicamentos.TabIndex = 15;
            dgrListaMedicamentos.Click += dgrListaMedicamentos_Click;
            // 
            // inventario_id
            // 
            inventario_id.DataPropertyName = "Inventario_Id";
            inventario_id.HeaderText = "ID";
            inventario_id.Name = "inventario_id";
            // 
            // producto
            // 
            producto.DataPropertyName = "Producto";
            producto.HeaderText = "PRODUTO";
            producto.Name = "producto";
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "Cantidad";
            cantidad.HeaderText = "CANTIDAD";
            cantidad.Name = "cantidad";
            // 
            // fecha_caducidad
            // 
            fecha_caducidad.DataPropertyName = "Caducidad";
            fecha_caducidad.HeaderText = "CADUCIDAD";
            fecha_caducidad.Name = "fecha_caducidad";
            // 
            // precio
            // 
            precio.DataPropertyName = "Precio_Unitario";
            precio.HeaderText = "PRECIO/U";
            precio.Name = "precio";
            // 
            // proveedor
            // 
            proveedor.DataPropertyName = "Proveedor";
            proveedor.HeaderText = "PROVEEDOR";
            proveedor.Name = "proveedor";
            // 
            // groupListaMed
            // 
            groupListaMed.Controls.Add(dgrListaMedicamentos);
            groupListaMed.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupListaMed.Location = new System.Drawing.Point(260, 12);
            groupListaMed.Name = "groupListaMed";
            groupListaMed.Size = new System.Drawing.Size(850, 413);
            groupListaMed.TabIndex = 16;
            groupListaMed.TabStop = false;
            groupListaMed.Text = "Lista Medicamentos";
            // 
            // btnGuardarInventario
            // 
            btnGuardarInventario.Enabled = false;
            btnGuardarInventario.Location = new System.Drawing.Point(990, 444);
            btnGuardarInventario.Name = "btnGuardarInventario";
            btnGuardarInventario.Size = new System.Drawing.Size(120, 61);
            btnGuardarInventario.TabIndex = 33;
            btnGuardarInventario.Text = "GUARDAR";
            btnGuardarInventario.UseVisualStyleBackColor = true;
            btnGuardarInventario.Click += btnGuardarInventario_Click;
            // 
            // btnBuscarMedicamento
            // 
            btnBuscarMedicamento.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBuscarMedicamento.Location = new System.Drawing.Point(484, 444);
            btnBuscarMedicamento.Name = "btnBuscarMedicamento";
            btnBuscarMedicamento.Size = new System.Drawing.Size(120, 61);
            btnBuscarMedicamento.TabIndex = 32;
            btnBuscarMedicamento.Text = "BUSCAR";
            btnBuscarMedicamento.UseVisualStyleBackColor = true;
            btnBuscarMedicamento.Click += btnBuscarMedicamento_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.Location = new System.Drawing.Point(12, 444);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(229, 61);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEditarInventario
            // 
            btnEditarInventario.Location = new System.Drawing.Point(736, 444);
            btnEditarInventario.Name = "btnEditarInventario";
            btnEditarInventario.Size = new System.Drawing.Size(120, 61);
            btnEditarInventario.TabIndex = 30;
            btnEditarInventario.Text = "EDITAR";
            btnEditarInventario.UseVisualStyleBackColor = true;
            btnEditarInventario.Click += btnEditarEspecialidad_Click;
            // 
            // btnEliminarInventario
            // 
            btnEliminarInventario.Location = new System.Drawing.Point(610, 444);
            btnEliminarInventario.Name = "btnEliminarInventario";
            btnEliminarInventario.Size = new System.Drawing.Size(120, 61);
            btnEliminarInventario.TabIndex = 29;
            btnEliminarInventario.Text = "ELIMINAR";
            btnEliminarInventario.UseVisualStyleBackColor = true;
            btnEliminarInventario.Click += btnEliminarInventario_Click;
            // 
            // btnNuevoInventario
            // 
            btnNuevoInventario.Location = new System.Drawing.Point(864, 444);
            btnNuevoInventario.Name = "btnNuevoInventario";
            btnNuevoInventario.Size = new System.Drawing.Size(120, 61);
            btnNuevoInventario.TabIndex = 28;
            btnNuevoInventario.Text = "NUEVO";
            btnNuevoInventario.UseVisualStyleBackColor = true;
            btnNuevoInventario.Click += btnNuevoInventario_Click;
            // 
            // Frm_Inventario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1132, 522);
            Controls.Add(btnGuardarInventario);
            Controls.Add(btnBuscarMedicamento);
            Controls.Add(btnSalir);
            Controls.Add(btnEditarInventario);
            Controls.Add(btnEliminarInventario);
            Controls.Add(btnNuevoInventario);
            Controls.Add(groupListaMed);
            Controls.Add(groupMedicamentos);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Inventario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Medicamentos";
            Load += Frm_Inventario_Load;
            groupMedicamentos.ResumeLayout(false);
            groupMedicamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrListaMedicamentos).EndInit();
            groupListaMed.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.Label lblNombreMedicamento;
        private System.Windows.Forms.GroupBox groupMedicamentos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidadMedicamentos;
        private System.Windows.Forms.Label lblExpira;
        private System.Windows.Forms.Label lblCodigoMedicamento;
        private System.Windows.Forms.TextBox txtCodigoMedicamento;
        private System.Windows.Forms.DataGridView dgrListaMedicamentos;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.GroupBox groupListaMed;
        private System.Windows.Forms.Button btnGuardarInventario;
        private System.Windows.Forms.Button btnBuscarMedicamento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditarInventario;
        private System.Windows.Forms.Button btnEliminarInventario;
        private System.Windows.Forms.Button btnNuevoInventario;
        private System.Windows.Forms.Label lblRequeridos;
        public System.Windows.Forms.DateTimePicker dateCaducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
    }
}