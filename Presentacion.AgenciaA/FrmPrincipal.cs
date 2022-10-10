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
    public partial class FrmPrincipal : Form
    {
        ManejadorLoginRegistro mlr;
        public FrmPrincipal()
        {
            InitializeComponent();
            btnAdmin.Hide();
            if (FrmLogin.val == "ADMIN")
            {
                btnAdmin.Show();
            }
        }
        public static Form frmactivo = null;
        public static Form frmhijo;
        public void AbrirFrmHijo(Form frmhijo)
        {
            if (frmactivo != null)
            {
                frmactivo.Close();
            }
            frmactivo = frmhijo;
            frmhijo.TopLevel = false;
            frmhijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(frmhijo);
            pnlContenedor.Tag = frmhijo;
            frmhijo.BringToFront();
            frmhijo.Show();
        }
        private void btnHerramienta_Click_1(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmHerramienta());
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmAdmin());
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            pnlContenedor.BringToFront();
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            AbrirFrmHijo(new FrmProducto());
        }
    }
}
