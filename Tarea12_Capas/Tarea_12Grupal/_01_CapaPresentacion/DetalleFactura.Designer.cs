namespace _01_CapaPresentacion
{
    partial class DetalleFactura
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
            id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidadDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id_Factura, id_Producto, cantidadDetalle });
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(342, 426);
            dataGridView1.TabIndex = 0;
            // 
            // id_Factura
            // 
            id_Factura.DataPropertyName = "ID_FACTURA";
            id_Factura.HeaderText = "ID_FACTURA";
            id_Factura.Name = "id_Factura";
            // 
            // id_Producto
            // 
            id_Producto.DataPropertyName = "ID_PRODUCTO";
            id_Producto.HeaderText = "ID_PRODUCTO";
            id_Producto.Name = "id_Producto";
            // 
            // cantidadDetalle
            // 
            cantidadDetalle.DataPropertyName = "CANTIDAD";
            cantidadDetalle.HeaderText = "CANTIDAD";
            cantidadDetalle.Name = "cantidadDetalle";
            // 
            // DetalleFactura
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(363, 450);
            Controls.Add(dataGridView1);
            Name = "DetalleFactura";
            Text = "DetalleFactura";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDetalle;
    }
}