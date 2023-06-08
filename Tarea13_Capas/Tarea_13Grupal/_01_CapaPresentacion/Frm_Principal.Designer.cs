namespace _01_CapaPresentacion
{
    partial class Frm_Principal
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            accesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { accesarToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(730, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // accesarToolStripMenuItem
            // 
            accesarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { clientesToolStripMenuItem, productosToolStripMenuItem, facturacionToolStripMenuItem });
            accesarToolStripMenuItem.Name = "accesarToolStripMenuItem";
            accesarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            accesarToolStripMenuItem.Text = "Accesar";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // facturacionToolStripMenuItem
            // 
            facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            facturacionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            facturacionToolStripMenuItem.Text = "Facturacion";
            facturacionToolStripMenuItem.Click += facturacionToolStripMenuItem_Click;
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(730, 508);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Frm_Principal";
            Text = "Frm_Principal";
            Load += Frm_Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accesarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
    }
}