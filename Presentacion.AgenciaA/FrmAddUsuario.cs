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
using Entidades.AgenciaA;

namespace Presentacion.AgenciaA
{
    public partial class FrmAddUsuario : Form
    {
        EntidadUsuario eu;
        ManejadorUsuario mu;
        public FrmAddUsuario()
        {
            InitializeComponent();
            mu = new ManejadorUsuario();
            eu = new EntidadUsuario();
            if (FrmAdmin.eu._IDUsuario != 0)
            {
                txtRFC.Text = FrmAdmin.eu._RFC;
                txtContrasena.Text = FrmAdmin.eu._Contrasena;
                txtNombre.Text = FrmAdmin.eu._Nombre;
                txtApellidoP.Text = FrmAdmin.eu._ApellidoP;
                txtApellidoM.Text = FrmAdmin.eu._ApellidoM;
                txtFechanacimiento.Text = FrmAdmin.eu._Fechanacimiento;
                txtPermiso.Text = FrmAdmin.eu._FKIDPermisos;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmAdmin.eu._IDUsuario == 0)
            {
                MessageBox.Show(mu.Guardar(new EntidadUsuario(FrmAdmin.eu._IDUsuario, txtRFC.Text, txtContrasena.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtFechanacimiento.Text, txtPermiso.Text)));
            }
            else
            {
                MessageBox.Show(mu.Editar(new EntidadUsuario(FrmAdmin.eu._IDUsuario, txtRFC.Text, txtContrasena.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtFechanacimiento.Text, txtPermiso.Text)));
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
