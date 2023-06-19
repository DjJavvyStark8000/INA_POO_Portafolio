namespace ElBuenVivir_Interfaz
{
    partial class Frm_Diagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Diagnostico));
            groupDiagnostico = new System.Windows.Forms.GroupBox();
            txtDosis = new System.Windows.Forms.TextBox();
            lblDosis = new System.Windows.Forms.Label();
            comboTratamiento = new System.Windows.Forms.ComboBox();
            lblTratamiento = new System.Windows.Forms.Label();
            lblDetallesDiagnostico = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            comboDiagnostico = new System.Windows.Forms.ComboBox();
            btnGuardarDosisSalir = new System.Windows.Forms.Button();
            lblDiagnosticoTitle = new System.Windows.Forms.Label();
            groupDiagnostico.SuspendLayout();
            SuspendLayout();
            // 
            // groupDiagnostico
            // 
            groupDiagnostico.Controls.Add(lblDiagnosticoTitle);
            groupDiagnostico.Controls.Add(txtDosis);
            groupDiagnostico.Controls.Add(lblDosis);
            groupDiagnostico.Controls.Add(comboTratamiento);
            groupDiagnostico.Controls.Add(lblTratamiento);
            groupDiagnostico.Controls.Add(lblDetallesDiagnostico);
            groupDiagnostico.Controls.Add(textBox1);
            groupDiagnostico.Controls.Add(comboDiagnostico);
            groupDiagnostico.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupDiagnostico.Location = new System.Drawing.Point(12, 12);
            groupDiagnostico.Name = "groupDiagnostico";
            groupDiagnostico.Size = new System.Drawing.Size(707, 289);
            groupDiagnostico.TabIndex = 13;
            groupDiagnostico.TabStop = false;
            groupDiagnostico.Text = "Diagnóstico del Paciente";
            // 
            // txtDosis
            // 
            txtDosis.Location = new System.Drawing.Point(13, 156);
            txtDosis.Multiline = true;
            txtDosis.Name = "txtDosis";
            txtDosis.Size = new System.Drawing.Size(324, 116);
            txtDosis.TabIndex = 20;
            // 
            // lblDosis
            // 
            lblDosis.AutoSize = true;
            lblDosis.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDosis.Location = new System.Drawing.Point(13, 139);
            lblDosis.Name = "lblDosis";
            lblDosis.Size = new System.Drawing.Size(38, 14);
            lblDosis.TabIndex = 19;
            lblDosis.Text = "Dosis";
            // 
            // comboTratamiento
            // 
            comboTratamiento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboTratamiento.FormattingEnabled = true;
            comboTratamiento.Location = new System.Drawing.Point(13, 102);
            comboTratamiento.Name = "comboTratamiento";
            comboTratamiento.Size = new System.Drawing.Size(324, 22);
            comboTratamiento.TabIndex = 18;
            comboTratamiento.Text = "Seleccione un Medicamento";
            // 
            // lblTratamiento
            // 
            lblTratamiento.AutoSize = true;
            lblTratamiento.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTratamiento.Location = new System.Drawing.Point(13, 85);
            lblTratamiento.Name = "lblTratamiento";
            lblTratamiento.Size = new System.Drawing.Size(73, 14);
            lblTratamiento.TabIndex = 17;
            lblTratamiento.Text = "Tratamiento";
            // 
            // lblDetallesDiagnostico
            // 
            lblDetallesDiagnostico.AutoSize = true;
            lblDetallesDiagnostico.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDetallesDiagnostico.Location = new System.Drawing.Point(371, 31);
            lblDetallesDiagnostico.Name = "lblDetallesDiagnostico";
            lblDetallesDiagnostico.Size = new System.Drawing.Size(134, 14);
            lblDetallesDiagnostico.TabIndex = 16;
            lblDetallesDiagnostico.Text = "Detalles del diagóstico";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(371, 48);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(324, 224);
            textBox1.TabIndex = 15;
            // 
            // comboDiagnostico
            // 
            comboDiagnostico.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboDiagnostico.FormattingEnabled = true;
            comboDiagnostico.Items.AddRange(new object[] { "Diabetes mellitus", "Hipertensión arterial", "Asma", "Artritis reumatoide", "Enfermedad de Alzheimer", "Enfermedad de Parkinson", "Enfermedad pulmonar obstructiva crónica (EPOC)", "Cáncer de mama", "Cáncer de pulmón", "Infarto de miocardio", "Accidente cerebrovascular (ACV)", "Insuficiencia cardíaca congestiva", "Hipotiroidismo", "Hipertiroidismo", "Anemia ferropénica", "Leucemia", "Esclerosis múltiple", "Enfermedad de Crohn", "Colitis ulcerosa", "Gota", "Enfermedad celíaca", "Fibromialgia", "Trastorno de ansiedad", "Depresión mayor", "Esquizofrenia", "Trastorno bipolar", "Trastorno por déficit de atención e hiperactividad (TDAH)", "Migraña", "Epilepsia", "Enfermedad renal crónica", "Hipotiroidismo congénito", "Cirrosis hepática", "Enfermedad inflamatoria pélvica (EIP)", "Enfermedad de Lyme", "Síndrome de Down", "Síndrome de apnea del sueño", "Lupus eritematoso sistémico", "Anorexia nerviosa", "Bulimia nerviosa", "Úlcera péptica", "Enfermedad renal poliquística", "Psoriasis", "Enfermedad de Raynaud", "Enfermedad de Hashimoto", "Hipoglucemia", "Enfermedad de Wilson", "Pancreatitis", "Enfermedad de Addison", "Enfermedad inflamatoria intestinal", "Endometriosis", "Fiebre reumática", "Herpes zóster", "Hipertrofia prostática benigna", "Esclerosis lateral amiotrófica (ELA)", "Enfermedad de Graves", "Enfermedad pulmonar intersticial", "Síndrome metabólico", "Infección del tracto urinario", "Enfermedad del hígado graso no alcohólico (EHGNA)", "Enfermedad arterial periférica", "Hemofilia", "Síndrome de Guillain-Barré", "Espondilitis anquilosante", "Síndrome nefrótico", "Enfermedad de Gaucher", "Síndrome de Sjögren", "Esclerodermia", "Enfermedad de Meniere", "Enfermedad de Cushing", "Enfermedad de Huntington", "Enfermedad de von Willebrand", "Leucemia linfoblástica aguda", "Enfermedad inflamatoria de las articulaciones", "Neuropatía diabética", "Enfermedad pulmonar fibrosa", "Neumonía", "Leucemia mieloide crónica", "Enfermedad de Hirschsprung", "Anemia aplásica", "Leucemia linfocítica crónica", "Enfermedad de Buerger", "Enfermedad de Kawasaki", "Displasia de cadera", "Glaucoma", "Enfermedad de Von Hippel-Lindau", "Enfermedad de Behçet", "Esplenomegalia", "Pólipos del colon", "Síndrome del intestino irritable", "Linfoma de Hodgkin", "Artrosis", "Enfermedad de Paget", "Hipertensión pulmonar", "Enfermedad de las encías", "Púrpura trombocitopénica idiopática", "Hiperplasia prostática benigna", "Trombosis venosa profunda", "Síndrome de Turner", "Enfermedad de Wilson", "Insuficiencia renal aguda" });
            comboDiagnostico.Location = new System.Drawing.Point(13, 48);
            comboDiagnostico.Name = "comboDiagnostico";
            comboDiagnostico.Size = new System.Drawing.Size(324, 22);
            comboDiagnostico.TabIndex = 14;
            comboDiagnostico.Text = "Seleccione una Condición";
            // 
            // btnGuardarDosisSalir
            // 
            btnGuardarDosisSalir.Location = new System.Drawing.Point(556, 309);
            btnGuardarDosisSalir.Name = "btnGuardarDosisSalir";
            btnGuardarDosisSalir.Size = new System.Drawing.Size(151, 28);
            btnGuardarDosisSalir.TabIndex = 14;
            btnGuardarDosisSalir.Text = "Guardar y Salir";
            btnGuardarDosisSalir.UseVisualStyleBackColor = true;
            // 
            // lblDiagnosticoTitle
            // 
            lblDiagnosticoTitle.AutoSize = true;
            lblDiagnosticoTitle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDiagnosticoTitle.Location = new System.Drawing.Point(13, 31);
            lblDiagnosticoTitle.Name = "lblDiagnosticoTitle";
            lblDiagnosticoTitle.Size = new System.Drawing.Size(73, 14);
            lblDiagnosticoTitle.TabIndex = 21;
            lblDiagnosticoTitle.Text = "Tratamiento";
            // 
            // Frm_Diagnostico
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(729, 344);
            Controls.Add(btnGuardarDosisSalir);
            Controls.Add(groupDiagnostico);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Diagnostico";
            Text = "Diagnóstico Médico";
            groupDiagnostico.ResumeLayout(false);
            groupDiagnostico.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupDiagnostico;
        private System.Windows.Forms.ComboBox comboDiagnostico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDetallesDiagnostico;
        private System.Windows.Forms.Label lblDosis;
        private System.Windows.Forms.ComboBox comboTratamiento;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.TextBox txtDosis;
        private System.Windows.Forms.Button btnGuardarDosisSalir;
        private System.Windows.Forms.Label lblDiagnosticoTitle;
    }
}