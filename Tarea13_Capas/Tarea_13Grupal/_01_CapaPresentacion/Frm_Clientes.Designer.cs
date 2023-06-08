namespace _01_CapaPresentacion
{
    partial class Frm_Clientes
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
            dgrClientes = new System.Windows.Forms.DataGridView();
            id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            telefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            direccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnBuscar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            lblID = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtDireccion = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            lblTelefono = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgrClientes).BeginInit();
            SuspendLayout();
            // 
            // dgrClientes
            // 
            dgrClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id_Cliente, nombreCliente, telefonoCliente, direccionCliente });
            dgrClientes.Location = new System.Drawing.Point(38, 169);
            dgrClientes.Name = "dgrClientes";
            dgrClientes.RowTemplate.Height = 25;
            dgrClientes.Size = new System.Drawing.Size(544, 404);
            dgrClientes.TabIndex = 0;
            // 
            // id_Cliente
            // 
            id_Cliente.DataPropertyName = "ID_CLIENTE";
            id_Cliente.HeaderText = "ID_CLIENTE";
            id_Cliente.Name = "id_Cliente";
            // 
            // nombreCliente
            // 
            nombreCliente.DataPropertyName = "NOMBRE";
            nombreCliente.HeaderText = "NOMBRE";
            nombreCliente.Name = "nombreCliente";
            // 
            // telefonoCliente
            // 
            telefonoCliente.DataPropertyName = "TELEFONO";
            telefonoCliente.HeaderText = "TELEFONO";
            telefonoCliente.Name = "telefonoCliente";
            // 
            // direccionCliente
            // 
            direccionCliente.DataPropertyName = "DIRECCION";
            direccionCliente.HeaderText = "DIRECCION";
            direccionCliente.Name = "direccionCliente";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(264, 603);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 74);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(183, 603);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 74);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(345, 603);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 74);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new System.Drawing.Point(507, 603);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(75, 74);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(426, 603);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 74);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new System.Drawing.Point(35, 30);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(79, 15);
            lblID.TabIndex = 11;
            lblID.Text = "Identificacion";
            // 
            // txtID
            // 
            txtID.BackColor = System.Drawing.SystemColors.Info;
            txtID.Enabled = false;
            txtID.Location = new System.Drawing.Point(35, 48);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(109, 23);
            txtID.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = System.Drawing.SystemColors.Info;
            txtNombre.Location = new System.Drawing.Point(35, 103);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(109, 23);
            txtNombre.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = System.Drawing.SystemColors.Info;
            txtTelefono.Location = new System.Drawing.Point(160, 103);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(165, 23);
            txtTelefono.TabIndex = 14;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = System.Drawing.SystemColors.Info;
            txtDireccion.Location = new System.Drawing.Point(348, 103);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(235, 60);
            txtDireccion.TabIndex = 15;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(35, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(51, 15);
            lblNombre.TabIndex = 16;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new System.Drawing.Point(160, 85);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(52, 15);
            lblTelefono.TabIndex = 17;
            lblTelefono.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(348, 85);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 15);
            label2.TabIndex = 18;
            label2.Text = "Direccion";
            // 
            // Frm_Clientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(619, 689);
            Controls.Add(label2);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(btnBuscar);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(dgrClientes);
            Name = "Frm_Clientes";
            Text = "Clientes";
            Load += Frm_Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgrClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgrClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label2;
    }
}