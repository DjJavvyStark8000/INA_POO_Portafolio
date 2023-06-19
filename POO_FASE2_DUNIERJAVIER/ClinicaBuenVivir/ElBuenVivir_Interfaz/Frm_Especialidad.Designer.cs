namespace ElBuenVivir_Interfaz
{
    partial class Frm_Especialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Especialidad));
            txtNombreEspecialidad = new System.Windows.Forms.TextBox();
            lblNombreEspecialidad = new System.Windows.Forms.Label();
            groupEspecialidades = new System.Windows.Forms.GroupBox();
            lblRequeridos = new System.Windows.Forms.Label();
            txtIdEspecialidad = new System.Windows.Forms.TextBox();
            lblIdEspecialidad = new System.Windows.Forms.Label();
            lblObservaciones = new System.Windows.Forms.Label();
            txtObservaciones = new System.Windows.Forms.TextBox();
            txtDisponibilidad = new System.Windows.Forms.TextBox();
            lblDisponibilidad = new System.Windows.Forms.Label();
            txtCosto = new System.Windows.Forms.TextBox();
            lblCosto = new System.Windows.Forms.Label();
            txtArea = new System.Windows.Forms.TextBox();
            lblArea = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            lblDescripcionEspecial = new System.Windows.Forms.Label();
            dgrEspecialidades = new System.Windows.Forms.DataGridView();
            clmEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmDisponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblVerEspecialidad = new System.Windows.Forms.Label();
            btnNuevo = new System.Windows.Forms.Button();
            btnEliminarEspecialidad = new System.Windows.Forms.Button();
            btnEditarEspecialidad = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnBuscarEspecial = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            groupEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // txtNombreEspecialidad
            // 
            txtNombreEspecialidad.Location = new System.Drawing.Point(12, 117);
            txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            txtNombreEspecialidad.Size = new System.Drawing.Size(242, 26);
            txtNombreEspecialidad.TabIndex = 8;
            // 
            // lblNombreEspecialidad
            // 
            lblNombreEspecialidad.AutoSize = true;
            lblNombreEspecialidad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombreEspecialidad.Location = new System.Drawing.Point(12, 99);
            lblNombreEspecialidad.Name = "lblNombreEspecialidad";
            lblNombreEspecialidad.Size = new System.Drawing.Size(138, 14);
            lblNombreEspecialidad.TabIndex = 7;
            lblNombreEspecialidad.Text = "Nombre la Especialidad";
            // 
            // groupEspecialidades
            // 
            groupEspecialidades.Controls.Add(lblRequeridos);
            groupEspecialidades.Controls.Add(txtIdEspecialidad);
            groupEspecialidades.Controls.Add(lblIdEspecialidad);
            groupEspecialidades.Controls.Add(lblObservaciones);
            groupEspecialidades.Controls.Add(txtObservaciones);
            groupEspecialidades.Controls.Add(txtDisponibilidad);
            groupEspecialidades.Controls.Add(lblDisponibilidad);
            groupEspecialidades.Controls.Add(lblNombreEspecialidad);
            groupEspecialidades.Controls.Add(txtCosto);
            groupEspecialidades.Controls.Add(lblCosto);
            groupEspecialidades.Controls.Add(txtNombreEspecialidad);
            groupEspecialidades.Controls.Add(txtArea);
            groupEspecialidades.Controls.Add(lblArea);
            groupEspecialidades.Controls.Add(txtDescripcion);
            groupEspecialidades.Controls.Add(lblDescripcionEspecial);
            groupEspecialidades.Controls.Add(dgrEspecialidades);
            groupEspecialidades.Controls.Add(lblVerEspecialidad);
            groupEspecialidades.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupEspecialidades.Location = new System.Drawing.Point(12, 12);
            groupEspecialidades.Name = "groupEspecialidades";
            groupEspecialidades.Size = new System.Drawing.Size(1157, 597);
            groupEspecialidades.TabIndex = 13;
            groupEspecialidades.TabStop = false;
            groupEspecialidades.Text = "Especialidades Médicas";
            // 
            // lblRequeridos
            // 
            lblRequeridos.AutoSize = true;
            lblRequeridos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRequeridos.ForeColor = System.Drawing.Color.Red;
            lblRequeridos.Location = new System.Drawing.Point(12, 555);
            lblRequeridos.Name = "lblRequeridos";
            lblRequeridos.Size = new System.Drawing.Size(218, 18);
            lblRequeridos.TabIndex = 33;
            lblRequeridos.Text = "*Todos los campos son requeridos";
            // 
            // txtIdEspecialidad
            // 
            txtIdEspecialidad.Enabled = false;
            txtIdEspecialidad.Location = new System.Drawing.Point(12, 58);
            txtIdEspecialidad.Name = "txtIdEspecialidad";
            txtIdEspecialidad.Size = new System.Drawing.Size(242, 26);
            txtIdEspecialidad.TabIndex = 32;
            // 
            // lblIdEspecialidad
            // 
            lblIdEspecialidad.AutoSize = true;
            lblIdEspecialidad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIdEspecialidad.Location = new System.Drawing.Point(12, 40);
            lblIdEspecialidad.Name = "lblIdEspecialidad";
            lblIdEspecialidad.Size = new System.Drawing.Size(19, 14);
            lblIdEspecialidad.TabIndex = 31;
            lblIdEspecialidad.Text = "ID";
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblObservaciones.Location = new System.Drawing.Point(11, 450);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new System.Drawing.Size(87, 14);
            lblObservaciones.TabIndex = 30;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Enabled = false;
            txtObservaciones.Location = new System.Drawing.Point(12, 467);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new System.Drawing.Size(242, 85);
            txtObservaciones.TabIndex = 25;
            txtObservaciones.TextChanged += txtObservaciones_TextChanged;
            // 
            // txtDisponibilidad
            // 
            txtDisponibilidad.Enabled = false;
            txtDisponibilidad.Location = new System.Drawing.Point(11, 410);
            txtDisponibilidad.Name = "txtDisponibilidad";
            txtDisponibilidad.Size = new System.Drawing.Size(242, 26);
            txtDisponibilidad.TabIndex = 29;
            // 
            // lblDisponibilidad
            // 
            lblDisponibilidad.AutoSize = true;
            lblDisponibilidad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDisponibilidad.Location = new System.Drawing.Point(11, 392);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new System.Drawing.Size(90, 14);
            lblDisponibilidad.TabIndex = 28;
            lblDisponibilidad.Text = "Disponibilidad";
            // 
            // txtCosto
            // 
            txtCosto.Enabled = false;
            txtCosto.Location = new System.Drawing.Point(11, 347);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new System.Drawing.Size(242, 26);
            txtCosto.TabIndex = 27;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCosto.Location = new System.Drawing.Point(11, 329);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new System.Drawing.Size(37, 14);
            lblCosto.TabIndex = 26;
            lblCosto.Text = "Costo";
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new System.Drawing.Point(11, 284);
            txtArea.Name = "txtArea";
            txtArea.Size = new System.Drawing.Size(242, 26);
            txtArea.TabIndex = 25;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblArea.Location = new System.Drawing.Point(11, 266);
            lblArea.Name = "lblArea";
            lblArea.Size = new System.Drawing.Size(32, 14);
            lblArea.TabIndex = 24;
            lblArea.Text = "Área";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new System.Drawing.Point(11, 178);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(242, 74);
            txtDescripcion.TabIndex = 23;
            // 
            // lblDescripcionEspecial
            // 
            lblDescripcionEspecial.AutoSize = true;
            lblDescripcionEspecial.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDescripcionEspecial.Location = new System.Drawing.Point(11, 160);
            lblDescripcionEspecial.Name = "lblDescripcionEspecial";
            lblDescripcionEspecial.Size = new System.Drawing.Size(71, 14);
            lblDescripcionEspecial.TabIndex = 22;
            lblDescripcionEspecial.Text = "Descripción";
            // 
            // dgrEspecialidades
            // 
            dgrEspecialidades.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dgrEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { clmEspecialidad, Nombre_Especialidad, clmDescripcion, clmArea, clmCosto, clmDisponibilidad, clmObservaciones });
            dgrEspecialidades.Location = new System.Drawing.Point(271, 58);
            dgrEspecialidades.Name = "dgrEspecialidades";
            dgrEspecialidades.RowTemplate.Height = 25;
            dgrEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgrEspecialidades.Size = new System.Drawing.Size(873, 494);
            dgrEspecialidades.TabIndex = 21;
            dgrEspecialidades.Click += dgrEspecialidades_Click;
            // 
            // clmEspecialidad
            // 
            clmEspecialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmEspecialidad.DataPropertyName = "ID_Especialidad";
            clmEspecialidad.HeaderText = "ID";
            clmEspecialidad.Name = "clmEspecialidad";
            clmEspecialidad.Width = 46;
            // 
            // Nombre_Especialidad
            // 
            Nombre_Especialidad.DataPropertyName = "Nombre_Especialidad";
            Nombre_Especialidad.HeaderText = "NOMBRE";
            Nombre_Especialidad.Name = "Nombre_Especialidad";
            Nombre_Especialidad.Width = 160;
            // 
            // clmDescripcion
            // 
            clmDescripcion.DataPropertyName = "DESCRIPCION";
            clmDescripcion.HeaderText = "DESCRIPCION";
            clmDescripcion.Name = "clmDescripcion";
            clmDescripcion.Width = 116;
            // 
            // clmArea
            // 
            clmArea.DataPropertyName = "AREA";
            clmArea.HeaderText = "AREA";
            clmArea.Name = "clmArea";
            // 
            // clmCosto
            // 
            clmCosto.DataPropertyName = "COSTO";
            clmCosto.HeaderText = "COSTO";
            clmCosto.Name = "clmCosto";
            clmCosto.Width = 80;
            // 
            // clmDisponibilidad
            // 
            clmDisponibilidad.DataPropertyName = "DISPONIBILIDAD";
            clmDisponibilidad.HeaderText = "DISPONIBLE";
            clmDisponibilidad.Name = "clmDisponibilidad";
            clmDisponibilidad.Width = 85;
            // 
            // clmObservaciones
            // 
            clmObservaciones.DataPropertyName = "OBSERVACIONES";
            clmObservaciones.HeaderText = "OBSERVACIONES";
            clmObservaciones.Name = "clmObservaciones";
            clmObservaciones.Width = 250;
            // 
            // lblVerEspecialidad
            // 
            lblVerEspecialidad.AutoSize = true;
            lblVerEspecialidad.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblVerEspecialidad.Location = new System.Drawing.Point(271, 40);
            lblVerEspecialidad.Name = "lblVerEspecialidad";
            lblVerEspecialidad.Size = new System.Drawing.Size(138, 14);
            lblVerEspecialidad.TabIndex = 8;
            lblVerEspecialidad.Text = "Lista de especialidades";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new System.Drawing.Point(910, 615);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(120, 61);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminarEspecialidad
            // 
            btnEliminarEspecialidad.Location = new System.Drawing.Point(656, 615);
            btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            btnEliminarEspecialidad.Size = new System.Drawing.Size(120, 61);
            btnEliminarEspecialidad.TabIndex = 22;
            btnEliminarEspecialidad.Text = "ELIMINAR";
            btnEliminarEspecialidad.UseVisualStyleBackColor = true;
            btnEliminarEspecialidad.Click += btnEliminarEspecialidad_Click;
            // 
            // btnEditarEspecialidad
            // 
            btnEditarEspecialidad.Location = new System.Drawing.Point(782, 615);
            btnEditarEspecialidad.Name = "btnEditarEspecialidad";
            btnEditarEspecialidad.Size = new System.Drawing.Size(120, 61);
            btnEditarEspecialidad.TabIndex = 23;
            btnEditarEspecialidad.Text = "EDITAR";
            btnEditarEspecialidad.UseVisualStyleBackColor = true;
            btnEditarEspecialidad.Click += btnEditarEspecialidad_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.Location = new System.Drawing.Point(24, 615);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(242, 61);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBuscarEspecial
            // 
            btnBuscarEspecial.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBuscarEspecial.Location = new System.Drawing.Point(530, 615);
            btnBuscarEspecial.Name = "btnBuscarEspecial";
            btnBuscarEspecial.Size = new System.Drawing.Size(120, 61);
            btnBuscarEspecial.TabIndex = 26;
            btnBuscarEspecial.Text = "BUSCAR";
            btnBuscarEspecial.UseVisualStyleBackColor = true;
            btnBuscarEspecial.Click += btnBuscarEspecial_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new System.Drawing.Point(1036, 615);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(120, 61);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Frm_Especialidad
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1180, 688);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscarEspecial);
            Controls.Add(btnSalir);
            Controls.Add(btnEditarEspecialidad);
            Controls.Add(btnEliminarEspecialidad);
            Controls.Add(btnNuevo);
            Controls.Add(groupEspecialidades);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Especialidad";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Especialidades";
            Load += Frm_Especialidad_Load;
            groupEspecialidades.ResumeLayout(false);
            groupEspecialidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrEspecialidades).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreEspecialidad;
        private System.Windows.Forms.Label lblNombreEspecialidad;
        private System.Windows.Forms.GroupBox groupEspecialidades;
        private System.Windows.Forms.Label lblVerEspecialidad;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgrEspecialidades;
        private System.Windows.Forms.Button btnEliminarEspecialidad;
        private System.Windows.Forms.Button btnEditarEspecialidad;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtDisponibilidad;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcionEspecial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDisponibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObservaciones;
        private System.Windows.Forms.Button btnBuscarEspecial;
        private System.Windows.Forms.TextBox txtIdEspecialidad;
        private System.Windows.Forms.Label lblIdEspecialidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblRequeridos;
    }
}