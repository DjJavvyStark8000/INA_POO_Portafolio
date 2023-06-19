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
            comboCantidadRecetas = new System.Windows.Forms.ComboBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtNombreReceta = new System.Windows.Forms.TextBox();
            lblReceta = new System.Windows.Forms.Label();
            dateProximaEntrega = new System.Windows.Forms.DateTimePicker();
            lblIDPacienteReceta = new System.Windows.Forms.Label();
            lblProximaReceta = new System.Windows.Forms.Label();
            lblRecetaPaciente = new System.Windows.Forms.Label();
            txtPaciente = new System.Windows.Forms.TextBox();
            dateEntrega = new System.Windows.Forms.DateTimePicker();
            txtCedulaPaciente = new System.Windows.Forms.TextBox();
            txtDuracion = new System.Windows.Forms.TextBox();
            lblDuracion = new System.Windows.Forms.Label();
            txtIdReceta = new System.Windows.Forms.TextBox();
            lblNumeroReceta = new System.Windows.Forms.Label();
            lblFechasEntrega = new System.Windows.Forms.Label();
            lblNumeroRecetas = new System.Windows.Forms.Label();
            txtIndicaciones = new System.Windows.Forms.TextBox();
            lblIndicaciones = new System.Windows.Forms.Label();
            txtEspecialista = new System.Windows.Forms.TextBox();
            lblEspecialista = new System.Windows.Forms.Label();
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
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscarEspecial = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEditarEspecialidad = new System.Windows.Forms.Button();
            btnEliminarEspecialidad = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            groupRecetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrListarReceta).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupRecetas
            // 
            groupRecetas.Controls.Add(comboCantidadRecetas);
            groupRecetas.Controls.Add(textBox1);
            groupRecetas.Controls.Add(label4);
            groupRecetas.Controls.Add(txtNombreReceta);
            groupRecetas.Controls.Add(lblReceta);
            groupRecetas.Controls.Add(dateProximaEntrega);
            groupRecetas.Controls.Add(lblIDPacienteReceta);
            groupRecetas.Controls.Add(lblProximaReceta);
            groupRecetas.Controls.Add(lblRecetaPaciente);
            groupRecetas.Controls.Add(txtPaciente);
            groupRecetas.Controls.Add(dateEntrega);
            groupRecetas.Controls.Add(txtCedulaPaciente);
            groupRecetas.Controls.Add(txtDuracion);
            groupRecetas.Controls.Add(lblDuracion);
            groupRecetas.Controls.Add(txtIdReceta);
            groupRecetas.Controls.Add(lblNumeroReceta);
            groupRecetas.Controls.Add(lblFechasEntrega);
            groupRecetas.Controls.Add(lblNumeroRecetas);
            groupRecetas.Controls.Add(txtIndicaciones);
            groupRecetas.Controls.Add(lblIndicaciones);
            groupRecetas.Controls.Add(txtEspecialista);
            groupRecetas.Controls.Add(lblEspecialista);
            groupRecetas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupRecetas.Location = new System.Drawing.Point(12, 12);
            groupRecetas.Name = "groupRecetas";
            groupRecetas.Size = new System.Drawing.Size(1126, 211);
            groupRecetas.TabIndex = 7;
            groupRecetas.TabStop = false;
            groupRecetas.Text = "Recetas";
            // 
            // comboCantidadRecetas
            // 
            comboCantidadRecetas.FormattingEnabled = true;
            comboCantidadRecetas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboCantidadRecetas.Location = new System.Drawing.Point(722, 109);
            comboCantidadRecetas.Name = "comboCantidadRecetas";
            comboCantidadRecetas.Size = new System.Drawing.Size(200, 26);
            comboCantidadRecetas.TabIndex = 29;
            comboCantidadRecetas.Text = "Seleccione una";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new System.Drawing.Point(500, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(422, 26);
            textBox1.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(500, 34);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 15);
            label4.TabIndex = 27;
            label4.Text = "Dosis";
            // 
            // txtNombreReceta
            // 
            txtNombreReceta.Location = new System.Drawing.Point(17, 106);
            txtNombreReceta.Name = "txtNombreReceta";
            txtNombreReceta.Size = new System.Drawing.Size(200, 26);
            txtNombreReceta.TabIndex = 26;
            // 
            // lblReceta
            // 
            lblReceta.AutoSize = true;
            lblReceta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblReceta.Location = new System.Drawing.Point(17, 88);
            lblReceta.Name = "lblReceta";
            lblReceta.Size = new System.Drawing.Size(105, 15);
            lblReceta.TabIndex = 25;
            lblReceta.Text = "Nombre de Receta";
            lblReceta.Click += label4_Click;
            // 
            // dateProximaEntrega
            // 
            dateProximaEntrega.Location = new System.Drawing.Point(239, 165);
            dateProximaEntrega.Name = "dateProximaEntrega";
            dateProximaEntrega.Size = new System.Drawing.Size(200, 26);
            dateProximaEntrega.TabIndex = 24;
            // 
            // lblIDPacienteReceta
            // 
            lblIDPacienteReceta.AutoSize = true;
            lblIDPacienteReceta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIDPacienteReceta.Location = new System.Drawing.Point(239, 34);
            lblIDPacienteReceta.Name = "lblIDPacienteReceta";
            lblIDPacienteReceta.Size = new System.Drawing.Size(82, 15);
            lblIDPacienteReceta.TabIndex = 10;
            lblIDPacienteReceta.Text = "Identificación";
            // 
            // lblProximaReceta
            // 
            lblProximaReceta.AutoSize = true;
            lblProximaReceta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblProximaReceta.Location = new System.Drawing.Point(239, 147);
            lblProximaReceta.Name = "lblProximaReceta";
            lblProximaReceta.Size = new System.Drawing.Size(92, 15);
            lblProximaReceta.TabIndex = 23;
            lblProximaReceta.Text = "Próxima Receta";
            // 
            // lblRecetaPaciente
            // 
            lblRecetaPaciente.AutoSize = true;
            lblRecetaPaciente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRecetaPaciente.Location = new System.Drawing.Point(17, 34);
            lblRecetaPaciente.Name = "lblRecetaPaciente";
            lblRecetaPaciente.Size = new System.Drawing.Size(54, 15);
            lblRecetaPaciente.TabIndex = 8;
            lblRecetaPaciente.Text = "Paciente";
            // 
            // txtPaciente
            // 
            txtPaciente.Enabled = false;
            txtPaciente.Location = new System.Drawing.Point(17, 52);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new System.Drawing.Size(200, 26);
            txtPaciente.TabIndex = 9;
            // 
            // dateEntrega
            // 
            dateEntrega.Location = new System.Drawing.Point(17, 165);
            dateEntrega.Name = "dateEntrega";
            dateEntrega.Size = new System.Drawing.Size(200, 26);
            dateEntrega.TabIndex = 22;
            // 
            // txtCedulaPaciente
            // 
            txtCedulaPaciente.Enabled = false;
            txtCedulaPaciente.Location = new System.Drawing.Point(239, 52);
            txtCedulaPaciente.Name = "txtCedulaPaciente";
            txtCedulaPaciente.Size = new System.Drawing.Size(200, 26);
            txtCedulaPaciente.TabIndex = 11;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new System.Drawing.Point(500, 109);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new System.Drawing.Size(200, 26);
            txtDuracion.TabIndex = 21;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDuracion.Location = new System.Drawing.Point(500, 91);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new System.Drawing.Size(58, 15);
            lblDuracion.TabIndex = 20;
            lblDuracion.Text = "Duración";
            // 
            // txtIdReceta
            // 
            txtIdReceta.Location = new System.Drawing.Point(239, 106);
            txtIdReceta.Name = "txtIdReceta";
            txtIdReceta.Size = new System.Drawing.Size(200, 26);
            txtIdReceta.TabIndex = 19;
            // 
            // lblNumeroReceta
            // 
            lblNumeroReceta.AutoSize = true;
            lblNumeroReceta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNumeroReceta.Location = new System.Drawing.Point(239, 88);
            lblNumeroReceta.Name = "lblNumeroReceta";
            lblNumeroReceta.Size = new System.Drawing.Size(105, 15);
            lblNumeroReceta.TabIndex = 18;
            lblNumeroReceta.Text = "Número de Receta";
            // 
            // lblFechasEntrega
            // 
            lblFechasEntrega.AutoSize = true;
            lblFechasEntrega.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFechasEntrega.Location = new System.Drawing.Point(17, 147);
            lblFechasEntrega.Name = "lblFechasEntrega";
            lblFechasEntrega.Size = new System.Drawing.Size(105, 15);
            lblFechasEntrega.TabIndex = 16;
            lblFechasEntrega.Text = "Fechas de Entrega";
            // 
            // lblNumeroRecetas
            // 
            lblNumeroRecetas.AutoSize = true;
            lblNumeroRecetas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNumeroRecetas.Location = new System.Drawing.Point(722, 91);
            lblNumeroRecetas.Name = "lblNumeroRecetas";
            lblNumeroRecetas.Size = new System.Drawing.Size(117, 15);
            lblNumeroRecetas.TabIndex = 14;
            lblNumeroRecetas.Text = "Cantidad de Recetas";
            // 
            // txtIndicaciones
            // 
            txtIndicaciones.Location = new System.Drawing.Point(946, 52);
            txtIndicaciones.Multiline = true;
            txtIndicaciones.Name = "txtIndicaciones";
            txtIndicaciones.Size = new System.Drawing.Size(161, 139);
            txtIndicaciones.TabIndex = 13;
            // 
            // lblIndicaciones
            // 
            lblIndicaciones.AutoSize = true;
            lblIndicaciones.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIndicaciones.Location = new System.Drawing.Point(946, 34);
            lblIndicaciones.Name = "lblIndicaciones";
            lblIndicaciones.Size = new System.Drawing.Size(78, 15);
            lblIndicaciones.TabIndex = 12;
            lblIndicaciones.Text = "Indicaciones";
            // 
            // txtEspecialista
            // 
            txtEspecialista.Enabled = false;
            txtEspecialista.Location = new System.Drawing.Point(500, 165);
            txtEspecialista.Name = "txtEspecialista";
            txtEspecialista.Size = new System.Drawing.Size(422, 26);
            txtEspecialista.TabIndex = 7;
            // 
            // lblEspecialista
            // 
            lblEspecialista.AutoSize = true;
            lblEspecialista.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEspecialista.Location = new System.Drawing.Point(500, 147);
            lblEspecialista.Name = "lblEspecialista";
            lblEspecialista.Size = new System.Drawing.Size(74, 15);
            lblEspecialista.TabIndex = 6;
            lblEspecialista.Text = "Especialista";
            // 
            // dgrListarReceta
            // 
            dgrListarReceta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgrListarReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrListarReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { recetaid, especialista, NOMBRE, paciente, cedula, fechaentrega, proximareceta, dosis, duracion, cantidadrecetas, indicaciones });
            dgrListarReceta.Location = new System.Drawing.Point(17, 25);
            dgrListarReceta.Name = "dgrListarReceta";
            dgrListarReceta.RowTemplate.Height = 25;
            dgrListarReceta.Size = new System.Drawing.Size(1090, 406);
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
            groupBox1.Location = new System.Drawing.Point(12, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1126, 449);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listar Recetas";
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new System.Drawing.Point(1018, 701);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(120, 61);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarEspecial
            // 
            btnBuscarEspecial.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBuscarEspecial.Location = new System.Drawing.Point(512, 701);
            btnBuscarEspecial.Name = "btnBuscarEspecial";
            btnBuscarEspecial.Size = new System.Drawing.Size(120, 61);
            btnBuscarEspecial.TabIndex = 32;
            btnBuscarEspecial.Text = "BUSCAR";
            btnBuscarEspecial.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.Location = new System.Drawing.Point(12, 701);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(242, 61);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditarEspecialidad
            // 
            btnEditarEspecialidad.Location = new System.Drawing.Point(764, 701);
            btnEditarEspecialidad.Name = "btnEditarEspecialidad";
            btnEditarEspecialidad.Size = new System.Drawing.Size(120, 61);
            btnEditarEspecialidad.TabIndex = 30;
            btnEditarEspecialidad.Text = "EDITAR";
            btnEditarEspecialidad.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEspecialidad
            // 
            btnEliminarEspecialidad.Location = new System.Drawing.Point(638, 701);
            btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            btnEliminarEspecialidad.Size = new System.Drawing.Size(120, 61);
            btnEliminarEspecialidad.TabIndex = 29;
            btnEliminarEspecialidad.Text = "ELIMINAR";
            btnEliminarEspecialidad.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new System.Drawing.Point(892, 701);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(120, 61);
            btnNuevo.TabIndex = 28;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // Frm_Recetas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1154, 805);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscarEspecial);
            Controls.Add(btnSalir);
            Controls.Add(btnEditarEspecialidad);
            Controls.Add(btnEliminarEspecialidad);
            Controls.Add(btnNuevo);
            Controls.Add(groupRecetas);
            Controls.Add(groupBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Recetas";
            Text = "Receta Médica";
            Load += Frm_Recetas_Load;
            groupRecetas.ResumeLayout(false);
            groupRecetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrListarReceta).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupRecetas;
        private System.Windows.Forms.Label lblFechasEntrega;
        private System.Windows.Forms.Label lblNumeroRecetas;
        private System.Windows.Forms.TextBox txtIndicaciones;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.TextBox txtCedulaPaciente;
        private System.Windows.Forms.Label lblIDPacienteReceta;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblRecetaPaciente;
        private System.Windows.Forms.TextBox txtEspecialista;
        private System.Windows.Forms.Label lblEspecialista;
        private System.Windows.Forms.Label lblNumeroReceta;
        private System.Windows.Forms.TextBox txtIdReceta;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.DateTimePicker dateProximaEntrega;
        private System.Windows.Forms.Label lblProximaReceta;
        private System.Windows.Forms.DateTimePicker dateEntrega;
        private System.Windows.Forms.DataGridView dgrListarReceta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarEspecial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditarEspecialidad;
        private System.Windows.Forms.Button btnEliminarEspecialidad;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCantidadRecetas;
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
    }
}