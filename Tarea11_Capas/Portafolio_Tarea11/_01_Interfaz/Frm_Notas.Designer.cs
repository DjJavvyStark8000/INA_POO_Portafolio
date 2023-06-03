namespace _01_Interfaz
{
    partial class Frm_Notas
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
            groupTitulo = new System.Windows.Forms.GroupBox();
            btnVerResultado = new System.Windows.Forms.Button();
            pnlDivisor2 = new System.Windows.Forms.Panel();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            txtSeleccion = new System.Windows.Forms.TextBox();
            lblNotaSeleccionada = new System.Windows.Forms.Label();
            pnlDivisor = new System.Windows.Forms.Panel();
            listNotas = new System.Windows.Forms.ListView();
            btnAgregar = new System.Windows.Forms.Button();
            txtDigitaNota = new System.Windows.Forms.TextBox();
            lblResultado = new System.Windows.Forms.Label();
            lblDigiteNota = new System.Windows.Forms.Label();
            btnSalir = new System.Windows.Forms.Button();
            groupTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // groupTitulo
            // 
            groupTitulo.Controls.Add(btnVerResultado);
            groupTitulo.Controls.Add(pnlDivisor2);
            groupTitulo.Controls.Add(btnLimpiar);
            groupTitulo.Controls.Add(btnEliminar);
            groupTitulo.Controls.Add(txtSeleccion);
            groupTitulo.Controls.Add(lblNotaSeleccionada);
            groupTitulo.Controls.Add(pnlDivisor);
            groupTitulo.Controls.Add(listNotas);
            groupTitulo.Controls.Add(btnAgregar);
            groupTitulo.Controls.Add(txtDigitaNota);
            groupTitulo.Controls.Add(lblResultado);
            groupTitulo.Controls.Add(lblDigiteNota);
            groupTitulo.Location = new System.Drawing.Point(12, 17);
            groupTitulo.Name = "groupTitulo";
            groupTitulo.Size = new System.Drawing.Size(502, 287);
            groupTitulo.TabIndex = 0;
            groupTitulo.TabStop = false;
            groupTitulo.Text = "Registro de Notas";
            // 
            // btnVerResultado
            // 
            btnVerResultado.Location = new System.Drawing.Point(152, 186);
            btnVerResultado.Name = "btnVerResultado";
            btnVerResultado.Size = new System.Drawing.Size(131, 23);
            btnVerResultado.TabIndex = 11;
            btnVerResultado.Text = "Ver Resultado";
            btnVerResultado.UseVisualStyleBackColor = true;
            btnVerResultado.Click += btnVerResultado_Click;
            // 
            // pnlDivisor2
            // 
            pnlDivisor2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            pnlDivisor2.Location = new System.Drawing.Point(7, 169);
            pnlDivisor2.Name = "pnlDivisor2";
            pnlDivisor2.Size = new System.Drawing.Size(276, 2);
            pnlDivisor2.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(6, 133);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(185, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar Lista de Notas";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(6, 104);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(185, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar Seleccionado";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtSeleccion
            // 
            txtSeleccion.Enabled = false;
            txtSeleccion.Location = new System.Drawing.Point(183, 71);
            txtSeleccion.Name = "txtSeleccion";
            txtSeleccion.ReadOnly = true;
            txtSeleccion.Size = new System.Drawing.Size(100, 23);
            txtSeleccion.TabIndex = 7;
            // 
            // lblNotaSeleccionada
            // 
            lblNotaSeleccionada.AutoSize = true;
            lblNotaSeleccionada.Location = new System.Drawing.Point(6, 74);
            lblNotaSeleccionada.Name = "lblNotaSeleccionada";
            lblNotaSeleccionada.Size = new System.Drawing.Size(105, 15);
            lblNotaSeleccionada.TabIndex = 6;
            lblNotaSeleccionada.Text = "Nota Seleccionada";
            // 
            // pnlDivisor
            // 
            pnlDivisor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            pnlDivisor.Location = new System.Drawing.Point(6, 58);
            pnlDivisor.Name = "pnlDivisor";
            pnlDivisor.Size = new System.Drawing.Size(277, 2);
            pnlDivisor.TabIndex = 5;
            // 
            // listNotas
            // 
            listNotas.HideSelection = false;
            listNotas.Location = new System.Drawing.Point(289, 27);
            listNotas.MultiSelect = false;
            listNotas.Name = "listNotas";
            listNotas.Size = new System.Drawing.Size(207, 253);
            listNotas.TabIndex = 4;
            listNotas.UseCompatibleStateImageBehavior = false;
            listNotas.View = System.Windows.Forms.View.List;
            listNotas.SelectedIndexChanged += listNotas_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(208, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 24);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDigitaNota
            // 
            txtDigitaNota.Location = new System.Drawing.Point(91, 27);
            txtDigitaNota.MaxLength = 3;
            txtDigitaNota.Name = "txtDigitaNota";
            txtDigitaNota.Size = new System.Drawing.Size(100, 23);
            txtDigitaNota.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = System.Drawing.SystemColors.ButtonFace;
            lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblResultado.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblResultado.Location = new System.Drawing.Point(7, 218);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new System.Drawing.Size(276, 62);
            lblResultado.TabIndex = 1;
            lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDigiteNota
            // 
            lblDigiteNota.AutoSize = true;
            lblDigiteNota.Location = new System.Drawing.Point(6, 35);
            lblDigiteNota.Name = "lblDigiteNota";
            lblDigiteNota.Size = new System.Drawing.Size(79, 15);
            lblDigiteNota.TabIndex = 0;
            lblDigiteNota.Text = "Digite la Nota";
            // 
            // btnSalir
            // 
            btnSalir.Location = new System.Drawing.Point(439, 311);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Frm_Notas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(526, 346);
            Controls.Add(btnSalir);
            Controls.Add(groupTitulo);
            Name = "Frm_Notas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Registro de Notas";
            Load += Frm_Notas_Load;
            groupTitulo.ResumeLayout(false);
            groupTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupTitulo;
        private System.Windows.Forms.Panel pnlDivisor;
        private System.Windows.Forms.ListView listNotas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDigitaNota;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblDigiteNota;
        private System.Windows.Forms.TextBox txtSeleccion;
        private System.Windows.Forms.Label lblNotaSeleccionada;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerResultado;
        private System.Windows.Forms.Panel pnlDivisor2;
        private System.Windows.Forms.Button btnSalir;
    }
}