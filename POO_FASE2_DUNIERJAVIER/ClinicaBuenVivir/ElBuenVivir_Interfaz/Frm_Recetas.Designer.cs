namespace ElBuenVivir_Interfaz
{
    partial class Frm_Recetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Recetas));
            groupRecetas = new System.Windows.Forms.GroupBox();
            numericCantidad = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            comboMedicamentos = new System.Windows.Forms.ComboBox();
            txtDosis = new System.Windows.Forms.TextBox();
            lblMedicamentos = new System.Windows.Forms.Label();
            txtFechaRetiro = new System.Windows.Forms.TextBox();
            txtNombreReceta = new System.Windows.Forms.TextBox();
            lblReceta = new System.Windows.Forms.Label();
            txtDuracion = new System.Windows.Forms.TextBox();
            lblDuracion = new System.Windows.Forms.Label();
            lblFechasRetiro = new System.Windows.Forms.Label();
            txtIndicaciones = new System.Windows.Forms.TextBox();
            lblIndicaciones = new System.Windows.Forms.Label();
            dgrListarReceta = new System.Windows.Forms.DataGridView();
            recetaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            especialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fechaentrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            proximareceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cantidadrecetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            indicaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnGuardarReceta = new System.Windows.Forms.Button();
            btnBuscarRecetas = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEditarRecetas = new System.Windows.Forms.Button();
            btnEliminarRecetas = new System.Windows.Forms.Button();
            btnNuevaReceta = new System.Windows.Forms.Button();
            txtMedico = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtPaciente = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupPacienteMedico = new System.Windows.Forms.GroupBox();
            numericCantidadRecetas = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            lclProximaReceta = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            txtIdReceta = new System.Windows.Forms.TextBox();
            lblNumeroReceta = new System.Windows.Forms.Label();
            groupRecetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrListarReceta).BeginInit();
            groupBox1.SuspendLayout();
            groupPacienteMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericCantidadRecetas).BeginInit();
            SuspendLayout();
            // 
            // groupRecetas
            // 
            groupRecetas.Controls.Add(dateTimePicker1);
            groupRecetas.Controls.Add(lclProximaReceta);
            groupRecetas.Controls.Add(numericCantidadRecetas);
            groupRecetas.Controls.Add(label4);
            groupRecetas.Controls.Add(numericCantidad);
            groupRecetas.Controls.Add(label3);
            groupRecetas.Controls.Add(comboMedicamentos);
            groupRecetas.Controls.Add(txtDosis);
            groupRecetas.Controls.Add(lblMedicamentos);
            groupRecetas.Controls.Add(txtFechaRetiro);
            groupRecetas.Controls.Add(txtNombreReceta);
            groupRecetas.Controls.Add(lblReceta);
            groupRecetas.Controls.Add(txtDuracion);
            groupRecetas.Controls.Add(lblDuracion);
            groupRecetas.Controls.Add(lblFechasRetiro);
            groupRecetas.Controls.Add(txtIndicaciones);
            groupRecetas.Controls.Add(lblIndicaciones);
            groupRecetas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupRecetas.Location = new System.Drawing.Point(12, 131);
            groupRecetas.Name = "groupRecetas";
            groupRecetas.Size = new System.Drawing.Size(716, 265);
            groupRecetas.TabIndex = 7;
            groupRecetas.TabStop = false;
            groupRecetas.Text = "Receta";
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new System.Drawing.Point(235, 39);
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new System.Drawing.Size(241, 26);
            numericCantidad.TabIndex = 73;
            numericCantidad.ValueChanged += numericCantidad_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(235, 22);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 14);
            label3.TabIndex = 72;
            label3.Text = "*Cantidad";
            // 
            // comboMedicamentos
            // 
            comboMedicamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboMedicamentos.Enabled = false;
            comboMedicamentos.FormattingEnabled = true;
            comboMedicamentos.Location = new System.Drawing.Point(235, 82);
            comboMedicamentos.Name = "comboMedicamentos";
            comboMedicamentos.Size = new System.Drawing.Size(241, 26);
            comboMedicamentos.TabIndex = 71;
            comboMedicamentos.SelectedIndexChanged += comboMedicamentos_SelectedIndexChanged;
            // 
            // txtDosis
            // 
            txtDosis.Location = new System.Drawing.Point(234, 114);
            txtDosis.Multiline = true;
            txtDosis.Name = "txtDosis";
            txtDosis.Size = new System.Drawing.Size(242, 69);
            txtDosis.TabIndex = 70;
            // 
            // lblMedicamentos
            // 
            lblMedicamentos.AutoSize = true;
            lblMedicamentos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMedicamentos.Location = new System.Drawing.Point(234, 65);
            lblMedicamentos.Name = "lblMedicamentos";
            lblMedicamentos.Size = new System.Drawing.Size(94, 14);
            lblMedicamentos.TabIndex = 69;
            lblMedicamentos.Text = "*Medicamentos";
            // 
            // txtFechaRetiro
            // 
            txtFechaRetiro.Enabled = false;
            txtFechaRetiro.Location = new System.Drawing.Point(9, 100);
            txtFechaRetiro.Name = "txtFechaRetiro";
            txtFechaRetiro.Size = new System.Drawing.Size(200, 26);
            txtFechaRetiro.TabIndex = 29;
            // 
            // txtNombreReceta
            // 
            txtNombreReceta.Location = new System.Drawing.Point(9, 39);
            txtNombreReceta.Name = "txtNombreReceta";
            txtNombreReceta.Size = new System.Drawing.Size(200, 26);
            txtNombreReceta.TabIndex = 26;
            // 
            // lblReceta
            // 
            lblReceta.AutoSize = true;
            lblReceta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblReceta.Location = new System.Drawing.Point(9, 21);
            lblReceta.Name = "lblReceta";
            lblReceta.Size = new System.Drawing.Size(105, 15);
            lblReceta.TabIndex = 25;
            lblReceta.Text = "Nombre de Receta";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new System.Drawing.Point(9, 158);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new System.Drawing.Size(200, 26);
            txtDuracion.TabIndex = 21;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDuracion.Location = new System.Drawing.Point(9, 140);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new System.Drawing.Size(58, 15);
            lblDuracion.TabIndex = 20;
            lblDuracion.Text = "Duración";
            // 
            // lblFechasRetiro
            // 
            lblFechasRetiro.AutoSize = true;
            lblFechasRetiro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFechasRetiro.Location = new System.Drawing.Point(9, 82);
            lblFechasRetiro.Name = "lblFechasRetiro";
            lblFechasRetiro.Size = new System.Drawing.Size(90, 15);
            lblFechasRetiro.TabIndex = 16;
            lblFechasRetiro.Text = "Fecha de Retiro";
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new System.Drawing.Point(497, 39);
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new System.Drawing.Size(204, 201);
            txtIndicaciones.TabIndex = 13;
            // 
            // lblIndicaciones
            // 
            lblIndicaciones.AutoSize = true;
            lblIndicaciones.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIndicaciones.Location = new System.Drawing.Point(497, 21);
            lblIndicaciones.Name = "lblIndicaciones";
            lblIndicaciones.Size = new System.Drawing.Size(78, 15);
            lblIndicaciones.TabIndex = 12;
            lblIndicaciones.Text = "Indicaciones";
            // 
            // dgrListarReceta
            // 
            dgrListarReceta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgrListarReceta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgrListarReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrListarReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { recetaid, especialista, NOMBRE, paciente, cedula, fechaentrega, proximareceta, dosis, duracion, cantidadrecetas, indicaciones });
            dgrListarReceta.Location = new System.Drawing.Point(17, 25);
            dgrListarReceta.Name = "dgrListarReceta";
            dgrListarReceta.RowHeadersVisible = false;
            dgrListarReceta.RowTemplate.Height = 25;
            dgrListarReceta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgrListarReceta.Size = new System.Drawing.Size(684, 103);
            dgrListarReceta.TabIndex = 9;
            dgrListarReceta.CellContentClick += dgrListarReceta_CellContentClick;
            // 
            // recetaid
            // 
            recetaid.DataPropertyName = "RecetaId";
            recetaid.HeaderText = "RECETA_ID";
            recetaid.Name = "recetaid";
            // 
            // especialista
            // 
            especialista.DataPropertyName = "Especialista";
            especialista.HeaderText = "ESPECIALISTA";
            especialista.Name = "especialista";
            // 
            // NOMBRE
            // 
            NOMBRE.DataPropertyName = "NombreReceta";
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.Name = "NOMBRE";
            // 
            // paciente
            // 
            paciente.HeaderText = "PACIENTE";
            paciente.Name = "paciente";
            // 
            // cedula
            // 
            cedula.HeaderText = "IDENTIFICACION";
            cedula.Name = "cedula";
            // 
            // fechaentrega
            // 
            fechaentrega.DataPropertyName = "FechaRetiro";
            fechaentrega.HeaderText = "ENTREGA";
            fechaentrega.Name = "fechaentrega";
            // 
            // proximareceta
            // 
            proximareceta.DataPropertyName = "ProximaReceta";
            proximareceta.HeaderText = "PRÓXIMA";
            proximareceta.Name = "proximareceta";
            // 
            // dosis
            // 
            dosis.DataPropertyName = "Dosis";
            dosis.HeaderText = "DOSIS";
            dosis.Name = "dosis";
            // 
            // duracion
            // 
            duracion.DataPropertyName = "Duracion";
            duracion.HeaderText = "DURACIÓN";
            duracion.Name = "duracion";
            // 
            // cantidadrecetas
            // 
            cantidadrecetas.DataPropertyName = "CantidadRecetas";
            cantidadrecetas.HeaderText = "CANTIDAD";
            cantidadrecetas.Name = "cantidadrecetas";
            // 
            // indicaciones
            // 
            indicaciones.DataPropertyName = "Indicaciones";
            indicaciones.HeaderText = "INDICACIONES";
            indicaciones.Name = "indicaciones";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgrListarReceta);
            groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(12, 402);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(716, 147);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listar Recetas";
            // 
            // btnGuardarReceta
            // 
            btnGuardarReceta.Enabled = false;
            btnGuardarReceta.Location = new System.Drawing.Point(623, 555);
            btnGuardarReceta.Name = "btnGuardarReceta";
            btnGuardarReceta.Size = new System.Drawing.Size(105, 61);
            btnGuardarReceta.TabIndex = 33;
            btnGuardarReceta.Text = "GUARDAR";
            btnGuardarReceta.UseVisualStyleBackColor = true;
            btnGuardarReceta.Click += btnGuardarReceta_Click;
            // 
            // btnBuscarRecetas
            // 
            btnBuscarRecetas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBuscarRecetas.Location = new System.Drawing.Point(179, 555);
            btnBuscarRecetas.Name = "btnBuscarRecetas";
            btnBuscarRecetas.Size = new System.Drawing.Size(105, 61);
            btnBuscarRecetas.TabIndex = 32;
            btnBuscarRecetas.Text = "BUSCAR";
            btnBuscarRecetas.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.Location = new System.Drawing.Point(12, 555);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(105, 61);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEditarRecetas
            // 
            btnEditarRecetas.Location = new System.Drawing.Point(401, 555);
            btnEditarRecetas.Name = "btnEditarRecetas";
            btnEditarRecetas.Size = new System.Drawing.Size(105, 61);
            btnEditarRecetas.TabIndex = 30;
            btnEditarRecetas.Text = "EDITAR";
            btnEditarRecetas.UseVisualStyleBackColor = true;
            // 
            // btnEliminarRecetas
            // 
            btnEliminarRecetas.Location = new System.Drawing.Point(290, 555);
            btnEliminarRecetas.Name = "btnEliminarRecetas";
            btnEliminarRecetas.Size = new System.Drawing.Size(105, 61);
            btnEliminarRecetas.TabIndex = 29;
            btnEliminarRecetas.Text = "ELIMINAR";
            btnEliminarRecetas.UseVisualStyleBackColor = true;
            // 
            // btnNuevaReceta
            // 
            btnNuevaReceta.Location = new System.Drawing.Point(512, 555);
            btnNuevaReceta.Name = "btnNuevaReceta";
            btnNuevaReceta.Size = new System.Drawing.Size(105, 61);
            btnNuevaReceta.TabIndex = 28;
            btnNuevaReceta.Text = "NUEVO";
            btnNuevaReceta.UseVisualStyleBackColor = true;
            // 
            // txtMedico
            // 
            txtMedico.Enabled = false;
            txtMedico.Location = new System.Drawing.Point(384, 43);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new System.Drawing.Size(326, 26);
            txtMedico.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(384, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 15);
            label2.TabIndex = 36;
            label2.Text = "Médico";
            // 
            // txtPaciente
            // 
            txtPaciente.Enabled = false;
            txtPaciente.Location = new System.Drawing.Point(10, 43);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new System.Drawing.Size(326, 26);
            txtPaciente.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(10, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 34;
            label1.Text = "Paciente";
            // 
            // groupPacienteMedico
            // 
            groupPacienteMedico.Controls.Add(txtMedico);
            groupPacienteMedico.Controls.Add(label2);
            groupPacienteMedico.Controls.Add(label1);
            groupPacienteMedico.Controls.Add(txtPaciente);
            groupPacienteMedico.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupPacienteMedico.Location = new System.Drawing.Point(12, 46);
            groupPacienteMedico.Name = "groupPacienteMedico";
            groupPacienteMedico.Size = new System.Drawing.Size(716, 79);
            groupPacienteMedico.TabIndex = 30;
            groupPacienteMedico.TabStop = false;
            groupPacienteMedico.Text = "Datos";
            // 
            // numericCantidadRecetas
            // 
            numericCantidadRecetas.Location = new System.Drawing.Point(9, 214);
            numericCantidadRecetas.Name = "numericCantidadRecetas";
            numericCantidadRecetas.Size = new System.Drawing.Size(200, 26);
            numericCantidadRecetas.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(9, 197);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(98, 14);
            label4.TabIndex = 74;
            label4.Text = "Cantidad recetas";
            // 
            // lclProximaReceta
            // 
            lclProximaReceta.AutoSize = true;
            lclProximaReceta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lclProximaReceta.Location = new System.Drawing.Point(235, 197);
            lclProximaReceta.Name = "lclProximaReceta";
            lclProximaReceta.Size = new System.Drawing.Size(92, 15);
            lclProximaReceta.TabIndex = 76;
            lclProximaReceta.Text = "Próxima Receta";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(234, 214);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(242, 26);
            dateTimePicker1.TabIndex = 77;
            // 
            // txtIdReceta
            // 
            txtIdReceta.Enabled = false;
            txtIdReceta.Location = new System.Drawing.Point(629, 27);
            txtIdReceta.Name = "txtIdReceta";
            txtIdReceta.Size = new System.Drawing.Size(99, 23);
            txtIdReceta.TabIndex = 35;
            // 
            // lblNumeroReceta
            // 
            lblNumeroReceta.AutoSize = true;
            lblNumeroReceta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNumeroReceta.Location = new System.Drawing.Point(629, 9);
            lblNumeroReceta.Name = "lblNumeroReceta";
            lblNumeroReceta.Size = new System.Drawing.Size(52, 15);
            lblNumeroReceta.TabIndex = 34;
            lblNumeroReceta.Text = "# Receta";
            // 
            // Frm_Recetas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(740, 642);
            Controls.Add(txtIdReceta);
            Controls.Add(btnGuardarReceta);
            Controls.Add(btnBuscarRecetas);
            Controls.Add(lblNumeroReceta);
            Controls.Add(btnSalir);
            Controls.Add(btnEditarRecetas);
            Controls.Add(btnEliminarRecetas);
            Controls.Add(btnNuevaReceta);
            Controls.Add(groupRecetas);
            Controls.Add(groupBox1);
            Controls.Add(groupPacienteMedico);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Recetas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Receta Médica";
            Load += Frm_Recetas_Load;
            groupRecetas.ResumeLayout(false);
            groupRecetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrListarReceta).EndInit();
            groupBox1.ResumeLayout(false);
            groupPacienteMedico.ResumeLayout(false);
            groupPacienteMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericCantidadRecetas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupRecetas;
        private System.Windows.Forms.Label lblFechasRetiro;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.DataGridView dgrListarReceta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarReceta;
        private System.Windows.Forms.Button btnBuscarRecetas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditarRecetas;
        private System.Windows.Forms.Button btnEliminarRecetas;
        private System.Windows.Forms.Button btnNuevaReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn recetaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaentrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximareceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadrecetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicaciones;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.TextBox txtFechaRetiro;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupPacienteMedico;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMedicamentos;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.Label lblMedicamentos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lclProximaReceta;
        private System.Windows.Forms.NumericUpDown numericCantidadRecetas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdReceta;
        private System.Windows.Forms.Label lblNumeroReceta;
    }
}