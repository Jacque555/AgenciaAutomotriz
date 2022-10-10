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
    public partial class FrmAdmin : Form
    {
        public static EntidadUsuario eu;
        ManejadorUsuario mu;
        public FrmAdmin()
        {
            eu = new EntidadUsuario();
            mu = new ManejadorUsuario();
            InitializeComponent();
        }
        int i = 0;
        void Actualizar()
        {
            mu.Mostrar(dtgAdmin, txtBuscar.Text);
        }

        private void dtgAdmin_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            eu._IDUsuario = int.Parse(dtgAdmin.CurrentRow.Cells["idusuario"].Value.ToString());
            eu._RFC = dtgAdmin.CurrentRow.Cells["rfc"].Value.ToString();
            eu._Contrasena = dtgAdmin.CurrentRow.Cells["contrasena"].Value.ToString();
            eu._Nombre = dtgAdmin.CurrentRow.Cells["nombre"].Value.ToString();
            eu._ApellidoP = dtgAdmin.CurrentRow.Cells["apellidop"].Value.ToString();
            eu._ApellidoM = dtgAdmin.CurrentRow.Cells["apellidom"].Value.ToString();
            eu._Fechanacimiento = dtgAdmin.CurrentRow.Cells["fdn"].Value.ToString();
            eu._FKIDPermisos = dtgAdmin.CurrentRow.Cells["fkidpermisos"].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmAddUsuario fau = new FrmAddUsuario();
            fau.ShowDialog();
            Actualizar();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            eu._IDUsuario = 0;
            eu._RFC = "";
            eu._Contrasena = "";
            eu._Nombre = "";
            eu._ApellidoP = "";
            eu._ApellidoM = "";
            eu._Fechanacimiento = "";
            eu._FKIDPermisos = "";
            FrmAddUsuario fau = new FrmAddUsuario();
            fau.ShowDialog();
            Actualizar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dtgAdmin.RowCount > 0)
            {
                string r = mu.Borrar(eu);
                if (string.IsNullOrEmpty(r))
                {
                    MessageBox.Show(r);
                    Actualizar();
                }
                Actualizar();
            }
            else
            {
                MessageBox.Show("Seleccionar un registro");
            }
        }
    }
}
