namespace ElBuenVivir_Interfaz
{
    partial class Frm_Pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pacientes));
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtGuardian = new System.Windows.Forms.TextBox();
            this.lblGuardian = new System.Windows.Forms.Label();
            this.panelAsegurado = new System.Windows.Forms.Panel();
            this.radioAseguradoNo = new System.Windows.Forms.RadioButton();
            this.radioAseguradoSi = new System.Windows.Forms.RadioButton();
            this.lblLarorando = new System.Windows.Forms.Label();
            this.panelLaborando = new System.Windows.Forms.Panel();
            this.radioLaborandoNo = new System.Windows.Forms.RadioButton();
            this.radioLaborandoSi = new System.Windows.Forms.RadioButton();
            this.lblLaborando = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.panelGenero = new System.Windows.Forms.Panel();
            this.radioMujer = new System.Windows.Forms.RadioButton();
            this.radioHombre = new System.Windows.Forms.RadioButton();
            this.groupContacto = new System.Windows.Forms.GroupBox();
            this.lblValidarCorreo = new System.Windows.Forms.Label();
            this.lblSoloNum3 = new System.Windows.Forms.Label();
            this.lblSoloNum2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetallesDireccion = new System.Windows.Forms.TextBox();
            this.lblDetallesDireccion = new System.Windows.Forms.Label();
            this.comboCiudades = new System.Windows.Forms.ComboBox();
            this.comboProvincias = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtEmergencia = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblEmergencia = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.comboTipoID = new System.Windows.Forms.ComboBox();
            this.lblTipoID = new System.Windows.Forms.Label();
            this.btnGuardarPaciente = new System.Windows.Forms.Button();
            this.btnSalirNPaciente = new System.Windows.Forms.Button();
            this.dgrListarPacientes = new System.Windows.Forms.DataGridView();
            this.paciente_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laborando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asegurado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHistorialId = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblSoloNum = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelAsegurado.SuspendLayout();
            this.panelLaborando.SuspendLayout();
            this.panelGenero.SuspendLayout();
            this.groupContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrListarPacientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombrePaciente.Location = new System.Drawing.Point(25, 166);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(50, 14);
            this.lblNombrePaciente.TabIndex = 0;
            this.lblNombrePaciente.Text = "Nombre";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(25, 184);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(200, 23);
            this.txtNombrePaciente.TabIndex = 1;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido1.Location = new System.Drawing.Point(257, 166);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(92, 14);
            this.lblApellido1.TabIndex = 2;
            this.lblApellido1.Text = "Primer Apellido";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido2.Location = new System.Drawing.Point(488, 166);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(104, 14);
            this.lblApellido2.TabIndex = 3;
            this.lblApellido2.Text = "Segundo Apellido";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(257, 184);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(200, 23);
            this.txtApellido1.TabIndex = 4;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(488, 184);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(200, 23);
            this.txtApellido2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateNacimiento);
            this.groupBox1.Controls.Add(this.comboEstadoCivil);
            this.groupBox1.Controls.Add(this.txtGuardian);
            this.groupBox1.Controls.Add(this.lblGuardian);
            this.groupBox1.Controls.Add(this.panelAsegurado);
            this.groupBox1.Controls.Add(this.lblLarorando);
            this.groupBox1.Controls.Add(this.panelLaborando);
            this.groupBox1.Controls.Add(this.lblLaborando);
            this.groupBox1.Controls.Add(this.lblEstadoCivil);
            this.groupBox1.Controls.Add(this.txtNacionalidad);
            this.groupBox1.Controls.Add(this.lblNacionalidad);
            this.groupBox1.Controls.Add(this.lblGenero);
            this.groupBox1.Controls.Add(this.lblNacimiento);
            this.groupBox1.Controls.Add(this.panelGenero);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 269);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del paciente";
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNacimiento.Location = new System.Drawing.Point(13, 107);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(200, 23);
            this.dateNacimiento.TabIndex = 17;
            // 
            // comboEstadoCivil
            // 
            this.comboEstadoCivil.FormattingEnabled = true;
            this.comboEstadoCivil.Items.AddRange(new object[] {
            "Casado/a",
            "Soltero/a",
            "Unión Libre",
            "Divorciado/a",
            "Otro"});
            this.comboEstadoCivil.Location = new System.Drawing.Point(15, 167);
            this.comboEstadoCivil.Name = "comboEstadoCivil";
            this.comboEstadoCivil.Size = new System.Drawing.Size(201, 26);
            this.comboEstadoCivil.TabIndex = 16;
            // 
            // txtGuardian
            // 
            this.txtGuardian.Location = new System.Drawing.Point(15, 231);
            this.txtGuardian.Name = "txtGuardian";
            this.txtGuardian.Size = new System.Drawing.Size(661, 26);
            this.txtGuardian.TabIndex = 15;
            // 
            // lblGuardian
            // 
            this.lblGuardian.AutoSize = true;
            this.lblGuardian.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGuardian.Location = new System.Drawing.Point(15, 213);
            this.lblGuardian.Name = "lblGuardian";
            this.lblGuardian.Size = new System.Drawing.Size(58, 14);
            this.lblGuardian.TabIndex = 14;
            this.lblGuardian.Text = "Guardian";
            // 
            // panelAsegurado
            // 
            this.panelAsegurado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelAsegurado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAsegurado.Controls.Add(this.radioAseguradoNo);
            this.panelAsegurado.Controls.Add(this.radioAseguradoSi);
            this.panelAsegurado.Location = new System.Drawing.Point(476, 167);
            this.panelAsegurado.Name = "panelAsegurado";
            this.panelAsegurado.Size = new System.Drawing.Size(200, 26);
            this.panelAsegurado.TabIndex = 13;
            // 
            // radioAseguradoNo
            // 
            this.radioAseguradoNo.AutoSize = true;
            this.radioAseguradoNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioAseguradoNo.Location = new System.Drawing.Point(105, 1);
            this.radioAseguradoNo.Name = "radioAseguradoNo";
            this.radioAseguradoNo.Size = new System.Drawing.Size(40, 19);
            this.radioAseguradoNo.TabIndex = 3;
            this.radioAseguradoNo.TabStop = true;
            this.radioAseguradoNo.Text = "No";
            this.radioAseguradoNo.UseVisualStyleBackColor = true;
            // 
            // radioAseguradoSi
            // 
            this.radioAseguradoSi.AutoSize = true;
            this.radioAseguradoSi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioAseguradoSi.Location = new System.Drawing.Point(20, 1);
            this.radioAseguradoSi.Name = "radioAseguradoSi";
            this.radioAseguradoSi.Size = new System.Drawing.Size(35, 19);
            this.radioAseguradoSi.TabIndex = 2;
            this.radioAseguradoSi.TabStop = true;
            this.radioAseguradoSi.Text = "Si";
            this.radioAseguradoSi.UseVisualStyleBackColor = true;
            // 
            // lblLarorando
            // 
            this.lblLarorando.AutoSize = true;
            this.lblLarorando.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLarorando.Location = new System.Drawing.Point(476, 147);
            this.lblLarorando.Name = "lblLarorando";
            this.lblLarorando.Size = new System.Drawing.Size(65, 15);
            this.lblLarorando.TabIndex = 12;
            this.lblLarorando.Text = "Asegurado";
            // 
            // panelLaborando
            // 
            this.panelLaborando.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLaborando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLaborando.Controls.Add(this.radioLaborandoNo);
            this.panelLaborando.Controls.Add(this.radioLaborandoSi);
            this.panelLaborando.Location = new System.Drawing.Point(245, 167);
            this.panelLaborando.Name = "panelLaborando";
            this.panelLaborando.Size = new System.Drawing.Size(200, 26);
            this.panelLaborando.TabIndex = 11;
            // 
            // radioLaborandoNo
            // 
            this.radioLaborandoNo.AutoSize = true;
            this.radioLaborandoNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioLaborandoNo.Location = new System.Drawing.Point(105, 1);
            this.radioLaborandoNo.Name = "radioLaborandoNo";
            this.radioLaborandoNo.Size = new System.Drawing.Size(40, 19);
            this.radioLaborandoNo.TabIndex = 3;
            this.radioLaborandoNo.TabStop = true;
            this.radioLaborandoNo.Text = "No";
            this.radioLaborandoNo.UseVisualStyleBackColor = true;
            // 
            // radioLaborandoSi
            // 
            this.radioLaborandoSi.AutoSize = true;
            this.radioLaborandoSi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioLaborandoSi.Location = new System.Drawing.Point(20, 1);
            this.radioLaborandoSi.Name = "radioLaborandoSi";
            this.radioLaborandoSi.Size = new System.Drawing.Size(35, 19);
            this.radioLaborandoSi.TabIndex = 2;
            this.radioLaborandoSi.TabStop = true;
            this.radioLaborandoSi.Text = "Si";
            this.radioLaborandoSi.UseVisualStyleBackColor = true;
            // 
            // lblLaborando
            // 
            this.lblLaborando.AutoSize = true;
            this.lblLaborando.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLaborando.Location = new System.Drawing.Point(245, 147);
            this.lblLaborando.Name = "lblLaborando";
            this.lblLaborando.Size = new System.Drawing.Size(66, 15);
            this.lblLaborando.TabIndex = 10;
            this.lblLaborando.Text = "Laborando";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoCivil.Location = new System.Drawing.Point(13, 147);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(72, 15);
            this.lblEstadoCivil.TabIndex = 8;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(476, 105);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(200, 26);
            this.txtNacionalidad.TabIndex = 7;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNacionalidad.Location = new System.Drawing.Point(476, 87);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(82, 15);
            this.lblNacionalidad.TabIndex = 6;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.Location = new System.Drawing.Point(245, 87);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(46, 15);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Genero";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNacimiento.Location = new System.Drawing.Point(13, 87);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(121, 15);
            this.lblNacimiento.TabIndex = 1;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // panelGenero
            // 
            this.panelGenero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGenero.Controls.Add(this.radioMujer);
            this.panelGenero.Controls.Add(this.radioHombre);
            this.panelGenero.Location = new System.Drawing.Point(245, 107);
            this.panelGenero.Name = "panelGenero";
            this.panelGenero.Size = new System.Drawing.Size(200, 23);
            this.panelGenero.TabIndex = 4;
            // 
            // radioMujer
            // 
            this.radioMujer.AutoSize = true;
            this.radioMujer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioMujer.Location = new System.Drawing.Point(105, 1);
            this.radioMujer.Name = "radioMujer";
            this.radioMujer.Size = new System.Drawing.Size(58, 19);
            this.radioMujer.TabIndex = 3;
            this.radioMujer.TabStop = true;
            this.radioMujer.Text = "Mujer";
            this.radioMujer.UseVisualStyleBackColor = true;
            // 
            // radioHombre
            // 
            this.radioHombre.AutoSize = true;
            this.radioHombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioHombre.Location = new System.Drawing.Point(20, 1);
            this.radioHombre.Name = "radioHombre";
            this.radioHombre.Size = new System.Drawing.Size(68, 19);
            this.radioHombre.TabIndex = 2;
            this.radioHombre.TabStop = true;
            this.radioHombre.Text = "Hombre";
            this.radioHombre.UseVisualStyleBackColor = true;
            // 
            // groupContacto
            // 
            this.groupContacto.Controls.Add(this.lblValidarCorreo);
            this.groupContacto.Controls.Add(this.lblSoloNum3);
            this.groupContacto.Controls.Add(this.lblSoloNum2);
            this.groupContacto.Controls.Add(this.txtCorreo);
            this.groupContacto.Controls.Add(this.label1);
            this.groupContacto.Controls.Add(this.txtDetallesDireccion);
            this.groupContacto.Controls.Add(this.lblDetallesDireccion);
            this.groupContacto.Controls.Add(this.comboCiudades);
            this.groupContacto.Controls.Add(this.comboProvincias);
            this.groupContacto.Controls.Add(this.lblProvincia);
            this.groupContacto.Controls.Add(this.txtEmergencia);
            this.groupContacto.Controls.Add(this.txtTelefono);
            this.groupContacto.Controls.Add(this.lblCiudad);
            this.groupContacto.Controls.Add(this.lblEmergencia);
            this.groupContacto.Controls.Add(this.lblTelefono);
            this.groupContacto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupContacto.Location = new System.Drawing.Point(728, 23);
            this.groupContacto.Name = "groupContacto";
            this.groupContacto.Size = new System.Drawing.Size(427, 381);
            this.groupContacto.TabIndex = 7;
            this.groupContacto.TabStop = false;
            this.groupContacto.Text = "Datos de contacto";
            // 
            // lblValidarCorreo
            // 
            this.lblValidarCorreo.AutoSize = true;
            this.lblValidarCorreo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblValidarCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblValidarCorreo.Location = new System.Drawing.Point(22, 126);
            this.lblValidarCorreo.Name = "lblValidarCorreo";
            this.lblValidarCorreo.Size = new System.Drawing.Size(117, 13);
            this.lblValidarCorreo.TabIndex = 24;
            this.lblValidarCorreo.Text = "Ingrese un correo válido";
            // 
            // lblSoloNum3
            // 
            this.lblSoloNum3.AutoSize = true;
            this.lblSoloNum3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSoloNum3.ForeColor = System.Drawing.Color.Red;
            this.lblSoloNum3.Location = new System.Drawing.Point(222, 67);
            this.lblSoloNum3.Name = "lblSoloNum3";
            this.lblSoloNum3.Size = new System.Drawing.Size(120, 13);
            this.lblSoloNum3.TabIndex = 23;
            this.lblSoloNum3.Text = "Solo se aceptan números";
            this.lblSoloNum3.Visible = false;
            // 
            // lblSoloNum2
            // 
            this.lblSoloNum2.AutoSize = true;
            this.lblSoloNum2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSoloNum2.ForeColor = System.Drawing.Color.Red;
            this.lblSoloNum2.Location = new System.Drawing.Point(19, 67);
            this.lblSoloNum2.Name = "lblSoloNum2";
            this.lblSoloNum2.Size = new System.Drawing.Size(120, 13);
            this.lblSoloNum2.TabIndex = 22;
            this.lblSoloNum2.Text = "Solo se aceptan números";
            this.lblSoloNum2.Visible = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(19, 98);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(388, 26);
            this.txtCorreo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Correo";
            // 
            // txtDetallesDireccion
            // 
            this.txtDetallesDireccion.Location = new System.Drawing.Point(21, 217);
            this.txtDetallesDireccion.Multiline = true;
            this.txtDetallesDireccion.Name = "txtDetallesDireccion";
            this.txtDetallesDireccion.Size = new System.Drawing.Size(386, 152);
            this.txtDetallesDireccion.TabIndex = 15;
            // 
            // lblDetallesDireccion
            // 
            this.lblDetallesDireccion.AutoSize = true;
            this.lblDetallesDireccion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetallesDireccion.Location = new System.Drawing.Point(19, 199);
            this.lblDetallesDireccion.Name = "lblDetallesDireccion";
            this.lblDetallesDireccion.Size = new System.Drawing.Size(123, 15);
            this.lblDetallesDireccion.TabIndex = 14;
            this.lblDetallesDireccion.Text = "Detalles de dirección";
            // 
            // comboCiudades
            // 
            this.comboCiudades.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboCiudades.FormattingEnabled = true;
            this.comboCiudades.Items.AddRange(new object[] {
            "Abangares",
            "Acosta",
            "Aguirre",
            "Alajuela",
            "Alajuelita",
            "Alvarado",
            "Aserrí",
            "Atenas",
            "Bagaces",
            "Barva",
            "Belén",
            "Buenos Aires",
            "Cañas",
            "Carrillo",
            "Cartago",
            "Corredores",
            "Coto Brus",
            "Curridabat",
            "Desamparados",
            "Dota",
            "El Guarco",
            "Escazú",
            "Esparza",
            "Flores",
            "Garabito",
            "Goicoechea",
            "Golfito",
            "Grecia",
            "Guácimo",
            "Guatuso",
            "Heredia",
            "Hojancha",
            "Jiménez",
            "La Cruz",
            "La Unión",
            "León Cortés Castro",
            "Liberia",
            "Limón",
            "Los Chiles",
            "Matina",
            "Montes de Oro",
            "Montes de Oca",
            "Mora",
            "Moravia",
            "Nandayure",
            "Naranjo",
            "Nicoya",
            "Oreamuno",
            "Orotina",
            "Osa",
            "Palmares",
            "Paraíso",
            "Parrita",
            "Pérez Zeledón",
            "Poás",
            "Pococí",
            "Puntarenas",
            "Puriscal",
            "Quepos",
            "Río Cuarto",
            "San Carlos",
            "San Isidro",
            "San José",
            "San Mateo",
            "San Pablo",
            "San Rafael",
            "San Ramón",
            "San Vito",
            "Santa Ana",
            "Santa Bárbara",
            "Santa Cruz",
            "Santa María",
            "Santo Domingo",
            "Sarapiquí",
            "Sarchí",
            "Siquirres",
            "Talamanca",
            "Tarrazú",
            "Tibás",
            "Tilarán",
            "Turrialba",
            "Upala"});
            this.comboCiudades.Location = new System.Drawing.Point(19, 158);
            this.comboCiudades.Name = "comboCiudades";
            this.comboCiudades.Size = new System.Drawing.Size(187, 22);
            this.comboCiudades.TabIndex = 13;
            this.comboCiudades.Text = "Seleccione una Ciudad";
            // 
            // comboProvincias
            // 
            this.comboProvincias.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboProvincias.FormattingEnabled = true;
            this.comboProvincias.Items.AddRange(new object[] {
            "Alajuela",
            "Heredia",
            "Cartago",
            "San José",
            "Puntarenas",
            "Guanacaste",
            "Limón",
            ""});
            this.comboProvincias.Location = new System.Drawing.Point(235, 157);
            this.comboProvincias.Name = "comboProvincias";
            this.comboProvincias.Size = new System.Drawing.Size(172, 22);
            this.comboProvincias.TabIndex = 7;
            this.comboProvincias.Text = "Seleccione una Provincia";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProvincia.Location = new System.Drawing.Point(235, 139);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(60, 15);
            this.lblProvincia.TabIndex = 12;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtEmergencia
            // 
            this.txtEmergencia.Location = new System.Drawing.Point(222, 40);
            this.txtEmergencia.Name = "txtEmergencia";
            this.txtEmergencia.Size = new System.Drawing.Size(185, 26);
            this.txtEmergencia.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(19, 40);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(187, 26);
            this.txtTelefono.TabIndex = 10;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCiudad.Location = new System.Drawing.Point(19, 140);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(46, 15);
            this.lblCiudad.TabIndex = 6;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblEmergencia
            // 
            this.lblEmergencia.AutoSize = true;
            this.lblEmergencia.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmergencia.Location = new System.Drawing.Point(222, 22);
            this.lblEmergencia.Name = "lblEmergencia";
            this.lblEmergencia.Size = new System.Drawing.Size(70, 15);
            this.lblEmergencia.TabIndex = 5;
            this.lblEmergencia.Text = "Emergencia";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(17, 22);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(53, 15);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(15, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(144, 15);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "Número de Identificación";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(198, 26);
            this.txtID.TabIndex = 10;
            // 
            // comboTipoID
            // 
            this.comboTipoID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboTipoID.FormattingEnabled = true;
            this.comboTipoID.Items.AddRange(new object[] {
            "Cédula",
            "Dimex",
            "Pasaporte",
            "Permiso Laboral",
            "Otro"});
            this.comboTipoID.Location = new System.Drawing.Point(245, 50);
            this.comboTipoID.Name = "comboTipoID";
            this.comboTipoID.Size = new System.Drawing.Size(200, 22);
            this.comboTipoID.TabIndex = 15;
            this.comboTipoID.Text = "Seleccione el tipo de ID";
            // 
            // lblTipoID
            // 
            this.lblTipoID.AutoSize = true;
            this.lblTipoID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoID.Location = new System.Drawing.Point(245, 29);
            this.lblTipoID.Name = "lblTipoID";
            this.lblTipoID.Size = new System.Drawing.Size(31, 15);
            this.lblTipoID.TabIndex = 14;
            this.lblTipoID.Text = "Tipo";
            // 
            // btnGuardarPaciente
            // 
            this.btnGuardarPaciente.Location = new System.Drawing.Point(1035, 761);
            this.btnGuardarPaciente.Name = "btnGuardarPaciente";
            this.btnGuardarPaciente.Size = new System.Drawing.Size(120, 61);
            this.btnGuardarPaciente.TabIndex = 11;
            this.btnGuardarPaciente.Text = "Guardar";
            this.btnGuardarPaciente.UseVisualStyleBackColor = true;
            this.btnGuardarPaciente.Click += new System.EventHandler(this.btnGuardarPaciente_Click);
            // 
            // btnSalirNPaciente
            // 
            this.btnSalirNPaciente.Location = new System.Drawing.Point(12, 761);
            this.btnSalirNPaciente.Name = "btnSalirNPaciente";
            this.btnSalirNPaciente.Size = new System.Drawing.Size(234, 61);
            this.btnSalirNPaciente.TabIndex = 12;
            this.btnSalirNPaciente.Text = "Salir";
            this.btnSalirNPaciente.UseVisualStyleBackColor = true;
            // 
            // dgrListarPacientes
            // 
            this.dgrListarPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrListarPacientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrListarPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrListarPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paciente_id,
            this.tipo_id,
            this.nombre,
            this.apellidos,
            this.fecha_nacimiento,
            this.genero,
            this.nacionalidad,
            this.correo,
            this.telefono,
            this.ciudad,
            this.provincia,
            this.direccion,
            this.estado_civil,
            this.laborando,
            this.emergencia,
            this.guardian,
            this.asegurado});
            this.dgrListarPacientes.Location = new System.Drawing.Point(12, 439);
            this.dgrListarPacientes.Name = "dgrListarPacientes";
            this.dgrListarPacientes.RowHeadersVisible = false;
            this.dgrListarPacientes.RowTemplate.Height = 25;
            this.dgrListarPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrListarPacientes.Size = new System.Drawing.Size(1143, 304);
            this.dgrListarPacientes.TabIndex = 32;
            // 
            // paciente_id
            // 
            this.paciente_id.DataPropertyName = "Identificacion";
            this.paciente_id.HeaderText = "ID";
            this.paciente_id.Name = "paciente_id";
            // 
            // tipo_id
            // 
            this.tipo_id.DataPropertyName = "Tipo_Id";
            this.tipo_id.HeaderText = "TIPO_ID";
            this.tipo_id.Name = "tipo_id";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            // 
            // apellidos
            // 
            this.apellidos.DataPropertyName = "Apellidos";
            this.apellidos.HeaderText = "APELLIDOS";
            this.apellidos.Name = "apellidos";
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.DataPropertyName = "FechaNacimiento";
            this.fecha_nacimiento.HeaderText = "NACIMIENTO";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            // 
            // genero
            // 
            this.genero.DataPropertyName = "Genero";
            this.genero.HeaderText = "GENERO";
            this.genero.Name = "genero";
            // 
            // nacionalidad
            // 
            this.nacionalidad.DataPropertyName = "Nacionalidad";
            this.nacionalidad.HeaderText = "NACIONALIDAD";
            this.nacionalidad.Name = "nacionalidad";
            // 
            // correo
            // 
            this.correo.DataPropertyName = "Correo";
            this.correo.HeaderText = "CORREO";
            this.correo.Name = "correo";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "TELÉFONO";
            this.telefono.Name = "telefono";
            // 
            // ciudad
            // 
            this.ciudad.DataPropertyName = "Ciudad";
            this.ciudad.HeaderText = "CIUDAD";
            this.ciudad.Name = "ciudad";
            // 
            // provincia
            // 
            this.provincia.DataPropertyName = "Provincia";
            this.provincia.HeaderText = "PROVINCIA";
            this.provincia.Name = "provincia";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "DetalleDireccion";
            this.direccion.HeaderText = "DIRECCIÓN";
            this.direccion.Name = "direccion";
            // 
            // estado_civil
            // 
            this.estado_civil.DataPropertyName = "EstadoCivil";
            this.estado_civil.HeaderText = "EST_CIVIL";
            this.estado_civil.Name = "estado_civil";
            // 
            // laborando
            // 
            this.laborando.DataPropertyName = "Laborando";
            this.laborando.HeaderText = "LABORANDO";
            this.laborando.Name = "laborando";
            // 
            // emergencia
            // 
            this.emergencia.DataPropertyName = "NumeroEmergencia";
            this.emergencia.HeaderText = "EMERGENCIA";
            this.emergencia.Name = "emergencia";
            // 
            // guardian
            // 
            this.guardian.DataPropertyName = "Guardian";
            this.guardian.HeaderText = "GUARDIAN";
            this.guardian.Name = "guardian";
            // 
            // asegurado
            // 
            this.asegurado.DataPropertyName = "Asegurado";
            this.asegurado.HeaderText = "ASEGURADO";
            this.asegurado.Name = "asegurado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHistorialId);
            this.groupBox2.Controls.Add(this.lblHistorial);
            this.groupBox2.Controls.Add(this.lblSoloNum);
            this.groupBox2.Controls.Add(this.lblTipoID);
            this.groupBox2.Controls.Add(this.comboTipoID);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 101);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Identificacar Paciente";
            // 
            // txtHistorialId
            // 
            this.txtHistorialId.Enabled = false;
            this.txtHistorialId.Location = new System.Drawing.Point(476, 50);
            this.txtHistorialId.Name = "txtHistorialId";
            this.txtHistorialId.Size = new System.Drawing.Size(198, 26);
            this.txtHistorialId.TabIndex = 18;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistorial.Location = new System.Drawing.Point(476, 29);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(87, 15);
            this.lblHistorial.TabIndex = 17;
            this.lblHistorial.Text = "ID de Historial";
            // 
            // lblSoloNum
            // 
            this.lblSoloNum.AutoSize = true;
            this.lblSoloNum.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSoloNum.ForeColor = System.Drawing.Color.Red;
            this.lblSoloNum.Location = new System.Drawing.Point(15, 79);
            this.lblSoloNum.Name = "lblSoloNum";
            this.lblSoloNum.Size = new System.Drawing.Size(120, 13);
            this.lblSoloNum.TabIndex = 16;
            this.lblSoloNum.Text = "Solo se aceptan números";
            this.lblSoloNum.Visible = false;
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarPaciente.Location = new System.Drawing.Point(651, 761);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(120, 61);
            this.btnBuscarPaciente.TabIndex = 42;
            this.btnBuscarPaciente.Text = "BUSCAR";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.Location = new System.Drawing.Point(777, 761);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(120, 61);
            this.btnEditarPaciente.TabIndex = 41;
            this.btnEditarPaciente.Text = "EDITAR";
            this.btnEditarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.Location = new System.Drawing.Point(905, 761);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(120, 61);
            this.btnNuevoPaciente.TabIndex = 39;
            this.btnNuevoPaciente.Text = "NUEVO";
            this.btnNuevoPaciente.UseVisualStyleBackColor = true;
            // 
            // Frm_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1163, 843);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.btnEditarPaciente);
            this.Controls.Add(this.btnNuevoPaciente);
            this.Controls.Add(this.dgrListarPacientes);
            this.Controls.Add(this.btnSalirNPaciente);
            this.Controls.Add(this.btnGuardarPaciente);
            this.Controls.Add(this.groupContacto);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.txtNombrePaciente);
            this.Controls.Add(this.lblNombrePaciente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Paciente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelAsegurado.ResumeLayout(false);
            this.panelAsegurado.PerformLayout();
            this.panelLaborando.ResumeLayout(false);
            this.panelLaborando.PerformLayout();
            this.panelGenero.ResumeLayout(false);
            this.panelGenero.PerformLayout();
            this.groupContacto.ResumeLayout(false);
            this.groupContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrListarPacientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.RadioButton radioHombre;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.Panel panelGenero;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.GroupBox groupContacto;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblEmergencia;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEmergencia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox comboProvincias;
        private System.Windows.Forms.ComboBox comboCiudades;
        private System.Windows.Forms.TextBox txtDetallesDireccion;
        private System.Windows.Forms.Label lblDetallesDireccion;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblLaborando;
        private System.Windows.Forms.Panel panelAsegurado;
        private System.Windows.Forms.RadioButton radioAseguradoNo;
        private System.Windows.Forms.RadioButton radioAseguradoSi;
        private System.Windows.Forms.Label lblLarorando;
        private System.Windows.Forms.Panel panelLaborando;
        private System.Windows.Forms.RadioButton radioLaborandoNo;
        private System.Windows.Forms.RadioButton radioLaborandoSi;
        private System.Windows.Forms.TextBox txtGuardian;
        private System.Windows.Forms.Label lblGuardian;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTipoID;
        private System.Windows.Forms.Label lblTipoID;
        private System.Windows.Forms.Button btnGuardarPaciente;
        private System.Windows.Forms.Button btnSalirNPaciente;
        private System.Windows.Forms.DataGridView dgrListarPacientes;
        private System.Windows.Forms.ComboBox comboEstadoCivil;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSoloNum;
        private System.Windows.Forms.Label lblSoloNum3;
        private System.Windows.Forms.Label lblSoloNum2;
        private System.Windows.Forms.Label lblValidarCorreo;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Button btnEditarPaciente;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.TextBox txtHistorialId;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn laborando;
        private System.Windows.Forms.DataGridViewTextBoxColumn emergencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardian;
        private System.Windows.Forms.DataGridViewTextBoxColumn asegurado;
    }
}