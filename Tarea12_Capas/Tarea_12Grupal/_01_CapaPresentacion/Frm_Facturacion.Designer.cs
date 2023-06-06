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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id_Factura, fechaFactura, id_Cliente, subtotalFactura, impuestoFactura, montoDescuento });
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(643, 415);
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
            // Frm_Facturacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(664, 437);
            Controls.Add(dataGridView1);
            Name = "Frm_Facturacion";
            Text = "Frm_Facturacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuestoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDescuento;
    }
}