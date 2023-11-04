namespace Sistema
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.subMenuColsultarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRegistrarusuario = new System.Windows.Forms.ToolStripMenuItem();
            this.colsultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.menuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuColsultarUsuarios,
            this.menuConfiguracion,
            this.menuCerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // subMenuColsultarUsuarios
            // 
            this.subMenuColsultarUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarusuario,
            this.colsultarToolStripMenuItem});
            this.subMenuColsultarUsuarios.Name = "subMenuColsultarUsuarios";
            this.subMenuColsultarUsuarios.Size = new System.Drawing.Size(164, 20);
            this.subMenuColsultarUsuarios.Text = "Administracion de Usuarios";
            this.subMenuColsultarUsuarios.Click += new System.EventHandler(this.administracionUsuariosToolStripMenuItem_Click);
            // 
            // subMenuRegistrarusuario
            // 
            this.subMenuRegistrarusuario.Name = "subMenuRegistrarusuario";
            this.subMenuRegistrarusuario.Size = new System.Drawing.Size(121, 22);
            this.subMenuRegistrarusuario.Text = "Registrar";
            this.subMenuRegistrarusuario.Click += new System.EventHandler(this.subMenuRegistrarusuario_Click);
            // 
            // colsultarToolStripMenuItem
            // 
            this.colsultarToolStripMenuItem.Name = "colsultarToolStripMenuItem";
            this.colsultarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.colsultarToolStripMenuItem.Text = "Colsultar";
            // 
            // menuConfiguracion
            // 
            this.menuConfiguracion.Name = "menuConfiguracion";
            this.menuConfiguracion.Size = new System.Drawing.Size(95, 20);
            this.menuConfiguracion.Text = "Configuracion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(207, 119);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(348, 41);
            this.txtNombre.TabIndex = 1;
            // 
            // menuCerrarSesion
            // 
            this.menuCerrarSesion.Name = "menuCerrarSesion";
            this.menuCerrarSesion.Size = new System.Drawing.Size(88, 20);
            this.menuCerrarSesion.Text = "Cerrar Sesion";
            this.menuCerrarSesion.Click += new System.EventHandler(this.cesaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem subMenuColsultarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrarusuario;
        private System.Windows.Forms.ToolStripMenuItem colsultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguracion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarSesion;
    }
}