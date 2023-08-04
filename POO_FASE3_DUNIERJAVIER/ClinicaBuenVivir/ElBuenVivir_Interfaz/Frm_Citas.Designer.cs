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
            this.dateFechaCita = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMontoPagar = new System.Windows.Forms.TextBox();
            this.lblMontoPagar = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.comboMetodoPago = new System.Windows.Forms.ComboBox();
            this.comboMedicos = new System.Windows.Forms.ComboBox();
            this.lblMedico = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumCita = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCitaId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.comboHorasDisponibles = new System.Windows.Forms.ComboBox();
            this.dgrListarCitas = new System.Windows.Forms.DataGridView();
            this.citasid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrListarCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFechaCita
            // 
            this.dateFechaCita.Enabled = false;
            this.dateFechaCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaCita.Location = new System.Drawing.Point(19, 113);
            this.dateFechaCita.Name = "dateFechaCita";
            this.dateFechaCita.Size = new System.Drawing.Size(139, 26);
            this.dateFechaCita.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(1052, 721);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 61);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(15, 721);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(242, 61);
            this.btnSalir.TabIndex = 54;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboEstado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.lblObservaciones);
            this.groupBox1.Controls.Add(this.txtMotivo);
            this.groupBox1.Controls.Add(this.lblMotivo);
            this.groupBox1.Controls.Add(this.txtNombreCompleto);
            this.groupBox1.Controls.Add(this.lblNombreCompleto);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(15, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 309);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del paciente";
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Cancelado"});
            this.comboEstado.Location = new System.Drawing.Point(462, 108);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(307, 26);
            this.comboEstado.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(462, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 61;
            this.label3.Text = "Estado";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(23, 170);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(746, 122);
            this.txtObservaciones.TabIndex = 60;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblObservaciones.Location = new System.Drawing.Point(23, 152);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(87, 14);
            this.lblObservaciones.TabIndex = 59;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(23, 109);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(403, 26);
            this.txtMotivo.TabIndex = 5;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMotivo.Location = new System.Drawing.Point(23, 91);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(43, 14);
            this.lblMotivo.TabIndex = 4;
            this.lblMotivo.Text = "Motivo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Enabled = false;
            this.txtNombreCompleto.Location = new System.Drawing.Point(23, 49);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(746, 26);
            this.txtNombreCompleto.TabIndex = 3;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCompleto.Location = new System.Drawing.Point(23, 31);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(104, 14);
            this.lblNombreCompleto.TabIndex = 2;
            this.lblNombreCompleto.Text = "Nombre completo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMontoPagar);
            this.groupBox4.Controls.Add(this.lblMontoPagar);
            this.groupBox4.Controls.Add(this.lblMetodoPago);
            this.groupBox4.Controls.Add(this.comboMetodoPago);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(838, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 186);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pago servicios";
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Location = new System.Drawing.Point(19, 47);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Size = new System.Drawing.Size(291, 26);
            this.txtMontoPagar.TabIndex = 11;
            // 
            // lblMontoPagar
            // 
            this.lblMontoPagar.AutoSize = true;
            this.lblMontoPagar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMontoPagar.Location = new System.Drawing.Point(19, 29);
            this.lblMontoPagar.Name = "lblMontoPagar";
            this.lblMontoPagar.Size = new System.Drawing.Size(86, 14);
            this.lblMontoPagar.TabIndex = 10;
            this.lblMontoPagar.Text = "Monto a pagar";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetodoPago.Location = new System.Drawing.Point(19, 93);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(96, 14);
            this.lblMetodoPago.TabIndex = 8;
            this.lblMetodoPago.Text = "Método de pago";
            // 
            // comboMetodoPago
            // 
            this.comboMetodoPago.FormattingEnabled = true;
            this.comboMetodoPago.Items.AddRange(new object[] {
            "Visa",
            "Paypal",
            "Efectivo",
            "Cheque",
            "Apple Pay",
            "Google Pay",
            "MasterCard",
            "Sinpe Movil",
            "Transferencia",
            "Orden de dinero",
            "American Express"});
            this.comboMetodoPago.Location = new System.Drawing.Point(19, 110);
            this.comboMetodoPago.Name = "comboMetodoPago";
            this.comboMetodoPago.Size = new System.Drawing.Size(298, 26);
            this.comboMetodoPago.TabIndex = 9;
            // 
            // comboMedicos
            // 
            this.comboMedicos.FormattingEnabled = true;
            this.comboMedicos.Location = new System.Drawing.Point(19, 49);
            this.comboMedicos.Name = "comboMedicos";
            this.comboMedicos.Size = new System.Drawing.Size(298, 26);
            this.comboMedicos.TabIndex = 64;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Enabled = false;
            this.lblMedico.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedico.Location = new System.Drawing.Point(19, 32);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(47, 14);
            this.lblMedico.TabIndex = 63;
            this.lblMedico.Text = "Médico";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumCita);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.lblCitaId);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(15, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 75);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del paciente";
            // 
            // txtNumCita
            // 
            this.txtNumCita.Enabled = false;
            this.txtNumCita.Location = new System.Drawing.Point(559, 26);
            this.txtNumCita.Name = "txtNumCita";
            this.txtNumCita.Size = new System.Drawing.Size(210, 26);
            this.txtNumCita.TabIndex = 48;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(23, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(143, 14);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "Número de Identificación";
            // 
            // lblCitaId
            // 
            this.lblCitaId.AutoSize = true;
            this.lblCitaId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCitaId.Location = new System.Drawing.Point(462, 32);
            this.lblCitaId.Name = "lblCitaId";
            this.lblCitaId.Size = new System.Drawing.Size(91, 14);
            this.lblCitaId.TabIndex = 21;
            this.lblCitaId.Text = "Número de Cita";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(172, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 26);
            this.txtID.TabIndex = 38;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboMedicos);
            this.groupBox3.Controls.Add(this.lblHora);
            this.groupBox3.Controls.Add(this.lblMedico);
            this.groupBox3.Controls.Add(this.lblFecha);
            this.groupBox3.Controls.Add(this.comboHorasDisponibles);
            this.groupBox3.Controls.Add(this.dateFechaCita);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(838, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 186);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Horario de la cita";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Enabled = false;
            this.lblHora.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(178, 94);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 14);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(19, 94);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 14);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
            // 
            // comboHorasDisponibles
            // 
            this.comboHorasDisponibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHorasDisponibles.Enabled = false;
            this.comboHorasDisponibles.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboHorasDisponibles.FormattingEnabled = true;
            this.comboHorasDisponibles.Location = new System.Drawing.Point(178, 113);
            this.comboHorasDisponibles.Name = "comboHorasDisponibles";
            this.comboHorasDisponibles.Size = new System.Drawing.Size(139, 26);
            this.comboHorasDisponibles.TabIndex = 9;
            this.comboHorasDisponibles.SelectedIndexChanged += new System.EventHandler(this.comboHorasDisponibles_Click);
            // 
            // dgrListarCitas
            // 
            this.dgrListarCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrListarCitas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrListarCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrListarCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citasid,
            this.horarioid,
            this.pagoid,
            this.estado,
            this.motivo,
            this.observaciones,
            this.metodo_pago});
            this.dgrListarCitas.Location = new System.Drawing.Point(12, 419);
            this.dgrListarCitas.Name = "dgrListarCitas";
            this.dgrListarCitas.RowHeadersVisible = false;
            this.dgrListarCitas.RowTemplate.Height = 25;
            this.dgrListarCitas.Size = new System.Drawing.Size(1160, 279);
            this.dgrListarCitas.TabIndex = 60;
            // 
            // citasid
            // 
            this.citasid.DataPropertyName = "CitasId";
            this.citasid.HeaderText = "CITAS_ID";
            this.citasid.Name = "citasid";
            // 
            // horarioid
            // 
            this.horarioid.DataPropertyName = "HorarioId";
            this.horarioid.HeaderText = "HORARIO_ID";
            this.horarioid.Name = "horarioid";
            // 
            // pagoid
            // 
            this.pagoid.DataPropertyName = "PagoId";
            this.pagoid.HeaderText = "PAGO_ID";
            this.pagoid.Name = "pagoid";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "Estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            // 
            // motivo
            // 
            this.motivo.DataPropertyName = "Motivo";
            this.motivo.HeaderText = "MOTIVO";
            this.motivo.Name = "motivo";
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "Observaciones";
            this.observaciones.HeaderText = "OBSERVACIONES";
            this.observaciones.Name = "observaciones";
            // 
            // metodo_pago
            // 
            this.metodo_pago.DataPropertyName = "Metodo_Pago";
            this.metodo_pago.HeaderText = "METODO_PAGO";
            this.metodo_pago.Name = "metodo_pago";
            // 
            // Frm_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 794);
            this.Controls.Add(this.dgrListarCitas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Frm_Citas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrListarCitas)).EndInit();
            this.ResumeLayout(false);

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