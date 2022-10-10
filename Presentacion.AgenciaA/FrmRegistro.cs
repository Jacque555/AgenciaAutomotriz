using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.AgenciaA;
using Manejadores.AgenciaA;

namespace Presentacion.AgenciaA
{
    public partial class FrmRegistro : Form
    {
        ManejadorLoginRegistro mlr;
        EntidadUsuario eu;
        public FrmRegistro()
        {
            InitializeComponent();
            mlr = new ManejadorLoginRegistro();
            eu = new EntidadUsuario();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
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

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Gainsboro;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtConfContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == " CONFIRMAR CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Gainsboro;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtConfContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONFIRMAR CONTRASEÑA";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void chnMostrarC_CheckedChanged(object sender, EventArgs e)
        {
            if (chnMostrarC.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
                txtConfContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                if (chnMostrarC.Checked == false)
                {
                    txtContraseña.UseSystemPasswordChar = true;
                    txtConfContrasena.UseSystemPasswordChar = true;
                }
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE(S)")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Gainsboro;
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE(S)";
                txtNombre.ForeColor = Color.Gray;
            }
        }
        private void txtApellidoP_Enter(object sender, EventArgs e)
        {
            if (txtApellidoP.Text == "APELLIDO PATERNO")
            {
                txtApellidoP.Text = "";
                txtApellidoP.ForeColor = Color.Gainsboro;
            }
        }

        private void txtApellidoP_Leave(object sender, EventArgs e)
        {
            if (txtApellidoP.Text == "")
            {
                txtApellidoP.Text = "APELLIDO PATERNO";
                txtApellidoP.ForeColor = Color.Gray;
            }
        }

        private void txtApellidom_Enter(object sender, EventArgs e)
        {
            if (txtApellidom.Text == "APELLIDO MATERNO")
            {
                txtApellidom.Text = "";
                txtApellidom.ForeColor = Color.Gainsboro;
            }
        }

        private void txtApellidom_Leave(object sender, EventArgs e)
        {
            if (txtApellidom.Text == "")
            {
                txtApellidom.Text = "APELLIDO MATERNO";
                txtApellidom.ForeColor = Color.Gray;
            }
        }

        private void txtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "FECHA DE NACIMIENTO")
            {
                txtFecha.Text = "";
                txtFecha.ForeColor = Color.Gainsboro;
            }
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "FECHA DE NACIMIENTO";
                txtFecha.ForeColor = Color.Gray;
            }
        }

        private void txtPermisos_Enter(object sender, EventArgs e)
        {
            if (txtPermisos.Text == "PERMISOS")
            {
                txtPermisos.Text = "";
                txtPermisos.ForeColor = Color.Gainsboro;
            }
        }

        private void txtPermisos_Leave(object sender, EventArgs e)
        {
            if (txtPermisos.Text == "")
            {
                txtFecha.Text = "PERMISOS";
                txtFecha.ForeColor = Color.Gray;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfContrasena.Text)
            {
                GuardarRegistro();
                this.Hide();
                FrmLogin fl = new FrmLogin();
                fl.Show();
            }
            else
            {
                MessageBox.Show("Verifique que las contraseñas coincidan");
            }
        }
        public static string permiso;
        private void GuardarRegistro()
        {
            permiso = eu._FKIDPermisos;
            eu._RFC = txtUsuario.Text;
            eu._Contrasena = txtConfContrasena.Text;
            eu._Nombre = txtNombre.Text;
            eu._ApellidoP = txtApellidoP.Text;
            eu._ApellidoM = txtApellidom.Text;
            eu._Fechanacimiento = txtFecha.Text;
            eu._FKIDPermisos = txtPermisos.Text;
            mlr.Guardar(eu);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }

    }
}
