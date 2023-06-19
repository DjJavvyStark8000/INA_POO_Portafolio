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
            lblProveedor = new System.Windows.Forms.Label();
            txtProveedor = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtCantidad = new System.Windows.Forms.TextBox();
            lblCodigoReceta = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            lblCodigoMedicamento = new System.Windows.Forms.Label();
            txtCodigoMedicamento = new System.Windows.Forms.TextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            lblExpira = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            lblCantidad = new System.Windows.Forms.Label();
            dgrListaMedicamentos = new System.Windows.Forms.DataGridView();
            inventario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            recetas_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fecha_caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupListaMed = new System.Windows.Forms.GroupBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscarEspecial = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEditarEspecialidad = new System.Windows.Forms.Button();
            btnEliminarEspecialidad = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            groupMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrListaMedicamentos).BeginInit();
            groupListaMed.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreMedicamento
            // 
            txtNombreMedicamento.Location = new System.Drawing.Point(23, 170);
            txtNombreMedicamento.Name = "txtNombreMedicamento";
            txtNombreMedicamento.Size = new System.Drawing.Size(180, 26);
            txtNombreMedicamento.TabIndex = 8;
            // 
            // lblNombreMedicamento
            // 
            lblNombreMedicamento.AutoSize = true;
            lblNombreMedicamento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombreMedicamento.Location = new System.Drawing.Point(23, 153);
            lblNombreMedicamento.Name = "lblNombreMedicamento";
            lblNombreMedicamento.Size = new System.Drawing.Size(149, 14);
            lblNombreMedicamento.TabIndex = 7;
            lblNombreMedicamento.Text = "Nombre del Medicamento";
            // 
            // groupMedicamentos
            // 
            groupMedicamentos.Controls.Add(lblProveedor);
            groupMedicamentos.Controls.Add(txtProveedor);
            groupMedicamentos.Controls.Add(label1);
            groupMedicamentos.Controls.Add(txtCantidad);
            groupMedicamentos.Controls.Add(lblCodigoReceta);
            groupMedicamentos.Controls.Add(textBox2);
            groupMedicamentos.Controls.Add(lblCodigoMedicamento);
            groupMedicamentos.Controls.Add(txtCodigoMedicamento);
            groupMedicamentos.Controls.Add(dateTimePicker1);
            groupMedicamentos.Controls.Add(lblExpira);
            groupMedicamentos.Controls.Add(lblNombreMedicamento);
            groupMedicamentos.Controls.Add(txtNombreMedicamento);
            groupMedicamentos.Controls.Add(textBox1);
            groupMedicamentos.Controls.Add(lblCantidad);
            groupMedicamentos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupMedicamentos.Location = new System.Drawing.Point(12, 12);
            groupMedicamentos.Name = "groupMedicamentos";
            groupMedicamentos.Size = new System.Drawing.Size(229, 501);
            groupMedicamentos.TabIndex = 13;
            groupMedicamentos.TabStop = false;
            groupMedicamentos.Text = "Medicamentos";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblProveedor.Location = new System.Drawing.Point(23, 378);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new System.Drawing.Size(61, 14);
            lblProveedor.TabIndex = 18;
            lblProveedor.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new System.Drawing.Point(23, 395);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new System.Drawing.Size(180, 26);
            txtProveedor.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(23, 323);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 14);
            label1.TabIndex = 16;
            label1.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new System.Drawing.Point(23, 340);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(180, 26);
            txtCantidad.TabIndex = 17;
            // 
            // lblCodigoReceta
            // 
            lblCodigoReceta.AutoSize = true;
            lblCodigoReceta.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCodigoReceta.Location = new System.Drawing.Point(23, 92);
            lblCodigoReceta.Name = "lblCodigoReceta";
            lblCodigoReceta.Size = new System.Drawing.Size(44, 14);
            lblCodigoReceta.TabIndex = 15;
            lblCodigoReceta.Text = "Receta";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new System.Drawing.Point(23, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(180, 26);
            textBox2.TabIndex = 14;
            // 
            // lblCodigoMedicamento
            // 
            lblCodigoMedicamento.AutoSize = true;
            lblCodigoMedicamento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCodigoMedicamento.Location = new System.Drawing.Point(23, 34);
            lblCodigoMedicamento.Name = "lblCodigoMedicamento";
            lblCodigoMedicamento.Size = new System.Drawing.Size(44, 14);
            lblCodigoMedicamento.TabIndex = 13;
            lblCodigoMedicamento.Text = "Código";
            // 
            // txtCodigoMedicamento
            // 
            txtCodigoMedicamento.Enabled = false;
            txtCodigoMedicamento.Location = new System.Drawing.Point(23, 51);
            txtCodigoMedicamento.Name = "txtCodigoMedicamento";
            txtCodigoMedicamento.Size = new System.Drawing.Size(180, 26);
            txtCodigoMedicamento.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePicker1.Location = new System.Drawing.Point(23, 286);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(180, 22);
            dateTimePicker1.TabIndex = 11;
            // 
            // lblExpira
            // 
            lblExpira.AutoSize = true;
            lblExpira.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblExpira.Location = new System.Drawing.Point(23, 269);
            lblExpira.Name = "lblExpira";
            lblExpira.Size = new System.Drawing.Size(64, 14);
            lblExpira.TabIndex = 10;
            lblExpira.Text = "Caducidad";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(23, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(180, 26);
            textBox1.TabIndex = 9;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCantidad.Location = new System.Drawing.Point(23, 209);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(55, 14);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad";
            // 
            // dgrListaMedicamentos
            // 
            dgrListaMedicamentos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgrListaMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrListaMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { inventario_id, recetas_id, producto, cantidad, fecha_caducidad, precio, proveedor });
            dgrListaMedicamentos.Location = new System.Drawing.Point(18, 34);
            dgrListaMedicamentos.Name = "dgrListaMedicamentos";
            dgrListaMedicamentos.RowTemplate.Height = 25;
            dgrListaMedicamentos.Size = new System.Drawing.Size(816, 444);
            dgrListaMedicamentos.TabIndex = 15;
            // 
            // inventario_id
            // 
            inventario_id.DataPropertyName = "Inventario_Id";
            inventario_id.HeaderText = "ID";
            inventario_id.Name = "inventario_id";
            // 
            // recetas_id
            // 
            recetas_id.DataPropertyName = "Receta_Id";
            recetas_id.HeaderText = "RECETA";
            recetas_id.Name = "recetas_id";
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
            groupListaMed.Size = new System.Drawing.Size(850, 501);
            groupListaMed.TabIndex = 16;
            groupListaMed.TabStop = false;
            groupListaMed.Text = "Lista Medicamentos";
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new System.Drawing.Point(990, 533);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(120, 61);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarEspecial
            // 
            btnBuscarEspecial.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBuscarEspecial.Location = new System.Drawing.Point(484, 533);
            btnBuscarEspecial.Name = "btnBuscarEspecial";
            btnBuscarEspecial.Size = new System.Drawing.Size(120, 61);
            btnBuscarEspecial.TabIndex = 32;
            btnBuscarEspecial.Text = "BUSCAR";
            btnBuscarEspecial.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.Location = new System.Drawing.Point(12, 533);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(229, 61);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditarEspecialidad
            // 
            btnEditarEspecialidad.Location = new System.Drawing.Point(736, 533);
            btnEditarEspecialidad.Name = "btnEditarEspecialidad";
            btnEditarEspecialidad.Size = new System.Drawing.Size(120, 61);
            btnEditarEspecialidad.TabIndex = 30;
            btnEditarEspecialidad.Text = "EDITAR";
            btnEditarEspecialidad.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEspecialidad
            // 
            btnEliminarEspecialidad.Location = new System.Drawing.Point(610, 533);
            btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            btnEliminarEspecialidad.Size = new System.Drawing.Size(120, 61);
            btnEliminarEspecialidad.TabIndex = 29;
            btnEliminarEspecialidad.Text = "ELIMINAR";
            btnEliminarEspecialidad.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new System.Drawing.Point(864, 533);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(120, 61);
            btnNuevo.TabIndex = 28;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // Frm_Inventario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1132, 616);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscarEspecial);
            Controls.Add(btnSalir);
            Controls.Add(btnEditarEspecialidad);
            Controls.Add(btnEliminarEspecialidad);
            Controls.Add(btnNuevo);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblExpira;
        private System.Windows.Forms.Label lblCodigoMedicamento;
        private System.Windows.Forms.TextBox txtCodigoMedicamento;
        private System.Windows.Forms.DataGridView dgrListaMedicamentos;
        private System.Windows.Forms.Label lblCodigoReceta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupListaMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn recetas_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarEspecial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditarEspecialidad;
        private System.Windows.Forms.Button btnEliminarEspecialidad;
        private System.Windows.Forms.Button btnNuevo;
    }
}