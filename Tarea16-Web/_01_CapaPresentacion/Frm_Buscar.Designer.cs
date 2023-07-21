namespace _01_CapaPresentacion
{
    partial class Frm_Buscar
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
            lblBuscar = new System.Windows.Forms.Label();
            txtBuscarCliente = new System.Windows.Forms.TextBox();
            btnBuscar = new System.Windows.Forms.Button();
            dgrClientes = new System.Windows.Forms.DataGridView();
            id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            telefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            direccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnAceptar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgrClientes).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new System.Drawing.Point(27, 9);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(82, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar Cliente";
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new System.Drawing.Point(27, 25);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new System.Drawing.Size(393, 23);
            txtBuscarCliente.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(27, 54);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgrClientes
            // 
            dgrClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id_Cliente, nombreCliente, telefonoCliente, direccionCliente });
            dgrClientes.Location = new System.Drawing.Point(27, 98);
            dgrClientes.Name = "dgrClientes";
            dgrClientes.RowTemplate.Height = 25;
            dgrClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgrClientes.Size = new System.Drawing.Size(595, 404);
            dgrClientes.TabIndex = 3;
            dgrClientes.DoubleClick += dgrClientes_DoubleClick;
            // 
            // id_Cliente
            // 
            id_Cliente.DataPropertyName = "Id_Cliente";
            id_Cliente.HeaderText = "ID_CLIENTE";
            id_Cliente.Name = "id_Cliente";
            // 
            // nombreCliente
            // 
            nombreCliente.DataPropertyName = "Nombre";
            nombreCliente.HeaderText = "NOMBRE";
            nombreCliente.Name = "nombreCliente";
            // 
            // telefonoCliente
            // 
            telefonoCliente.DataPropertyName = "Telefono";
            telefonoCliente.HeaderText = "TELEFONO";
            telefonoCliente.Name = "telefonoCliente";
            // 
            // direccionCliente
            // 
            direccionCliente.DataPropertyName = "Direccion";
            direccionCliente.HeaderText = "DIRECCION";
            direccionCliente.Name = "direccionCliente";
            direccionCliente.Width = 250;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new System.Drawing.Point(466, 526);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(547, 526);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Frm_Buscar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(651, 573);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dgrClientes);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarCliente);
            Controls.Add(lblBuscar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Buscar";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Buscar";
            Load += Frm_Buscar_Load;
            ((System.ComponentModel.ISupportInitialize)dgrClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgrClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionCliente;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}