using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores.AgenciaA;

namespace Presentacion.AgenciaA
{
    public partial class FrmLogin : Form
    {
        public static string val = "";
        ManejadorLoginRegistro mlr;
        public FrmLogin()
        {
            InitializeComponent();
            mlr = new ManejadorLoginRegistro();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="USUARIO")
            {
                txtUsuario.Text=  "";
                txtUsuario.ForeColor = Color.Gainsboro;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Gainsboro;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void chbMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            if(chbMostrarContra.Checked == false)
            {
                txtContrasena.UseSystemPasswordChar = true;
            }
            else
            {
                if (chbMostrarContra.Checked == true)
                {
                    txtContrasena.UseSystemPasswordChar = false;
                }
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            int v = mlr.ValidarUsuario(txtUsuario.Text, txtContrasena.Text);
            if (v == 1)
            {
                this.Hide();
                val = mlr.Permiso(txtUsuario.Text);
                FrmPrincipal fp = new FrmPrincipal();
                fp.Show();
            }
            else
            {
                MessageBox.Show("ERROR, USUARIO Y/0 CONTRASEÑA NO VALIDOS");
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistro fr = new FrmRegistro();
            fr.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
