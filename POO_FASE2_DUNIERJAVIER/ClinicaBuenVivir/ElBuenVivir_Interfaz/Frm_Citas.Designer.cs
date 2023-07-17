namespace ElBuenVivir_Interfaz
{
    partial class Frm_Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Citas));
            dateFechaCita = new System.Windows.Forms.DateTimePicker();
            btnGuardar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            comboEstado = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            txtObservaciones = new System.Windows.Forms.TextBox();
            lblObservaciones = new System.Windows.Forms.Label();
            txtMotivo = new System.Windows.Forms.TextBox();
            lblMotivo = new System.Windows.Forms.Label();
            txtNombreCompleto = new System.Windows.Forms.TextBox();
            lblNombreCompleto = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            txtMontoPagar = new System.Windows.Forms.TextBox();
            lblMontoPagar = new System.Windows.Forms.Label();
            lblMetodoPago = new System.Windows.Forms.Label();
            comboMetodoPago = new System.Windows.Forms.ComboBox();
            comboMedicos = new System.Windows.Forms.ComboBox();
            lblMedico = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtNumCita = new System.Windows.Forms.TextBox();
            lblID = new System.Windows.Forms.Label();
            lblCitaId = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            lblHora = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            comboHorasDisponibles = new System.Windows.Forms.ComboBox();
            dgrListarCitas = new System.Windows.Forms.DataGridView();
            citasid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            horarioid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pagoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            metodo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrListarCitas).BeginInit();
            SuspendLayout();
            // 
            // dateFechaCita
            // 
            dateFechaCita.Enabled = false;
            dateFechaCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateFechaCita.Location = new System.Drawing.Point(19, 113);
            dateFechaCita.Name = "dateFechaCita";
            dateFechaCita.Size = new System.Drawing.Size(139, 26);
            dateFechaCita.TabIndex = 2;
            dateFechaCita.ValueChanged += dateFechaCita_ValueChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(1052, 721);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(120, 61);
            btnGuardar.TabIndex = 56;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.Location = new System.Drawing.Point(15, 721);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(242, 61);
            btnSalir.TabIndex = 54;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboEstado);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(lblObservaciones);
            groupBox1.Controls.Add(txtMotivo);
            groupBox1.Controls.Add(lblMotivo);
            groupBox1.Controls.Add(txtNombreCompleto);
            groupBox1.Controls.Add(lblNombreCompleto);
            groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(15, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(785, 309);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del paciente";
            // 
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Items.AddRange(new object[] { "Activo", "Inactivo", "Cancelado" });
            comboEstado.Location = new System.Drawing.Point(462, 108);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new System.Drawing.Size(307, 26);
            comboEstado.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(462, 91);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 14);
            label3.TabIndex = 61;
            label3.Text = "Estado";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new System.Drawing.Point(23, 170);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new System.Drawing.Size(746, 122);
            txtObservaciones.TabIndex = 60;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblObservaciones.Location = new System.Drawing.Point(23, 152);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new System.Drawing.Size(87, 14);
            lblObservaciones.TabIndex = 59;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new System.Drawing.Point(23, 109);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new System.Drawing.Size(403, 26);
            txtMotivo.TabIndex = 5;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMotivo.Location = new System.Drawing.Point(23, 91);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new System.Drawing.Size(43, 14);
            lblMotivo.TabIndex = 4;
            lblMotivo.Text = "Motivo";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Enabled = false;
            txtNombreCompleto.Location = new System.Drawing.Point(23, 49);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new System.Drawing.Size(746, 26);
            txtNombreCompleto.TabIndex = 3;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombreCompleto.Location = new System.Drawing.Point(23, 31);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new System.Drawing.Size(104, 14);
            lblNombreCompleto.TabIndex = 2;
            lblNombreCompleto.Text = "Nombre completo";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtMontoPagar);
            groupBox4.Controls.Add(lblMontoPagar);
            groupBox4.Controls.Add(lblMetodoPago);
            groupBox4.Controls.Add(comboMetodoPago);
            groupBox4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox4.Location = new System.Drawing.Point(838, 213);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(334, 186);
            groupBox4.TabIndex = 58;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pago servicios";
            // 
            // txtMontoPagar
            // 
            txtMontoPagar.Location = new System.Drawing.Point(19, 47);
            txtMontoPagar.Name = "txtMontoPagar";
            txtMontoPagar.Size = new System.Drawing.Size(291, 26);
            txtMontoPagar.TabIndex = 11;
            // 
            // lblMontoPagar
            // 
            lblMontoPagar.AutoSize = true;
            lblMontoPagar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMontoPagar.Location = new System.Drawing.Point(19, 29);
            lblMontoPagar.Name = "lblMontoPagar";
            lblMontoPagar.Size = new System.Drawing.Size(86, 14);
            lblMontoPagar.TabIndex = 10;
            lblMontoPagar.Text = "Monto a pagar";
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMetodoPago.Location = new System.Drawing.Point(19, 93);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new System.Drawing.Size(96, 14);
            lblMetodoPago.TabIndex = 8;
            lblMetodoPago.Text = "Método de pago";
            // 
            // comboMetodoPago
            // 
            comboMetodoPago.FormattingEnabled = true;
            comboMetodoPago.Items.AddRange(new object[] { "Visa", "Paypal", "Efectivo", "Cheque", "Apple Pay", "Google Pay", "MasterCard", "Sinpe Movil", "Transferencia", "Orden de dinero", "American Express" });
            comboMetodoPago.Location = new System.Drawing.Point(19, 110);
            comboMetodoPago.Name = "comboMetodoPago";
            comboMetodoPago.Size = new System.Drawing.Size(298, 26);
            comboMetodoPago.TabIndex = 9;
            // 
            // comboMedicos
            // 
            comboMedicos.FormattingEnabled = true;
            comboMedicos.Location = new System.Drawing.Point(19, 49);
            comboMedicos.Name = "comboMedicos";
            comboMedicos.Size = new System.Drawing.Size(298, 26);
            comboMedicos.TabIndex = 64;
            comboMedicos.SelectedIndexChanged += comboMedicos_SelectedIndexChanged;
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Enabled = false;
            lblMedico.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMedico.Location = new System.Drawing.Point(19, 32);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new System.Drawing.Size(47, 14);
            lblMedico.TabIndex = 63;
            lblMedico.Text = "Médico";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNumCita);
            groupBox2.Controls.Add(lblID);
            groupBox2.Controls.Add(lblCitaId);
            groupBox2.Controls.Add(txtID);
            groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(15, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(785, 75);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del paciente";
            // 
            // txtNumCita
            // 
            txtNumCita.Enabled = false;
            txtNumCita.Location = new System.Drawing.Point(559, 26);
            txtNumCita.Name = "txtNumCita";
            txtNumCita.Size = new System.Drawing.Size(210, 26);
            txtNumCita.TabIndex = 48;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblID.Location = new System.Drawing.Point(23, 34);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(143, 14);
            lblID.TabIndex = 37;
            lblID.Text = "Número de Identificación";
            // 
            // lblCitaId
            // 
            lblCitaId.AutoSize = true;
            lblCitaId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCitaId.Location = new System.Drawing.Point(462, 32);
            lblCitaId.Name = "lblCitaId";
            lblCitaId.Size = new System.Drawing.Size(91, 14);
            lblCitaId.TabIndex = 21;
            lblCitaId.Text = "Número de Cita";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new System.Drawing.Point(172, 26);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(254, 26);
            txtID.TabIndex = 38;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboMedicos);
            groupBox3.Controls.Add(lblHora);
            groupBox3.Controls.Add(lblMedico);
            groupBox3.Controls.Add(lblFecha);
            groupBox3.Controls.Add(comboHorasDisponibles);
            groupBox3.Controls.Add(dateFechaCita);
            groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.Location = new System.Drawing.Point(838, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(334, 186);
            groupBox3.TabIndex = 59;
            groupBox3.TabStop = false;
            groupBox3.Text = "Horario de la cita";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Enabled = false;
            lblHora.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblHora.Location = new System.Drawing.Point(178, 94);
            lblHora.Name = "lblHora";
            lblHora.Size = new System.Drawing.Size(33, 14);
            lblHora.TabIndex = 11;
            lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFecha.Location = new System.Drawing.Point(19, 94);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(39, 14);
            lblFecha.TabIndex = 10;
            lblFecha.Text = "Fecha";
            // 
            // comboHorasDisponibles
            // 
            comboHorasDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboHorasDisponibles.Enabled = false;
            comboHorasDisponibles.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboHorasDisponibles.FormattingEnabled = true;
            comboHorasDisponibles.Location = new System.Drawing.Point(178, 113);
            comboHorasDisponibles.Name = "comboHorasDisponibles";
            comboHorasDisponibles.Size = new System.Drawing.Size(139, 26);
            comboHorasDisponibles.TabIndex = 9;
            comboHorasDisponibles.SelectedIndexChanged += comboHorasDisponibles_SelectedIndexChanged;
            comboHorasDisponibles.Click += comboHorasDisponibles_Click;
            // 
            // dgrListarCitas
            // 
            dgrListarCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgrListarCitas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgrListarCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrListarCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { citasid, horarioid, pagoid, estado, motivo, observaciones, metodo_pago });
            dgrListarCitas.Location = new System.Drawing.Point(12, 419);
            dgrListarCitas.Name = "dgrListarCitas";
            dgrListarCitas.RowHeadersVisible = false;
            dgrListarCitas.RowTemplate.Height = 25;
            dgrListarCitas.Size = new System.Drawing.Size(1160, 279);
            dgrListarCitas.TabIndex = 60;
            // 
            // citasid
            // 
            citasid.DataPropertyName = "CitasId";
            citasid.HeaderText = "CITAS_ID";
            citasid.Name = "citasid";
            // 
            // horarioid
            // 
            horarioid.DataPropertyName = "HorarioId";
            horarioid.HeaderText = "HORARIO_ID";
            horarioid.Name = "horarioid";
            // 
            // pagoid
            // 
            pagoid.DataPropertyName = "PagoId";
            pagoid.HeaderText = "PAGO_ID";
            pagoid.Name = "pagoid";
            // 
            // estado
            // 
            estado.DataPropertyName = "Estado";
            estado.HeaderText = "ESTADO";
            estado.Name = "estado";
            // 
            // motivo
            // 
            motivo.DataPropertyName = "Motivo";
            motivo.HeaderText = "MOTIVO";
            motivo.Name = "motivo";
            // 
            // observaciones
            // 
            observaciones.DataPropertyName = "Observaciones";
            observaciones.HeaderText = "OBSERVACIONES";
            observaciones.Name = "observaciones";
            // 
            // metodo_pago
            // 
            metodo_pago.DataPropertyName = "Metodo_Pago";
            metodo_pago.HeaderText = "METODO_PAGO";
            metodo_pago.Name = "metodo_pago";
            // 
            // Frm_Citas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1184, 794);
            Controls.Add(dgrListarCitas);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalir);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Citas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Citas";
            FormClosing += Frm_Citas_FormClosing;
            Load += Frm_Horarios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrListarCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateFechaCita;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumCita;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCitaId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.ComboBox comboMetodoPago;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMedicos;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.ComboBox comboHorasDisponibles;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtMontoPagar;
        private System.Windows.Forms.Label lblMontoPagar;
        private System.Windows.Forms.DataGridView dgrListarCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn citasid;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodo_pago;
    }
}