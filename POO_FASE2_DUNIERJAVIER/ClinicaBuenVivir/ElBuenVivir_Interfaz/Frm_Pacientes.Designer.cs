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
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            lblApellido1 = new System.Windows.Forms.Label();
            lblApellido2 = new System.Windows.Forms.Label();
            txtApellido1 = new System.Windows.Forms.TextBox();
            txtApellido2 = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtGuardian = new System.Windows.Forms.TextBox();
            lblGuardian = new System.Windows.Forms.Label();
            panelAsegurado = new System.Windows.Forms.Panel();
            radioAseguradoNo = new System.Windows.Forms.RadioButton();
            radioAseguradoSi = new System.Windows.Forms.RadioButton();
            lblLarorando = new System.Windows.Forms.Label();
            panelLaborando = new System.Windows.Forms.Panel();
            radioLaborandoNo = new System.Windows.Forms.RadioButton();
            radioLaborandoSi = new System.Windows.Forms.RadioButton();
            lblLaborando = new System.Windows.Forms.Label();
            panelEstadoCivil = new System.Windows.Forms.Panel();
            radioUnion = new System.Windows.Forms.RadioButton();
            radioSoltero = new System.Windows.Forms.RadioButton();
            radioCasado = new System.Windows.Forms.RadioButton();
            lblEstadoCivil = new System.Windows.Forms.Label();
            txtNacionalidad = new System.Windows.Forms.TextBox();
            lblNacionalidad = new System.Windows.Forms.Label();
            lblGenero = new System.Windows.Forms.Label();
            lblNacimiento = new System.Windows.Forms.Label();
            panelGenero = new System.Windows.Forms.Panel();
            radioMujer = new System.Windows.Forms.RadioButton();
            radioHombre = new System.Windows.Forms.RadioButton();
            dateNacimiento = new System.Windows.Forms.DateTimePicker();
            groupContacto = new System.Windows.Forms.GroupBox();
            txtCorreo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtDetallesDireccion = new System.Windows.Forms.TextBox();
            lblDetallesDireccion = new System.Windows.Forms.Label();
            comboCiudades = new System.Windows.Forms.ComboBox();
            comboProvincias = new System.Windows.Forms.ComboBox();
            lblProvincia = new System.Windows.Forms.Label();
            txtEmergencia = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            lblCiudad = new System.Windows.Forms.Label();
            lblEmergencia = new System.Windows.Forms.Label();
            lblTelefono = new System.Windows.Forms.Label();
            lblID = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            comboTipoID = new System.Windows.Forms.ComboBox();
            lblTipoID = new System.Windows.Forms.Label();
            btnGuardarPaciente = new System.Windows.Forms.Button();
            btnSalirNPaciente = new System.Windows.Forms.Button();
            dgrListarPacientes = new System.Windows.Forms.DataGridView();
            medico_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tipoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            laborando = new System.Windows.Forms.DataGridViewTextBoxColumn();
            emergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            guardian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            asegurado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panelAsegurado.SuspendLayout();
            panelLaborando.SuspendLayout();
            panelEstadoCivil.SuspendLayout();
            panelGenero.SuspendLayout();
            groupContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrListarPacientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombre.Location = new System.Drawing.Point(25, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(50, 14);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(25, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(200, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblApellido1.Location = new System.Drawing.Point(257, 78);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new System.Drawing.Size(92, 14);
            lblApellido1.TabIndex = 2;
            lblApellido1.Text = "Primer Apellido";
            // 
            // lblApellido2
            // 
            lblApellido2.AutoSize = true;
            lblApellido2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblApellido2.Location = new System.Drawing.Point(488, 78);
            lblApellido2.Name = "lblApellido2";
            lblApellido2.Size = new System.Drawing.Size(104, 14);
            lblApellido2.TabIndex = 3;
            lblApellido2.Text = "Segundo Apellido";
            // 
            // txtApellido1
            // 
            txtApellido1.Location = new System.Drawing.Point(257, 96);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new System.Drawing.Size(200, 23);
            txtApellido1.TabIndex = 4;
            // 
            // txtApellido2
            // 
            txtApellido2.Location = new System.Drawing.Point(488, 96);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new System.Drawing.Size(200, 23);
            txtApellido2.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGuardian);
            groupBox1.Controls.Add(lblGuardian);
            groupBox1.Controls.Add(panelAsegurado);
            groupBox1.Controls.Add(lblLarorando);
            groupBox1.Controls.Add(panelLaborando);
            groupBox1.Controls.Add(lblLaborando);
            groupBox1.Controls.Add(panelEstadoCivil);
            groupBox1.Controls.Add(lblEstadoCivil);
            groupBox1.Controls.Add(txtNacionalidad);
            groupBox1.Controls.Add(lblNacionalidad);
            groupBox1.Controls.Add(lblGenero);
            groupBox1.Controls.Add(lblNacimiento);
            groupBox1.Controls.Add(panelGenero);
            groupBox1.Controls.Add(dateNacimiento);
            groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(692, 269);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del paciente";
            // 
            // txtGuardian
            // 
            txtGuardian.Location = new System.Drawing.Point(245, 226);
            txtGuardian.Name = "txtGuardian";
            txtGuardian.Size = new System.Drawing.Size(431, 26);
            txtGuardian.TabIndex = 15;
            // 
            // lblGuardian
            // 
            lblGuardian.AutoSize = true;
            lblGuardian.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGuardian.Location = new System.Drawing.Point(245, 208);
            lblGuardian.Name = "lblGuardian";
            lblGuardian.Size = new System.Drawing.Size(58, 14);
            lblGuardian.TabIndex = 14;
            lblGuardian.Text = "Guardian";
            // 
            // panelAsegurado
            // 
            panelAsegurado.BackColor = System.Drawing.SystemColors.ButtonFace;
            panelAsegurado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelAsegurado.Controls.Add(radioAseguradoNo);
            panelAsegurado.Controls.Add(radioAseguradoSi);
            panelAsegurado.Location = new System.Drawing.Point(15, 225);
            panelAsegurado.Name = "panelAsegurado";
            panelAsegurado.Size = new System.Drawing.Size(200, 26);
            panelAsegurado.TabIndex = 13;
            // 
            // radioAseguradoNo
            // 
            radioAseguradoNo.AutoSize = true;
            radioAseguradoNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioAseguradoNo.Location = new System.Drawing.Point(105, 1);
            radioAseguradoNo.Name = "radioAseguradoNo";
            radioAseguradoNo.Size = new System.Drawing.Size(40, 19);
            radioAseguradoNo.TabIndex = 3;
            radioAseguradoNo.TabStop = true;
            radioAseguradoNo.Text = "No";
            radioAseguradoNo.UseVisualStyleBackColor = true;
            // 
            // radioAseguradoSi
            // 
            radioAseguradoSi.AutoSize = true;
            radioAseguradoSi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioAseguradoSi.Location = new System.Drawing.Point(20, 1);
            radioAseguradoSi.Name = "radioAseguradoSi";
            radioAseguradoSi.Size = new System.Drawing.Size(35, 19);
            radioAseguradoSi.TabIndex = 2;
            radioAseguradoSi.TabStop = true;
            radioAseguradoSi.Text = "Si";
            radioAseguradoSi.UseVisualStyleBackColor = true;
            // 
            // lblLarorando
            // 
            lblLarorando.AutoSize = true;
            lblLarorando.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLarorando.Location = new System.Drawing.Point(15, 207);
            lblLarorando.Name = "lblLarorando";
            lblLarorando.Size = new System.Drawing.Size(65, 15);
            lblLarorando.TabIndex = 12;
            lblLarorando.Text = "Asegurado";
            // 
            // panelLaborando
            // 
            panelLaborando.BackColor = System.Drawing.SystemColors.ButtonFace;
            panelLaborando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelLaborando.Controls.Add(radioLaborandoNo);
            panelLaborando.Controls.Add(radioLaborandoSi);
            panelLaborando.Location = new System.Drawing.Point(476, 165);
            panelLaborando.Name = "panelLaborando";
            panelLaborando.Size = new System.Drawing.Size(200, 26);
            panelLaborando.TabIndex = 11;
            // 
            // radioLaborandoNo
            // 
            radioLaborandoNo.AutoSize = true;
            radioLaborandoNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioLaborandoNo.Location = new System.Drawing.Point(105, 1);
            radioLaborandoNo.Name = "radioLaborandoNo";
            radioLaborandoNo.Size = new System.Drawing.Size(40, 19);
            radioLaborandoNo.TabIndex = 3;
            radioLaborandoNo.TabStop = true;
            radioLaborandoNo.Text = "No";
            radioLaborandoNo.UseVisualStyleBackColor = true;
            // 
            // radioLaborandoSi
            // 
            radioLaborandoSi.AutoSize = true;
            radioLaborandoSi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioLaborandoSi.Location = new System.Drawing.Point(20, 1);
            radioLaborandoSi.Name = "radioLaborandoSi";
            radioLaborandoSi.Size = new System.Drawing.Size(35, 19);
            radioLaborandoSi.TabIndex = 2;
            radioLaborandoSi.TabStop = true;
            radioLaborandoSi.Text = "Si";
            radioLaborandoSi.UseVisualStyleBackColor = true;
            // 
            // lblLaborando
            // 
            lblLaborando.AutoSize = true;
            lblLaborando.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLaborando.Location = new System.Drawing.Point(476, 147);
            lblLaborando.Name = "lblLaborando";
            lblLaborando.Size = new System.Drawing.Size(66, 15);
            lblLaborando.TabIndex = 10;
            lblLaborando.Text = "Laborando";
            // 
            // panelEstadoCivil
            // 
            panelEstadoCivil.BackColor = System.Drawing.SystemColors.ButtonFace;
            panelEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelEstadoCivil.Controls.Add(radioUnion);
            panelEstadoCivil.Controls.Add(radioSoltero);
            panelEstadoCivil.Controls.Add(radioCasado);
            panelEstadoCivil.Location = new System.Drawing.Point(15, 165);
            panelEstadoCivil.Name = "panelEstadoCivil";
            panelEstadoCivil.Size = new System.Drawing.Size(430, 26);
            panelEstadoCivil.TabIndex = 9;
            // 
            // radioUnion
            // 
            radioUnion.AutoSize = true;
            radioUnion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioUnion.Location = new System.Drawing.Point(305, 3);
            radioUnion.Name = "radioUnion";
            radioUnion.Size = new System.Drawing.Size(88, 18);
            radioUnion.TabIndex = 7;
            radioUnion.TabStop = true;
            radioUnion.Text = "Unión Libre";
            radioUnion.UseVisualStyleBackColor = true;
            // 
            // radioSoltero
            // 
            radioSoltero.AutoSize = true;
            radioSoltero.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioSoltero.Location = new System.Drawing.Point(159, 2);
            radioSoltero.Name = "radioSoltero";
            radioSoltero.Size = new System.Drawing.Size(76, 18);
            radioSoltero.TabIndex = 10;
            radioSoltero.TabStop = true;
            radioSoltero.Text = "Soltero/a";
            radioSoltero.UseVisualStyleBackColor = true;
            // 
            // radioCasado
            // 
            radioCasado.AutoSize = true;
            radioCasado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioCasado.Location = new System.Drawing.Point(19, 2);
            radioCasado.Name = "radioCasado";
            radioCasado.Size = new System.Drawing.Size(77, 18);
            radioCasado.TabIndex = 0;
            radioCasado.TabStop = true;
            radioCasado.Text = "Casado/a";
            radioCasado.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEstadoCivil.Location = new System.Drawing.Point(13, 147);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new System.Drawing.Size(72, 15);
            lblEstadoCivil.TabIndex = 8;
            lblEstadoCivil.Text = "Estado Civil";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new System.Drawing.Point(476, 105);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new System.Drawing.Size(200, 26);
            txtNacionalidad.TabIndex = 7;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNacionalidad.Location = new System.Drawing.Point(476, 87);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new System.Drawing.Size(82, 15);
            lblNacionalidad.TabIndex = 6;
            lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGenero.Location = new System.Drawing.Point(245, 87);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new System.Drawing.Size(46, 15);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Genero";
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNacimiento.Location = new System.Drawing.Point(13, 87);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new System.Drawing.Size(121, 15);
            lblNacimiento.TabIndex = 1;
            lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // panelGenero
            // 
            panelGenero.BackColor = System.Drawing.SystemColors.ButtonFace;
            panelGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelGenero.Controls.Add(radioMujer);
            panelGenero.Controls.Add(radioHombre);
            panelGenero.Location = new System.Drawing.Point(245, 105);
            panelGenero.Name = "panelGenero";
            panelGenero.Size = new System.Drawing.Size(200, 23);
            panelGenero.TabIndex = 4;
            // 
            // radioMujer
            // 
            radioMujer.AutoSize = true;
            radioMujer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioMujer.Location = new System.Drawing.Point(105, 1);
            radioMujer.Name = "radioMujer";
            radioMujer.Size = new System.Drawing.Size(58, 19);
            radioMujer.TabIndex = 3;
            radioMujer.TabStop = true;
            radioMujer.Text = "Mujer";
            radioMujer.UseVisualStyleBackColor = true;
            // 
            // radioHombre
            // 
            radioHombre.AutoSize = true;
            radioHombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioHombre.Location = new System.Drawing.Point(20, 1);
            radioHombre.Name = "radioHombre";
            radioHombre.Size = new System.Drawing.Size(68, 19);
            radioHombre.TabIndex = 2;
            radioHombre.TabStop = true;
            radioHombre.Text = "Hombre";
            radioHombre.UseVisualStyleBackColor = true;
            // 
            // dateNacimiento
            // 
            dateNacimiento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateNacimiento.Location = new System.Drawing.Point(13, 105);
            dateNacimiento.Name = "dateNacimiento";
            dateNacimiento.Size = new System.Drawing.Size(200, 23);
            dateNacimiento.TabIndex = 0;
            // 
            // groupContacto
            // 
            groupContacto.Controls.Add(txtCorreo);
            groupContacto.Controls.Add(label1);
            groupContacto.Controls.Add(txtDetallesDireccion);
            groupContacto.Controls.Add(lblDetallesDireccion);
            groupContacto.Controls.Add(comboCiudades);
            groupContacto.Controls.Add(comboProvincias);
            groupContacto.Controls.Add(lblProvincia);
            groupContacto.Controls.Add(txtEmergencia);
            groupContacto.Controls.Add(txtTelefono);
            groupContacto.Controls.Add(lblCiudad);
            groupContacto.Controls.Add(lblEmergencia);
            groupContacto.Controls.Add(lblTelefono);
            groupContacto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupContacto.Location = new System.Drawing.Point(710, 19);
            groupContacto.Name = "groupContacto";
            groupContacto.Size = new System.Drawing.Size(462, 334);
            groupContacto.TabIndex = 7;
            groupContacto.TabStop = false;
            groupContacto.Text = "Datos de contacto";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new System.Drawing.Point(15, 105);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new System.Drawing.Size(431, 26);
            txtCorreo.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 87);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 15);
            label1.TabIndex = 16;
            label1.Text = "Correo";
            // 
            // txtDetallesDireccion
            // 
            txtDetallesDireccion.Location = new System.Drawing.Point(17, 224);
            txtDetallesDireccion.Multiline = true;
            txtDetallesDireccion.Name = "txtDetallesDireccion";
            txtDetallesDireccion.Size = new System.Drawing.Size(428, 89);
            txtDetallesDireccion.TabIndex = 15;
            // 
            // lblDetallesDireccion
            // 
            lblDetallesDireccion.AutoSize = true;
            lblDetallesDireccion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDetallesDireccion.Location = new System.Drawing.Point(15, 206);
            lblDetallesDireccion.Name = "lblDetallesDireccion";
            lblDetallesDireccion.Size = new System.Drawing.Size(123, 15);
            lblDetallesDireccion.TabIndex = 14;
            lblDetallesDireccion.Text = "Detalles de dirección";
            // 
            // comboCiudades
            // 
            comboCiudades.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboCiudades.FormattingEnabled = true;
            comboCiudades.Items.AddRange(new object[] { "Abangares", "Acosta", "Aguirre", "Alajuela", "Alajuelita", "Alvarado", "Aserrí", "Atenas", "Bagaces", "Barva", "Belén", "Buenos Aires", "Cañas", "Carrillo", "Cartago", "Corredores", "Coto Brus", "Curridabat", "Desamparados", "Dota", "El Guarco", "Escazú", "Esparza", "Flores", "Garabito", "Goicoechea", "Golfito", "Grecia", "Guácimo", "Guatuso", "Heredia", "Hojancha", "Jiménez", "La Cruz", "La Unión", "León Cortés Castro", "Liberia", "Limón", "Los Chiles", "Matina", "Montes de Oro", "Montes de Oca", "Mora", "Moravia", "Nandayure", "Naranjo", "Nicoya", "Oreamuno", "Orotina", "Osa", "Palmares", "Paraíso", "Parrita", "Pérez Zeledón", "Poás", "Pococí", "Puntarenas", "Puriscal", "Quepos", "Río Cuarto", "San Carlos", "San Isidro", "San José", "San Mateo", "San Pablo", "San Rafael", "San Ramón", "San Vito", "Santa Ana", "Santa Bárbara", "Santa Cruz", "Santa María", "Santo Domingo", "Sarapiquí", "Sarchí", "Siquirres", "Talamanca", "Tarrazú", "Tibás", "Tilarán", "Turrialba", "Upala" });
            comboCiudades.Location = new System.Drawing.Point(15, 165);
            comboCiudades.Name = "comboCiudades";
            comboCiudades.Size = new System.Drawing.Size(200, 22);
            comboCiudades.TabIndex = 13;
            comboCiudades.Text = "Seleccione una Ciudad";
            // 
            // comboProvincias
            // 
            comboProvincias.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboProvincias.FormattingEnabled = true;
            comboProvincias.Items.AddRange(new object[] { "Alajuela", "Heredia", "Cartago", "San José", "Puntarenas", "Guanacaste", "Limón", "" });
            comboProvincias.Location = new System.Drawing.Point(246, 165);
            comboProvincias.Name = "comboProvincias";
            comboProvincias.Size = new System.Drawing.Size(200, 22);
            comboProvincias.TabIndex = 7;
            comboProvincias.Text = "Seleccione una Provincia";
            // 
            // lblProvincia
            // 
            lblProvincia.AutoSize = true;
            lblProvincia.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblProvincia.Location = new System.Drawing.Point(246, 146);
            lblProvincia.Name = "lblProvincia";
            lblProvincia.Size = new System.Drawing.Size(60, 15);
            lblProvincia.TabIndex = 12;
            lblProvincia.Text = "Provincia";
            // 
            // txtEmergencia
            // 
            txtEmergencia.Location = new System.Drawing.Point(245, 47);
            txtEmergencia.Name = "txtEmergencia";
            txtEmergencia.Size = new System.Drawing.Size(201, 26);
            txtEmergencia.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(15, 47);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(200, 26);
            txtTelefono.TabIndex = 10;
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCiudad.Location = new System.Drawing.Point(15, 147);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new System.Drawing.Size(46, 15);
            lblCiudad.TabIndex = 6;
            lblCiudad.Text = "Ciudad";
            // 
            // lblEmergencia
            // 
            lblEmergencia.AutoSize = true;
            lblEmergencia.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEmergencia.Location = new System.Drawing.Point(245, 29);
            lblEmergencia.Name = "lblEmergencia";
            lblEmergencia.Size = new System.Drawing.Size(70, 15);
            lblEmergencia.TabIndex = 5;
            lblEmergencia.Text = "Emergencia";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTelefono.Location = new System.Drawing.Point(13, 29);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(53, 15);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Teléfono";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new System.Drawing.Point(16, 19);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(142, 15);
            lblID.TabIndex = 9;
            lblID.Text = "Número de Identificación";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(164, 12);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(185, 23);
            txtID.TabIndex = 10;
            // 
            // comboTipoID
            // 
            comboTipoID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboTipoID.FormattingEnabled = true;
            comboTipoID.Items.AddRange(new object[] { "Cédula", "Dimex", "Pasaporte", "Permiso Laboral", "Otro" });
            comboTipoID.Location = new System.Drawing.Point(503, 13);
            comboTipoID.Name = "comboTipoID";
            comboTipoID.Size = new System.Drawing.Size(185, 22);
            comboTipoID.TabIndex = 15;
            comboTipoID.Text = "Seleccione el tipo de ID";
            // 
            // lblTipoID
            // 
            lblTipoID.AutoSize = true;
            lblTipoID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTipoID.Location = new System.Drawing.Point(372, 19);
            lblTipoID.Name = "lblTipoID";
            lblTipoID.Size = new System.Drawing.Size(125, 15);
            lblTipoID.TabIndex = 14;
            lblTipoID.Text = "Tipo de Identificación";
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.Location = new System.Drawing.Point(942, 338);
            btnGuardarPaciente.Name = "btnGuardarPaciente";
            btnGuardarPaciente.Size = new System.Drawing.Size(185, 45);
            btnGuardarPaciente.TabIndex = 11;
            btnGuardarPaciente.Text = "Guardar";
            btnGuardarPaciente.UseVisualStyleBackColor = true;
            btnGuardarPaciente.Click += btnGuardarPaciente_Click;
            // 
            // btnSalirNPaciente
            // 
            btnSalirNPaciente.Location = new System.Drawing.Point(751, 359);
            btnSalirNPaciente.Name = "btnSalirNPaciente";
            btnSalirNPaciente.Size = new System.Drawing.Size(185, 45);
            btnSalirNPaciente.TabIndex = 12;
            btnSalirNPaciente.Text = "Salir";
            btnSalirNPaciente.UseVisualStyleBackColor = true;
            btnSalirNPaciente.Click += btnSalirNPaciente_Click;
            // 
            // dgrListarPacientes
            // 
            dgrListarPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgrListarPacientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dgrListarPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrListarPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { medico_id, tipoid, nombre_medico, apellidos, fecha_nacimiento, genero, nacionalidad, correo, telefono, ciudad, provincia, direccion, estado_civil, laborando, emergencia, guardian, asegurado });
            dgrListarPacientes.Location = new System.Drawing.Point(12, 448);
            dgrListarPacientes.Name = "dgrListarPacientes";
            dgrListarPacientes.RowTemplate.Height = 25;
            dgrListarPacientes.Size = new System.Drawing.Size(1143, 322);
            dgrListarPacientes.TabIndex = 32;
            // 
            // medico_id
            // 
            medico_id.DataPropertyName = "Identificacion";
            medico_id.HeaderText = "ID";
            medico_id.Name = "medico_id";
            // 
            // tipoid
            // 
            tipoid.DataPropertyName = "Tipo_Id";
            tipoid.HeaderText = "TIPO_ID";
            tipoid.Name = "tipoid";
            // 
            // nombre_medico
            // 
            nombre_medico.DataPropertyName = "Nombre";
            nombre_medico.HeaderText = "NOMBRE";
            nombre_medico.Name = "nombre_medico";
            // 
            // apellidos
            // 
            apellidos.DataPropertyName = "Apellidos";
            apellidos.HeaderText = "APELLIDOS";
            apellidos.Name = "apellidos";
            // 
            // fecha_nacimiento
            // 
            fecha_nacimiento.DataPropertyName = "FechaNacimiento";
            fecha_nacimiento.HeaderText = "NACIMIENTO";
            fecha_nacimiento.Name = "fecha_nacimiento";
            // 
            // genero
            // 
            genero.DataPropertyName = "Genero";
            genero.HeaderText = "GENERO";
            genero.Name = "genero";
            // 
            // nacionalidad
            // 
            nacionalidad.DataPropertyName = "Nacionalidad";
            nacionalidad.HeaderText = "NACIONALIDAD";
            nacionalidad.Name = "nacionalidad";
            // 
            // correo
            // 
            correo.DataPropertyName = "Correo";
            correo.HeaderText = "CORREO";
            correo.Name = "correo";
            // 
            // telefono
            // 
            telefono.DataPropertyName = "Telefono";
            telefono.HeaderText = "TELÉFONO";
            telefono.Name = "telefono";
            // 
            // ciudad
            // 
            ciudad.DataPropertyName = "Ciudad";
            ciudad.HeaderText = "CIUDAD";
            ciudad.Name = "ciudad";
            // 
            // provincia
            // 
            provincia.DataPropertyName = "Provincia";
            provincia.HeaderText = "PROVINCIA";
            provincia.Name = "provincia";
            // 
            // direccion
            // 
            direccion.DataPropertyName = "DetalleDireccion";
            direccion.HeaderText = "DIRECCIÓN";
            direccion.Name = "direccion";
            // 
            // estado_civil
            // 
            estado_civil.DataPropertyName = "EstadoCivil";
            estado_civil.HeaderText = "EST_CIVIL";
            estado_civil.Name = "estado_civil";
            // 
            // laborando
            // 
            laborando.DataPropertyName = "Laborando";
            laborando.HeaderText = "LABORANDO";
            laborando.Name = "laborando";
            // 
            // emergencia
            // 
            emergencia.DataPropertyName = "NumeroEmergencia";
            emergencia.HeaderText = "EMERGENCIA";
            emergencia.Name = "emergencia";
            // 
            // guardian
            // 
            guardian.DataPropertyName = "Guardian";
            guardian.HeaderText = "GUARDIAN";
            guardian.Name = "guardian";
            // 
            // asegurado
            // 
            asegurado.DataPropertyName = "Asegurado";
            asegurado.HeaderText = "ASEGURADO";
            asegurado.Name = "asegurado";
            // 
            // Frm_Pacientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1163, 813);
            Controls.Add(dgrListarPacientes);
            Controls.Add(btnSalirNPaciente);
            Controls.Add(comboTipoID);
            Controls.Add(btnGuardarPaciente);
            Controls.Add(lblTipoID);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(groupContacto);
            Controls.Add(txtApellido2);
            Controls.Add(txtApellido1);
            Controls.Add(lblApellido2);
            Controls.Add(lblApellido1);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(groupBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Pacientes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Nuevo Paciente";
            Load += Frm_Pacientes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelAsegurado.ResumeLayout(false);
            panelAsegurado.PerformLayout();
            panelLaborando.ResumeLayout(false);
            panelLaborando.PerformLayout();
            panelEstadoCivil.ResumeLayout(false);
            panelEstadoCivil.PerformLayout();
            panelGenero.ResumeLayout(false);
            panelGenero.PerformLayout();
            groupContacto.ResumeLayout(false);
            groupContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrListarPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.RadioButton radioHombre;
        private System.Windows.Forms.RadioButton radioMujer;
        private System.Windows.Forms.Panel panelGenero;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Panel panelEstadoCivil;
        private System.Windows.Forms.RadioButton radioUnion;
        private System.Windows.Forms.RadioButton radioSoltero;
        private System.Windows.Forms.RadioButton radioCasado;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn medico_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_medico;
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