namespace _01_CapaPresentacion
{
    partial class Frm_Facturacion
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
            id_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            subtotalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            impuestoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            montoDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnBuscar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            lblFecha = new System.Windows.Forms.Label();
            txtFecha = new System.Windows.Forms.TextBox();
            txtIDFactura = new System.Windows.Forms.TextBox();
            lblID = new System.Windows.Forms.Label();
            lblIdCliente = new System.Windows.Forms.Label();
            txtIdCliente = new System.Windows.Forms.TextBox();
            lblSubtotal = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.TextBox();
            lblImpuesto = new System.Windows.Forms.Label();
            txtImpuesto = new System.Windows.Forms.TextBox();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblDescuento = new System.Windows.Forms.Label();
            txtMonto = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id_Factura, fechaFactura, id_Cliente, subtotalFactura, impuestoFactura, montoDescuento });
            dataGridView1.Location = new System.Drawing.Point(12, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(643, 289);
            dataGridView1.TabIndex = 0;
            // 
            // id_Factura
            // 
            id_Factura.DataPropertyName = "ID_FACTURA";
            id_Factura.HeaderText = "ID_FACTURA";
            id_Factura.Name = "id_Factura";
            // 
            // fechaFactura
            // 
            fechaFactura.DataPropertyName = "FECHA";
            fechaFactura.HeaderText = "FECHA";
            fechaFactura.Name = "fechaFactura";
            // 
            // id_Cliente
            // 
            id_Cliente.DataPropertyName = "ID_CLIENTE";
            id_Cliente.HeaderText = "ID_CLIENTE";
            id_Cliente.Name = "id_Cliente";
            // 
            // subtotalFactura
            // 
            subtotalFactura.DataPropertyName = "SUBTOTAL";
            subtotalFactura.HeaderText = "SUBTOTAL";
            subtotalFactura.Name = "subtotalFactura";
            // 
            // impuestoFactura
            // 
            impuestoFactura.DataPropertyName = "IMPUESTO";
            impuestoFactura.HeaderText = "IMPUESTO";
            impuestoFactura.Name = "impuestoFactura";
            // 
            // montoDescuento
            // 
            montoDescuento.DataPropertyName = "MONTO_DESCUENTO";
            montoDescuento.HeaderText = "MONTO_DESCUENTO";
            montoDescuento.MinimumWidth = 10;
            montoDescuento.Name = "montoDescuento";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(338, 498);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 74);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(257, 498);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 74);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(419, 498);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 74);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new System.Drawing.Point(581, 498);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(75, 74);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(500, 498);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 74);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(12, 99);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(38, 15);
            lblFecha.TabIndex = 24;
            lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = System.Drawing.SystemColors.Info;
            txtFecha.Enabled = false;
            txtFecha.Location = new System.Drawing.Point(12, 117);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new System.Drawing.Size(109, 23);
            txtFecha.TabIndex = 21;
            // 
            // txtIDFactura
            // 
            txtIDFactura.BackColor = System.Drawing.SystemColors.Info;
            txtIDFactura.Enabled = false;
            txtIDFactura.Location = new System.Drawing.Point(12, 62);
            txtIDFactura.Name = "txtIDFactura";
            txtIDFactura.Size = new System.Drawing.Size(109, 23);
            txtIDFactura.TabIndex = 20;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new System.Drawing.Point(12, 44);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(109, 15);
            lblID.TabIndex = 19;
            lblID.Text = "Numero de Factura";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new System.Drawing.Point(159, 99);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new System.Drawing.Size(77, 15);
            lblIdCliente.TabIndex = 26;
            lblIdCliente.Text = "ID del Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.BackColor = System.Drawing.SystemColors.Info;
            txtIdCliente.Enabled = false;
            txtIdCliente.Location = new System.Drawing.Point(159, 117);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new System.Drawing.Size(109, 23);
            txtIdCliente.TabIndex = 25;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new System.Drawing.Point(312, 99);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new System.Drawing.Size(51, 15);
            lblSubtotal.TabIndex = 28;
            lblSubtotal.Text = "Subtotal";
            // 
            // txtSubtotal
            // 
            txtSubtotal.BackColor = System.Drawing.SystemColors.Info;
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new System.Drawing.Point(312, 117);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new System.Drawing.Size(109, 23);
            txtSubtotal.TabIndex = 27;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new System.Drawing.Point(455, 99);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new System.Drawing.Size(57, 15);
            lblImpuesto.TabIndex = 30;
            lblImpuesto.Text = "Impuesto";
            // 
            // txtImpuesto
            // 
            txtImpuesto.BackColor = System.Drawing.SystemColors.Info;
            txtImpuesto.Enabled = false;
            txtImpuesto.Location = new System.Drawing.Point(455, 117);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new System.Drawing.Size(109, 23);
            txtImpuesto.TabIndex = 29;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView2.Location = new System.Drawing.Point(768, 189);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new System.Drawing.Size(338, 289);
            dataGridView2.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "ID_FACTURA";
            dataGridViewTextBoxColumn1.HeaderText = "ID_FACTURA";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "FECHA";
            dataGridViewTextBoxColumn2.HeaderText = "FECHA";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "ID_CLIENTE";
            dataGridViewTextBoxColumn3.HeaderText = "ID_CLIENTE";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new System.Drawing.Point(598, 99);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new System.Drawing.Size(95, 15);
            lblDescuento.TabIndex = 33;
            lblDescuento.Text = "Monto Descueto";
            // 
            // txtMonto
            // 
            txtMonto.BackColor = System.Drawing.SystemColors.Info;
            txtMonto.Enabled = false;
            txtMonto.Location = new System.Drawing.Point(598, 117);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new System.Drawing.Size(109, 23);
            txtMonto.TabIndex = 32;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(775, 498);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 74);
            button1.TabIndex = 37;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(856, 498);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 74);
            button2.TabIndex = 36;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(1018, 498);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 74);
            button3.TabIndex = 35;
            button3.Text = "Nuevo";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(937, 498);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(75, 74);
            button4.TabIndex = 34;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            // 
            // Frm_Facturacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1118, 712);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(lblDescuento);
            Controls.Add(txtMonto);
            Controls.Add(dataGridView2);
            Controls.Add(lblImpuesto);
            Controls.Add(txtImpuesto);
            Controls.Add(lblSubtotal);
            Controls.Add(txtSubtotal);
            Controls.Add(lblIdCliente);
            Controls.Add(txtIdCliente);
            Controls.Add(lblFecha);
            Controls.Add(txtFecha);
            Controls.Add(txtIDFactura);
            Controls.Add(lblID);
            Controls.Add(btnBuscar);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridView1);
            Name = "Frm_Facturacion";
            Text = "Frm_Facturacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuestoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDescuento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtIDFactura;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}