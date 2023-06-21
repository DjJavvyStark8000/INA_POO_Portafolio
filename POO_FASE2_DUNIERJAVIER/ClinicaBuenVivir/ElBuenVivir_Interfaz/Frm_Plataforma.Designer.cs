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
            dgrVerPaciente = new System.Windows.Forms.DataGridView();
            clmIdpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmNombrepaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmAsegurado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel4 = new System.Windows.Forms.Panel();
            button8 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            btnAgregarPaciente = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            btnHistorial = new System.Windows.Forms.Button();
            btnRecetas = new System.Windows.Forms.Button();
            btnAgendarCita = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrVerPaciente).BeginInit();
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
            panel1.Paint += panel1_Paint;
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
            panel3.Controls.Add(dgrVerPaciente);
            panel3.Location = new System.Drawing.Point(135, 168);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1048, 422);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // dgrVerPaciente
            // 
            dgrVerPaciente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dgrVerPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrVerPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { clmIdpaciente, clmNombrepaciente, clmApellidos, clmFechaNacimiento, clmTelefono, clmAsegurado });
            dgrVerPaciente.Location = new System.Drawing.Point(13, 17);
            dgrVerPaciente.Name = "dgrVerPaciente";
            dgrVerPaciente.RowTemplate.Height = 25;
            dgrVerPaciente.Size = new System.Drawing.Size(1013, 389);
            dgrVerPaciente.TabIndex = 0;
            // 
            // clmIdpaciente
            // 
            clmIdpaciente.DataPropertyName = "PACIENTES_ID";
            clmIdpaciente.HeaderText = "ID";
            clmIdpaciente.Name = "clmIdpaciente";
            // 
            // clmNombrepaciente
            // 
            clmNombrepaciente.DataPropertyName = "NOMBRE_PACIENTE";
            clmNombrepaciente.HeaderText = "NOMBRE";
            clmNombrepaciente.Name = "clmNombrepaciente";
            // 
            // clmApellidos
            // 
            clmApellidos.DataPropertyName = "APELLIDOS";
            clmApellidos.HeaderText = "APELLIDOS";
            clmApellidos.Name = "clmApellidos";
            clmApellidos.Width = 300;
            // 
            // clmFechaNacimiento
            // 
            clmFechaNacimiento.DataPropertyName = "FECHA_NACIMIENTO";
            clmFechaNacimiento.HeaderText = "NACIMIENTO";
            clmFechaNacimiento.Name = "clmFechaNacimiento";
            // 
            // clmTelefono
            // 
            clmTelefono.DataPropertyName = "TELEFONO";
            clmTelefono.HeaderText = "TELÉFONO";
            clmTelefono.Name = "clmTelefono";
            // 
            // clmAsegurado
            // 
            clmAsegurado.DataPropertyName = "ASEGURADO";
            clmAsegurado.HeaderText = "ASEGURADO";
            clmAsegurado.Name = "clmAsegurado";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel4.Location = new System.Drawing.Point(825, 15);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(358, 345);
            panel4.TabIndex = 5;
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button8.Enabled = false;
            button8.Image = (System.Drawing.Image)resources.GetObject("button8.Image");
            button8.Location = new System.Drawing.Point(365, 13);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(224, 148);
            button8.TabIndex = 8;
            button8.Text = "REGISTRAR PACIENTE";
            button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = false;
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
            // button12
            // 
            button12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button12.Enabled = false;
            button12.Image = (System.Drawing.Image)resources.GetObject("button12.Image");
            button12.Location = new System.Drawing.Point(173, 16);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(146, 147);
            button12.TabIndex = 2;
            button12.Text = "SISTEMA";
            button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button12.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button14.Enabled = false;
            button14.Image = (System.Drawing.Image)resources.GetObject("button14.Image");
            button14.Location = new System.Drawing.Point(325, 16);
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
            panel2.Controls.Add(btnHistorial);
            panel2.Controls.Add(btnRecetas);
            panel2.Controls.Add(btnAgregarPaciente);
            panel2.Controls.Add(button14);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button11);
            panel2.Location = new System.Drawing.Point(135, 596);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1048, 183);
            panel2.TabIndex = 3;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnHistorial.Enabled = false;
            btnHistorial.Image = (System.Drawing.Image)resources.GetObject("btnHistorial.Image");
            btnHistorial.Location = new System.Drawing.Point(477, 16);
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
            btnRecetas.Location = new System.Drawing.Point(629, 16);
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
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button3.Enabled = false;
            button3.Image = (System.Drawing.Image)resources.GetObject("button3.Image");
            button3.Location = new System.Drawing.Point(595, 12);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(224, 148);
            button3.TabIndex = 10;
            button3.Text = "BUSCAR PACIENTE";
            button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // Frm_Plataforma
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1195, 821);
            Controls.Add(button3);
            Controls.Add(btnAgendarCita);
            Controls.Add(button8);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Plataforma";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Clínica El Buen Vivir";
            Load += Frm_Principal_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrVerPaciente).EndInit();
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgendarCita;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.DataGridView dgrVerPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombrepaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAsegurado;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btn_Horarios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHistorial;
    }
}
