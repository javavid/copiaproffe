﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmPrincipal : Form
    {
        int tipoUsuario;
        public frmPrincipal()
        {
            InitializeComponent();
            txtNombre.Text = Session.nombre;

            tipoUsuario = Session.id_tipo;

            if (tipoUsuario == 1)
            {
                this.subMenuRegistrarusuario.Visible = true;
            }
            else
            {
                this.subMenuRegistrarusuario.Visible = false;
                this.menuConfiguracion.Visible = false;
            }

        }

        private void administracionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void subMenuRegistrarusuario_Click(object sender, EventArgs e)
        {
            frmRegistro otro = new frmRegistro();
            otro.Visible = true;
            //frmRegistro frmRegistro = new frmRegistro();
            // frmRegistro.Visible = true;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();
        }

        private void cesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Visible = true;

            Session ss = new Session();
        }
    }
}
