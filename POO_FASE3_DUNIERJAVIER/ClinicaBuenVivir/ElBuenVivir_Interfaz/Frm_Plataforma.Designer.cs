namespace ElBuenVivir_Interfaz
{
    partial class Frm_Plataforma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Plataforma));
            panel1 = new System.Windows.Forms.Panel();
            btn_Horarios = new System.Windows.Forms.Button();
            btnInventario = new System.Windows.Forms.Button();
            btnEspecialidades = new System.Windows.Forms.Button();
            btnFuncionario = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            dgrVerPacientes = new System.Windows.Forms.DataGridView();
            clmcedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmapellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmtelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmemergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            btnBuscarId = new System.Windows.Forms.Button();
            lblIngresoId = new System.Windows.Forms.Label();
            txtPacienteID = new System.Windows.Forms.TextBox();
            button11 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            btnAgregarPaciente = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            btnGuardarRegistro = new System.Windows.Forms.Button();
            btnHistorial = new System.Windows.Forms.Button();
            btnRecetas = new System.Windows.Forms.Button();
            btnAgendarCita = new System.Windows.Forms.Button();
            btnBuscarPaciente = new System.Windows.Forms.Button();
            btnRegistrarPaciente = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrVerPacientes).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Horarios);
            panel1.Controls.Add(btnInventario);
            panel1.Controls.Add(btnEspecialidades);
            panel1.Controls.Add(btnFuncionario);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(117, 767);
            panel1.TabIndex = 2;
            // 
            // btn_Horarios
            // 
            btn_Horarios.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btn_Horarios.Enabled = false;
            btn_Horarios.Image = (System.Drawing.Image)resources.GetObject("btn_Horarios.Image");
            btn_Horarios.Location = new System.Drawing.Point(6, 443);
            btn_Horarios.Name = "btn_Horarios";
            btn_Horarios.Size = new System.Drawing.Size(108, 104);
            btn_Horarios.TabIndex = 6;
            btn_Horarios.Text = "HORARIOS";
            btn_Horarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_Horarios.UseVisualStyleBackColor = false;
            btn_Horarios.Click += btn_Horarios_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnInventario.Image = (System.Drawing.Image)resources.GetObject("btnInventario.Image");
            btnInventario.Location = new System.Drawing.Point(6, 553);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new System.Drawing.Size(108, 104);
            btnInventario.TabIndex = 6;
            btnInventario.Text = "INVENTARIO";
            btnInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnEspecialidades
            // 
            btnEspecialidades.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnEspecialidades.Image = (System.Drawing.Image)resources.GetObject("btnEspecialidades.Image");
            btnEspecialidades.Location = new System.Drawing.Point(6, 663);
            btnEspecialidades.Name = "btnEspecialidades";
            btnEspecialidades.Size = new System.Drawing.Size(108, 104);
            btnEspecialidades.TabIndex = 1;
            btnEspecialidades.Text = "ESPECIALIDADES";
            btnEspecialidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEspecialidades.UseVisualStyleBackColor = false;
            btnEspecialidades.Click += btnEspecialidades_Click;
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnFuncionario.Image = (System.Drawing.Image)resources.GetObject("btnFuncionario.Image");
            btnFuncionario.Location = new System.Drawing.Point(6, 223);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new System.Drawing.Size(108, 104);
            btnFuncionario.TabIndex = 3;
            btnFuncionario.Text = "FUNCIONARIOS";
            btnFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button4.Enabled = false;
            button4.Image = (System.Drawing.Image)resources.GetObject("button4.Image");
            button4.Location = new System.Drawing.Point(6, 333);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(108, 104);
            button4.TabIndex = 3;
            button4.Text = "MEDICOS";
            button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button2.Enabled = false;
            button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
            button2.Location = new System.Drawing.Point(6, 113);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(108, 104);
            button2.TabIndex = 1;
            button2.Text = "ADMIN";
            button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button1.Enabled = false;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.Location = new System.Drawing.Point(6, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(108, 104);
            button1.TabIndex = 0;
            button1.Text = "INICIO";
            button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel3.Controls.Add(dgrVerPacientes);
            panel3.Controls.Add(label1);
            panel3.Location = new System.Drawing.Point(135, 168);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1048, 422);
            panel3.TabIndex = 4;
            // 
            // dgrVerPacientes
            // 
            dgrVerPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgrVerPacientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgrVerPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrVerPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { clmcedula, clmnombre, clmapellidos, clmtelefono, clmemergencia });
            dgrVerPacientes.Location = new System.Drawing.Point(13, 30);
            dgrVerPacientes.Name = "dgrVerPacientes";
            dgrVerPacientes.RowHeadersVisible = false;
            dgrVerPacientes.RowTemplate.Height = 25;
            dgrVerPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgrVerPacientes.Size = new System.Drawing.Size(1022, 374);
            dgrVerPacientes.TabIndex = 2;
            dgrVerPacientes.Click += dgrVerPacientes_Click;
            // 
            // clmcedula
            // 
            clmcedula.DataPropertyName = "Identificacion";
            clmcedula.HeaderText = "IDENTIFICACIÓN";
            clmcedula.Name = "clmcedula";
            // 
            // clmnombre
            // 
            clmnombre.DataPropertyName = "Nombre";
            clmnombre.HeaderText = "NOMBRE";
            clmnombre.Name = "clmnombre";
            // 
            // clmapellidos
            // 
            clmapellidos.DataPropertyName = "Apellidos";
            clmapellidos.HeaderText = "APELLIDOS";
            clmapellidos.Name = "clmapellidos";
            // 
            // clmtelefono
            // 
            clmtelefono.DataPropertyName = "Telefono";
            clmtelefono.HeaderText = "TELÉFONO";
            clmtelefono.Name = "clmtelefono";
            // 
            // clmemergencia
            // 
            clmemergencia.DataPropertyName = "NumeroEmergencia";
            clmemergencia.HeaderText = "EMERGENCIA";
            clmemergencia.Name = "clmemergencia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(175, 15);
            label1.TabIndex = 1;
            label1.Text = "Información Básica del Paciente";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel4.Controls.Add(btnBuscarId);
            panel4.Controls.Add(lblIngresoId);
            panel4.Controls.Add(txtPacienteID);
            panel4.Location = new System.Drawing.Point(825, 15);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(358, 345);
            panel4.TabIndex = 5;
            // 
            // btnBuscarId
            // 
            btnBuscarId.Location = new System.Drawing.Point(113, 92);
            btnBuscarId.Name = "btnBuscarId";
            btnBuscarId.Size = new System.Drawing.Size(129, 40);
            btnBuscarId.TabIndex = 2;
            btnBuscarId.Text = "BUSCAR";
            btnBuscarId.UseVisualStyleBackColor = true;
            btnBuscarId.Visible = false;
            btnBuscarId.Click += btnBuscarId_Click;
            // 
            // lblIngresoId
            // 
            lblIngresoId.AutoSize = true;
            lblIngresoId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIngresoId.Location = new System.Drawing.Point(59, 29);
            lblIngresoId.Name = "lblIngresoId";
            lblIngresoId.Size = new System.Drawing.Size(243, 20);
            lblIngresoId.TabIndex = 1;
            lblIngresoId.Text = "Ingrese el número de identificación";
            lblIngresoId.Visible = false;
            // 
            // txtPacienteID
            // 
            txtPacienteID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPacienteID.Location = new System.Drawing.Point(22, 53);
            txtPacienteID.Name = "txtPacienteID";
            txtPacienteID.Size = new System.Drawing.Size(314, 33);
            txtPacienteID.TabIndex = 0;
            txtPacienteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtPacienteID.Visible = false;
            txtPacienteID.TextChanged += txtIngresarId_TextChanged;
            // 
            // button11
            // 
            button11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button11.Image = (System.Drawing.Image)resources.GetObject("button11.Image");
            button11.Location = new System.Drawing.Point(21, 17);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(146, 147);
            button11.TabIndex = 1;
            button11.Text = "SALIR";
            button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button11.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button14.Enabled = false;
            button14.Image = (System.Drawing.Image)resources.GetObject("button14.Image");
            button14.Location = new System.Drawing.Point(173, 17);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(146, 147);
            button14.TabIndex = 3;
            button14.Text = "BITACORA";
            button14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button14.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnAgregarPaciente.Image = (System.Drawing.Image)resources.GetObject("btnAgregarPaciente.Image");
            btnAgregarPaciente.Location = new System.Drawing.Point(841, 16);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new System.Drawing.Size(185, 147);
            btnAgregarPaciente.TabIndex = 6;
            btnAgregarPaciente.Text = "NUEVO PACIENTE";
            btnAgregarPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAgregarPaciente.UseVisualStyleBackColor = false;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel2.Controls.Add(btnGuardarRegistro);
            panel2.Controls.Add(btnHistorial);
            panel2.Controls.Add(btnRecetas);
            panel2.Controls.Add(btnAgregarPaciente);
            panel2.Controls.Add(button14);
            panel2.Controls.Add(button11);
            panel2.Location = new System.Drawing.Point(135, 596);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1048, 183);
            panel2.TabIndex = 3;
            // 
            // btnGuardarRegistro
            // 
            btnGuardarRegistro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnGuardarRegistro.Image = (System.Drawing.Image)resources.GetObject("btnGuardarRegistro.Image");
            btnGuardarRegistro.Location = new System.Drawing.Point(629, 17);
            btnGuardarRegistro.Name = "btnGuardarRegistro";
            btnGuardarRegistro.Size = new System.Drawing.Size(146, 147);
            btnGuardarRegistro.TabIndex = 7;
            btnGuardarRegistro.Text = "GUARDAR";
            btnGuardarRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGuardarRegistro.UseVisualStyleBackColor = false;
            btnGuardarRegistro.Click += btnGuardarRegistro_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnHistorial.Image = (System.Drawing.Image)resources.GetObject("btnHistorial.Image");
            btnHistorial.Location = new System.Drawing.Point(325, 17);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new System.Drawing.Size(146, 147);
            btnHistorial.TabIndex = 6;
            btnHistorial.Text = "HISTORIAL";
            btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnRecetas
            // 
            btnRecetas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnRecetas.Image = (System.Drawing.Image)resources.GetObject("btnRecetas.Image");
            btnRecetas.Location = new System.Drawing.Point(477, 17);
            btnRecetas.Name = "btnRecetas";
            btnRecetas.Size = new System.Drawing.Size(146, 147);
            btnRecetas.TabIndex = 5;
            btnRecetas.Text = "CCSS";
            btnRecetas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnRecetas.UseVisualStyleBackColor = false;
            btnRecetas.Click += btnRecetas_Click;
            // 
            // btnAgendarCita
            // 
            btnAgendarCita.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnAgendarCita.Enabled = false;
            btnAgendarCita.Image = (System.Drawing.Image)resources.GetObject("btnAgendarCita.Image");
            btnAgendarCita.Location = new System.Drawing.Point(135, 13);
            btnAgendarCita.Name = "btnAgendarCita";
            btnAgendarCita.Size = new System.Drawing.Size(224, 148);
            btnAgendarCita.TabIndex = 10;
            btnAgendarCita.Text = "Agendar Cita";
            btnAgendarCita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAgendarCita.UseVisualStyleBackColor = false;
            btnAgendarCita.Click += btnAgendarCita_Click;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnBuscarPaciente.Image = (System.Drawing.Image)resources.GetObject("btnBuscarPaciente.Image");
            btnBuscarPaciente.Location = new System.Drawing.Point(595, 13);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new System.Drawing.Size(224, 148);
            btnBuscarPaciente.TabIndex = 11;
            btnBuscarPaciente.Text = "BUSCAR PACIENTE";
            btnBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;
            // 
            // btnRegistrarPaciente
            // 
            btnRegistrarPaciente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnRegistrarPaciente.Enabled = false;
            btnRegistrarPaciente.Image = (System.Drawing.Image)resources.GetObject("btnRegistrarPaciente.Image");
            btnRegistrarPaciente.Location = new System.Drawing.Point(365, 13);
            btnRegistrarPaciente.Name = "btnRegistrarPaciente";
            btnRegistrarPaciente.Size = new System.Drawing.Size(224, 148);
            btnRegistrarPaciente.TabIndex = 9;
            btnRegistrarPaciente.Text = "REGISTRAR PACIENTE";
            btnRegistrarPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnRegistrarPaciente.UseVisualStyleBackColor = false;
            btnRegistrarPaciente.Click += btnRegistrarPaciente_Click;
            // 
            // Frm_Plataforma
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1195, 821);
            Controls.Add(btnRegistrarPaciente);
            Controls.Add(btnBuscarPaciente);
            Controls.Add(btnAgendarCita);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Plataforma";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clínica El Buen Vivir | Plataforma";
            Load += Frm_Principal_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrVerPacientes).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btn_Horarios;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.DataGridView dgrVerPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmapellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmtelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmemergencia;
        private System.Windows.Forms.Label lblIngresoId;
        private System.Windows.Forms.TextBox txtPacienteID;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.Button btnRegistrarPaciente;
        private System.Windows.Forms.Button btnGuardarRegistro;
    }
}
