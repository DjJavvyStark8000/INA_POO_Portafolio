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
            dgrHorasDisponibles = new System.Windows.Forms.DataGridView();
            horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dateFechaCita = new System.Windows.Forms.DateTimePicker();
            dgrListarCitas = new System.Windows.Forms.DataGridView();
            cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fechaentrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            horaentrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            horasalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            citaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscarEspecial = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEditarEspecialidad = new System.Windows.Forms.Button();
            btnEliminarEspecialidad = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            comboMedicos = new System.Windows.Forms.ComboBox();
            lblMedico = new System.Windows.Forms.Label();
            comboEstado = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            txtObservaciones = new System.Windows.Forms.TextBox();
            lblObservaciones = new System.Windows.Forms.Label();
            txtMotivo = new System.Windows.Forms.TextBox();
            lblMotivo = new System.Windows.Forms.Label();
            txtNombreCompleto = new System.Windows.Forms.TextBox();
            lblNombreCompleto = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            checkPagoSi = new System.Windows.Forms.CheckBox();
            checkPagoNo = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            comboMetodoPago = new System.Windows.Forms.ComboBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            textBox1 = new System.Windows.Forms.TextBox();
            lblID = new System.Windows.Forms.Label();
            lblCitaId = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgrHorasDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrListarCitas).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgrHorasDisponibles
            // 
            dgrHorasDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgrHorasDisponibles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgrHorasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrHorasDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { horas, estado });
            dgrHorasDisponibles.Location = new System.Drawing.Point(22, 68);
            dgrHorasDisponibles.Name = "dgrHorasDisponibles";
            dgrHorasDisponibles.RowTemplate.Height = 25;
            dgrHorasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgrHorasDisponibles.Size = new System.Drawing.Size(294, 601);
            dgrHorasDisponibles.TabIndex = 1;
            dgrHorasDisponibles.CellFormatting += dgrHorasDisponibles_CellFormatting;
            dgrHorasDisponibles.Click += dgrHorasDisponibles_Click;
            // 
            // horas
            // 
            horas.DataPropertyName = "Horas";
            horas.HeaderText = "HORAS";
            horas.Name = "horas";
            // 
            // estado
            // 
            estado.DataPropertyName = "Estado";
            estado.HeaderText = "ESTADO";
            estado.Name = "estado";
            // 
            // dateFechaCita
            // 
            dateFechaCita.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateFechaCita.Location = new System.Drawing.Point(22, 26);
            dateFechaCita.Name = "dateFechaCita";
            dateFechaCita.Size = new System.Drawing.Size(294, 26);
            dateFechaCita.TabIndex = 2;
            dateFechaCita.ValueChanged += dateFechaCita_ValueChanged;
            // 
            // dgrListarCitas
            // 
            dgrListarCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgrListarCitas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgrListarCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrListarCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { cedula, paciente, fechaentrada, horaentrada, horasalida, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, motivo, citaid, dataGridViewTextBoxColumn3, observaciones });
            dgrListarCitas.Enabled = false;
            dgrListarCitas.Location = new System.Drawing.Point(15, 419);
            dgrListarCitas.Name = "dgrListarCitas";
            dgrListarCitas.RowTemplate.Height = 25;
            dgrListarCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgrListarCitas.Size = new System.Drawing.Size(785, 278);
            dgrListarCitas.TabIndex = 58;
            // 
            // cedula
            // 
            cedula.HeaderText = "CEDULA";
            cedula.Name = "cedula";
            // 
            // paciente
            // 
            paciente.HeaderText = "NOMBRE";
            paciente.Name = "paciente";
            // 
            // fechaentrada
            // 
            fechaentrada.DataPropertyName = "Fecha";
            fechaentrada.HeaderText = "FECHA";
            fechaentrada.Name = "fechaentrada";
            // 
            // horaentrada
            // 
            horaentrada.DataPropertyName = "HoraInicio";
            horaentrada.HeaderText = "HORA_INI";
            horaentrada.Name = "horaentrada";
            // 
            // horasalida
            // 
            horasalida.DataPropertyName = "HoraFin";
            horasalida.HeaderText = "HORA_SAL";
            horasalida.Name = "horasalida";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Estado";
            dataGridViewTextBoxColumn1.HeaderText = "ESTADO";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Medico";
            dataGridViewTextBoxColumn2.HeaderText = "MÉDICO";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // motivo
            // 
            motivo.DataPropertyName = "Motivo";
            motivo.HeaderText = "MOTIVO";
            motivo.Name = "motivo";
            // 
            // citaid
            // 
            citaid.DataPropertyName = "CitasId";
            citaid.HeaderText = "CITA_ID";
            citaid.Name = "citaid";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "HorarioId";
            dataGridViewTextBoxColumn3.HeaderText = "HORARIO_ID";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // observaciones
            // 
            observaciones.DataPropertyName = "Observaciones";
            observaciones.HeaderText = "OBSERVACIONES";
            observaciones.Name = "observaciones";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(1034, 718);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(120, 61);
            btnGuardar.TabIndex = 56;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscarEspecial
            // 
            btnBuscarEspecial.Enabled = false;
            btnBuscarEspecial.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBuscarEspecial.Location = new System.Drawing.Point(528, 718);
            btnBuscarEspecial.Name = "btnBuscarEspecial";
            btnBuscarEspecial.Size = new System.Drawing.Size(120, 61);
            btnBuscarEspecial.TabIndex = 55;
            btnBuscarEspecial.Text = "BUSCAR";
            btnBuscarEspecial.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.Location = new System.Drawing.Point(22, 718);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(242, 61);
            btnSalir.TabIndex = 54;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditarEspecialidad
            // 
            btnEditarEspecialidad.Enabled = false;
            btnEditarEspecialidad.Location = new System.Drawing.Point(780, 718);
            btnEditarEspecialidad.Name = "btnEditarEspecialidad";
            btnEditarEspecialidad.Size = new System.Drawing.Size(120, 61);
            btnEditarEspecialidad.TabIndex = 53;
            btnEditarEspecialidad.Text = "EDITAR";
            btnEditarEspecialidad.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEspecialidad
            // 
            btnEliminarEspecialidad.Enabled = false;
            btnEliminarEspecialidad.Location = new System.Drawing.Point(654, 718);
            btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            btnEliminarEspecialidad.Size = new System.Drawing.Size(120, 61);
            btnEliminarEspecialidad.TabIndex = 52;
            btnEliminarEspecialidad.Text = "ELIMINAR";
            btnEliminarEspecialidad.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Enabled = false;
            btnNuevo.Location = new System.Drawing.Point(908, 718);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(120, 61);
            btnNuevo.TabIndex = 51;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboMedicos);
            groupBox1.Controls.Add(lblMedico);
            groupBox1.Controls.Add(comboEstado);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtObservaciones);
            groupBox1.Controls.Add(lblObservaciones);
            groupBox1.Controls.Add(txtMotivo);
            groupBox1.Controls.Add(lblMotivo);
            groupBox1.Controls.Add(txtNombreCompleto);
            groupBox1.Controls.Add(lblNombreCompleto);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(15, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(785, 309);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del paciente";
            // 
            // comboMedicos
            // 
            comboMedicos.FormattingEnabled = true;
            comboMedicos.Location = new System.Drawing.Point(462, 48);
            comboMedicos.Name = "comboMedicos";
            comboMedicos.Size = new System.Drawing.Size(307, 26);
            comboMedicos.TabIndex = 64;
            comboMedicos.SelectedIndexChanged += comboMedicos_SelectedIndexChanged;
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMedico.Location = new System.Drawing.Point(462, 31);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new System.Drawing.Size(47, 14);
            lblMedico.TabIndex = 63;
            lblMedico.Text = "Médico";
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
            txtObservaciones.Size = new System.Drawing.Size(403, 122);
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
            txtNombreCompleto.Size = new System.Drawing.Size(403, 26);
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
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(checkPagoSi);
            groupBox4.Controls.Add(checkPagoNo);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(comboMetodoPago);
            groupBox4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox4.Location = new System.Drawing.Point(471, 152);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(288, 140);
            groupBox4.TabIndex = 58;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pago servicios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(117, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 14);
            label2.TabIndex = 10;
            label2.Text = "¿Pago?";
            // 
            // checkPagoSi
            // 
            checkPagoSi.AutoSize = true;
            checkPagoSi.Location = new System.Drawing.Point(82, 102);
            checkPagoSi.Name = "checkPagoSi";
            checkPagoSi.Size = new System.Drawing.Size(38, 22);
            checkPagoSi.TabIndex = 6;
            checkPagoSi.Text = "Si";
            checkPagoSi.UseVisualStyleBackColor = true;
            // 
            // checkPagoNo
            // 
            checkPagoNo.AutoSize = true;
            checkPagoNo.Location = new System.Drawing.Point(157, 102);
            checkPagoNo.Name = "checkPagoNo";
            checkPagoNo.Size = new System.Drawing.Size(45, 22);
            checkPagoNo.TabIndex = 7;
            checkPagoNo.Text = "No";
            checkPagoNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(32, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 14);
            label1.TabIndex = 8;
            label1.Text = "Método de pago";
            // 
            // comboMetodoPago
            // 
            comboMetodoPago.FormattingEnabled = true;
            comboMetodoPago.Items.AddRange(new object[] { "Visa", "MasterCard", "American Express", "Efectivo", "Sinpe Movil", "Cheque ", "Orden de dinero", "Google Pay", "Apple Pay", "Paypal", "Transferencia" });
            comboMetodoPago.Location = new System.Drawing.Point(32, 45);
            comboMetodoPago.Name = "comboMetodoPago";
            comboMetodoPago.Size = new System.Drawing.Size(228, 26);
            comboMetodoPago.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
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
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new System.Drawing.Point(513, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(193, 26);
            textBox1.TabIndex = 48;
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
            lblCitaId.Location = new System.Drawing.Point(415, 34);
            lblCitaId.Name = "lblCitaId";
            lblCitaId.Size = new System.Drawing.Size(91, 14);
            lblCitaId.TabIndex = 21;
            lblCitaId.Text = "Número de Cita";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(172, 26);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(193, 26);
            txtID.TabIndex = 38;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateFechaCita);
            groupBox3.Controls.Add(dgrHorasDisponibles);
            groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.Location = new System.Drawing.Point(838, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(334, 688);
            groupBox3.TabIndex = 59;
            groupBox3.TabStop = false;
            groupBox3.Text = "Día y Hora de la cita";
            // 
            // Frm_Citas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1184, 789);
            Controls.Add(dgrListarCitas);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscarEspecial);
            Controls.Add(btnSalir);
            Controls.Add(btnEditarEspecialidad);
            Controls.Add(btnEliminarEspecialidad);
            Controls.Add(btnNuevo);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Citas";
            Text = "Citas";
            Load += Frm_Horarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgrHorasDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrListarCitas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgrHorasDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DateTimePicker dateFechaCita;
        private System.Windows.Forms.DataGridView dgrListarCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaentrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaentrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn citaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarEspecial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditarEspecialidad;
        private System.Windows.Forms.Button btnEliminarEspecialidad;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCitaId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.ComboBox comboMetodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkPagoNo;
        private System.Windows.Forms.CheckBox checkPagoSi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMedicos;
        private System.Windows.Forms.Label lblMedico;
    }
}