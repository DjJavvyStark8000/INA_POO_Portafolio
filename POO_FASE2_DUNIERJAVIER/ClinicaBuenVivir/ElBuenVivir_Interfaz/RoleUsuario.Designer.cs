namespace ElBuenVivir_Interfaz
{
    partial class RoleUsuario
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
            comboFuncionario = new System.Windows.Forms.ComboBox();
            comboRoles = new System.Windows.Forms.ComboBox();
            lblUsuario = new System.Windows.Forms.Label();
            lblRole = new System.Windows.Forms.Label();
            btnIngresar = new System.Windows.Forms.Button();
            lblClave = new System.Windows.Forms.Label();
            txtClave = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // comboFuncionario
            // 
            comboFuncionario.FormattingEnabled = true;
            comboFuncionario.Location = new System.Drawing.Point(47, 113);
            comboFuncionario.Name = "comboFuncionario";
            comboFuncionario.Size = new System.Drawing.Size(211, 23);
            comboFuncionario.TabIndex = 3;
            comboFuncionario.SelectedIndexChanged += comboFuncionario_SelectedIndexChanged_1;
            // 
            // comboRoles
            // 
            comboRoles.FormattingEnabled = true;
            comboRoles.Items.AddRange(new object[] { "Admin", "Médico", "Funcionario" });
            comboRoles.Location = new System.Drawing.Point(47, 60);
            comboRoles.Name = "comboRoles";
            comboRoles.Size = new System.Drawing.Size(211, 23);
            comboRoles.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new System.Drawing.Point(47, 95);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(47, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new System.Drawing.Point(47, 42);
            lblRole.Name = "lblRole";
            lblRole.Size = new System.Drawing.Size(24, 15);
            lblRole.TabIndex = 6;
            lblRole.Text = "Rol";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new System.Drawing.Point(47, 220);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(211, 39);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new System.Drawing.Point(47, 145);
            lblClave.Name = "lblClave";
            lblClave.Size = new System.Drawing.Size(36, 15);
            lblClave.TabIndex = 9;
            lblClave.Text = "Clave";
            // 
            // txtClave
            // 
            txtClave.Enabled = false;
            txtClave.Location = new System.Drawing.Point(47, 163);
            txtClave.Name = "txtClave";
            txtClave.Size = new System.Drawing.Size(211, 23);
            txtClave.TabIndex = 10;
            txtClave.Text = "1234";
            // 
            // RoleUsuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(302, 306);
            Controls.Add(txtClave);
            Controls.Add(lblClave);
            Controls.Add(btnIngresar);
            Controls.Add(lblRole);
            Controls.Add(lblUsuario);
            Controls.Add(comboRoles);
            Controls.Add(comboFuncionario);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RoleUsuario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ACCESO DE USUARIO";
            Load += RollUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox comboFuncionario;
        private System.Windows.Forms.ComboBox comboRoles;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
    }
}