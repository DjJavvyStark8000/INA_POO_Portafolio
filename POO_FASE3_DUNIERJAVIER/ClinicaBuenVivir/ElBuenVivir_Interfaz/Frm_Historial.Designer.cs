namespace ElBuenVivir_Interfaz
{
    partial class Frm_Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Historial));
            txtIdEspecialidad = new System.Windows.Forms.TextBox();
            lblIdEspecialidad = new System.Windows.Forms.Label();
            lblAntecedentes = new System.Windows.Forms.Label();
            txtAntecedentes = new System.Windows.Forms.TextBox();
            txtHistorialID = new System.Windows.Forms.TextBox();
            lblHistorialId = new System.Windows.Forms.Label();
            lblFechaRegistro = new System.Windows.Forms.Label();
            txtObservaciones = new System.Windows.Forms.TextBox();
            lblObservaciones = new System.Windows.Forms.Label();
            txtResultadoPruebas = new System.Windows.Forms.TextBox();
            lblResultadoPruebas = new System.Windows.Forms.Label();
            txtDiagnostico = new System.Windows.Forms.TextBox();
            lblDiagnostico = new System.Windows.Forms.Label();
            groupHistorial = new System.Windows.Forms.GroupBox();
            btnReceta = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtFechaRegistro = new System.Windows.Forms.TextBox();
            txtIdPaciente = new System.Windows.Forms.TextBox();
            lblPacienteId = new System.Windows.Forms.Label();
            txtNombrePaciente = new System.Windows.Forms.TextBox();
            lblPaciente = new System.Windows.Forms.Label();
            dgrHistorial = new System.Windows.Forms.DataGridView();
            historial_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fecha_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            antecedentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            medicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            diagnosticos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEditarHistorial = new System.Windows.Forms.Button();
            txtListaMedicamentos = new System.Windows.Forms.TextBox();
            groupHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrHistorial).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtIdEspecialidad
            // 
            txtIdEspecialidad.Enabled = false;
            txtIdEspecialidad.Location = new System.Drawing.Point(232, -23);
            txtIdEspecialidad.Name = "txtIdEspecialidad";
            txtIdEspecialidad.Size = new System.Drawing.Size(242, 23);
            txtIdEspecialidad.TabIndex = 47;
            // 
            // lblIdEspecialidad
            // 
            lblIdEspecialidad.AutoSize = true;
            lblIdEspecialidad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIdEspecialidad.Location = new System.Drawing.Point(232, -41);
            lblIdEspecialidad.Name = "lblIdEspecialidad";
            lblIdEspecialidad.Size = new System.Drawing.Size(19, 14);
            lblIdEspecialidad.TabIndex = 46;
            lblIdEspecialidad.Text = "ID";
            // 
            // lblAntecedentes
            // 
            lblAntecedentes.AutoSize = true;
            lblAntecedentes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAntecedentes.Location = new System.Drawing.Point(18, 209);
            lblAntecedentes.Name = "lblAntecedentes";
            lblAntecedentes.Size = new System.Drawing.Size(82, 14);
            lblAntecedentes.TabIndex = 36;
            lblAntecedentes.Text = "Antecedentes";
            // 
            // txtAntecedentes
            // 
            txtAntecedentes.Location = new System.Drawing.Point(18, 227);
            txtAntecedentes.Multiline = true;
            txtAntecedentes.Name = "txtAntecedentes";
            txtAntecedentes.Size = new System.Drawing.Size(242, 74);
            txtAntecedentes.TabIndex = 37;
            // 
            // txtHistorialID
            // 
            txtHistorialID.Enabled = false;
            txtHistorialID.Location = new System.Drawing.Point(18, 117);
            txtHistorialID.Name = "txtHistorialID";
            txtHistorialID.Size = new System.Drawing.Size(242, 23);
            txtHistorialID.TabIndex = 35;
            // 
            // lblHistorialId
            // 
            lblHistorialId.AutoSize = true;
            lblHistorialId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblHistorialId.Location = new System.Drawing.Point(18, 99);
            lblHistorialId.Name = "lblHistorialId";
            lblHistorialId.Size = new System.Drawing.Size(73, 14);
            lblHistorialId.TabIndex = 34;
            lblHistorialId.Text = "Historial_ID";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFechaRegistro.Location = new System.Drawing.Point(18, 152);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new System.Drawing.Size(104, 14);
            lblFechaRegistro.TabIndex = 49;
            lblFechaRegistro.Text = "Fecha de Registro";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new System.Drawing.Point(591, 225);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new System.Drawing.Size(242, 74);
            txtObservaciones.TabIndex = 56;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblObservaciones.Location = new System.Drawing.Point(591, 207);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new System.Drawing.Size(87, 14);
            lblObservaciones.TabIndex = 55;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtResultadoPruebas
            // 
            txtResultadoPruebas.Location = new System.Drawing.Point(304, 117);
            txtResultadoPruebas.Multiline = true;
            txtResultadoPruebas.Name = "txtResultadoPruebas";
            txtResultadoPruebas.Size = new System.Drawing.Size(242, 74);
            txtResultadoPruebas.TabIndex = 54;
            // 
            // lblResultadoPruebas
            // 
            lblResultadoPruebas.AutoSize = true;
            lblResultadoPruebas.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblResultadoPruebas.Location = new System.Drawing.Point(304, 99);
            lblResultadoPruebas.Name = "lblResultadoPruebas";
            lblResultadoPruebas.Size = new System.Drawing.Size(146, 14);
            lblResultadoPruebas.TabIndex = 53;
            lblResultadoPruebas.Text = "Resultado de Laboratorio";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new System.Drawing.Point(304, 227);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new System.Drawing.Size(242, 74);
            txtDiagnostico.TabIndex = 58;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDiagnostico.Location = new System.Drawing.Point(304, 209);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new System.Drawing.Size(77, 14);
            lblDiagnostico.TabIndex = 57;
            lblDiagnostico.Text = "*Diagnóstico";
            // 
            // groupHistorial
            // 
            groupHistorial.Controls.Add(txtListaMedicamentos);
            groupHistorial.Controls.Add(btnReceta);
            groupHistorial.Controls.Add(label1);
            groupHistorial.Controls.Add(txtFechaRegistro);
            groupHistorial.Controls.Add(txtIdPaciente);
            groupHistorial.Controls.Add(lblPacienteId);
            groupHistorial.Controls.Add(txtNombrePaciente);
            groupHistorial.Controls.Add(lblPaciente);
            groupHistorial.Controls.Add(txtDiagnostico);
            groupHistorial.Controls.Add(lblHistorialId);
            groupHistorial.Controls.Add(lblDiagnostico);
            groupHistorial.Controls.Add(lblAntecedentes);
            groupHistorial.Controls.Add(txtObservaciones);
            groupHistorial.Controls.Add(txtAntecedentes);
            groupHistorial.Controls.Add(lblObservaciones);
            groupHistorial.Controls.Add(txtHistorialID);
            groupHistorial.Controls.Add(txtResultadoPruebas);
            groupHistorial.Controls.Add(lblResultadoPruebas);
            groupHistorial.Controls.Add(lblFechaRegistro);
            groupHistorial.Location = new System.Drawing.Point(12, 12);
            groupHistorial.Name = "groupHistorial";
            groupHistorial.Size = new System.Drawing.Size(850, 359);
            groupHistorial.TabIndex = 59;
            groupHistorial.TabStop = false;
            groupHistorial.Text = "Datos del Historial";
            // 
            // btnReceta
            // 
            btnReceta.Image = (System.Drawing.Image)resources.GetObject("btnReceta.Image");
            btnReceta.Location = new System.Drawing.Point(591, 50);
            btnReceta.Name = "btnReceta";
            btnReceta.Size = new System.Drawing.Size(241, 101);
            btnReceta.TabIndex = 69;
            btnReceta.Text = "CREAR RECETA";
            btnReceta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnReceta.UseVisualStyleBackColor = true;
            btnReceta.Click += btnReceta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 341);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 15);
            label1.TabIndex = 66;
            label1.Text = "*Campos requeridos";
            // 
            // txtFechaRegistro
            // 
            txtFechaRegistro.Enabled = false;
            txtFechaRegistro.Location = new System.Drawing.Point(18, 169);
            txtFechaRegistro.Name = "txtFechaRegistro";
            txtFechaRegistro.Size = new System.Drawing.Size(242, 23);
            txtFechaRegistro.TabIndex = 64;
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Enabled = false;
            txtIdPaciente.Location = new System.Drawing.Point(304, 50);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new System.Drawing.Size(242, 23);
            txtIdPaciente.TabIndex = 63;
            // 
            // lblPacienteId
            // 
            lblPacienteId.AutoSize = true;
            lblPacienteId.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPacienteId.Location = new System.Drawing.Point(304, 33);
            lblPacienteId.Name = "lblPacienteId";
            lblPacienteId.Size = new System.Drawing.Size(87, 14);
            lblPacienteId.TabIndex = 62;
            lblPacienteId.Text = "ID de paciente";
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Enabled = false;
            txtNombrePaciente.Location = new System.Drawing.Point(18, 50);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new System.Drawing.Size(242, 23);
            txtNombrePaciente.TabIndex = 61;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPaciente.Location = new System.Drawing.Point(18, 33);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new System.Drawing.Size(54, 14);
            lblPaciente.TabIndex = 60;
            lblPaciente.Text = "Paciente";
            // 
            // dgrHistorial
            // 
            dgrHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgrHistorial.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgrHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { historial_id, fecha_registro, antecedentes, medicamentos, diagnosticos, laboratorio, observaciones });
            dgrHistorial.Location = new System.Drawing.Point(17, 22);
            dgrHistorial.Name = "dgrHistorial";
            dgrHistorial.RowHeadersVisible = false;
            dgrHistorial.RowTemplate.Height = 25;
            dgrHistorial.Size = new System.Drawing.Size(815, 269);
            dgrHistorial.TabIndex = 60;
            // 
            // historial_id
            // 
            historial_id.DataPropertyName = "HistorialId";
            historial_id.HeaderText = "ID_HISTORIAL";
            historial_id.Name = "historial_id";
            // 
            // fecha_registro
            // 
            fecha_registro.DataPropertyName = "FechaRegistro";
            fecha_registro.HeaderText = "FECHA_REG";
            fecha_registro.Name = "fecha_registro";
            // 
            // antecedentes
            // 
            antecedentes.DataPropertyName = "Antecedentes";
            antecedentes.HeaderText = "ANTECEDENTES";
            antecedentes.Name = "antecedentes";
            // 
            // medicamentos
            // 
            medicamentos.DataPropertyName = "Medicamentos";
            medicamentos.HeaderText = "MEDICAMENTOS";
            medicamentos.Name = "medicamentos";
            // 
            // diagnosticos
            // 
            diagnosticos.DataPropertyName = "Diagnosticos";
            diagnosticos.HeaderText = "DIAGNÓSTICOS";
            diagnosticos.Name = "diagnosticos";
            // 
            // laboratorio
            // 
            laboratorio.DataPropertyName = "ResultadoPruebas";
            laboratorio.HeaderText = "LABORATORIO";
            laboratorio.Name = "laboratorio";
            // 
            // observaciones
            // 
            observaciones.DataPropertyName = "Observaciones";
            observaciones.HeaderText = "OBSERVACIONES";
            observaciones.Name = "observaciones";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgrHistorial);
            groupBox1.Location = new System.Drawing.Point(12, 390);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(850, 308);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listar el Historial";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(742, 704);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(120, 61);
            btnGuardar.TabIndex = 67;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.Location = new System.Drawing.Point(12, 704);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(159, 61);
            btnSalir.TabIndex = 65;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEditarHistorial
            // 
            btnEditarHistorial.Location = new System.Drawing.Point(616, 704);
            btnEditarHistorial.Name = "btnEditarHistorial";
            btnEditarHistorial.Size = new System.Drawing.Size(120, 61);
            btnEditarHistorial.TabIndex = 64;
            btnEditarHistorial.Text = "EDITAR";
            btnEditarHistorial.UseVisualStyleBackColor = true;
            btnEditarHistorial.Click += btnEditarHistorial_Click;
            // 
            // txtListaMedicamentos
            // 
            txtListaMedicamentos.Location = new System.Drawing.Point(322, 307);
            txtListaMedicamentos.Multiline = true;
            txtListaMedicamentos.Name = "txtListaMedicamentos";
            txtListaMedicamentos.Size = new System.Drawing.Size(242, 69);
            txtListaMedicamentos.TabIndex = 71;
            // 
            // Frm_Historial
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(876, 777);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalir);
            Controls.Add(btnEditarHistorial);
            Controls.Add(txtIdEspecialidad);
            Controls.Add(lblIdEspecialidad);
            Controls.Add(groupHistorial);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Historial";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Historial Médico";
            Load += Frm_Historial_Load;
            groupHistorial.ResumeLayout(false);
            groupHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrHistorial).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtIdEspecialidad;
        private System.Windows.Forms.Label lblIdEspecialidad;
        private System.Windows.Forms.Label lblAntecedentes;
        private System.Windows.Forms.TextBox txtAntecedentes;
        private System.Windows.Forms.TextBox txtHistorialID;
        private System.Windows.Forms.Label lblHistorialId;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtResultadoPruebas;
        private System.Windows.Forms.Label lblResultadoPruebas;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.GroupBox groupHistorial;
        private System.Windows.Forms.DataGridView dgrHistorial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditarHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn historial_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn antecedentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticos;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label lblPacienteId;
        private System.Windows.Forms.TextBox txtFechaRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceta;
        private System.Windows.Forms.TextBox txtListaMedicamentos;
    }
}