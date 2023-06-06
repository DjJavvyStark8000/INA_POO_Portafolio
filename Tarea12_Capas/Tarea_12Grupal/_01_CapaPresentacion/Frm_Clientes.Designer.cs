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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            telefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            direccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id_Cliente, nombreCliente, telefonoCliente, direccionCliente });
            dataGridView1.Location = new System.Drawing.Point(8, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(428, 377);
            dataGridView1.TabIndex = 0;
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
            // Frm_Clientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(445, 398);
            Controls.Add(dataGridView1);
            Name = "Frm_Clientes";
            Text = "Frm_Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionCliente;
    }
}