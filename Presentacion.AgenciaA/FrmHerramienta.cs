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
    public partial class FrmHerramienta : Form
    {
        public static EntidadesHerramienta eh;
        ManejadorHerramient mh;
        public FrmHerramienta()
        {
            InitializeComponent();
            eh = new EntidadesHerramienta();
            mh = new ManejadorHerramient();

        }
        int i = 0;
        void Actualizar()
        {
            mh.Mostrar(dtgHerramienta, txtBuscar.Text);
        }

        private void dtgHerramienta_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            eh._Codigoherramienta = dtgHerramienta.CurrentRow.Cells["codigoherramienta"].Value.ToString();
            eh._Nombre = dtgHerramienta.CurrentRow.Cells["nombre"].Value.ToString();
            eh._Medida = dtgHerramienta.CurrentRow.Cells["medida"].Value.ToString();
            eh._Descripcion = dtgHerramienta.CurrentRow.Cells["descripcion"].Value.ToString();
            eh._Marca = dtgHerramienta.CurrentRow.Cells["marca"].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            eh._Codigoherramienta = "";
            eh._Nombre = "";
            eh._Medida = "";
            eh._Descripcion = "";
            eh._Marca = "";
            FrmAddHerramienta fah = new FrmAddHerramienta();
            fah.ShowDialog();
            Actualizar();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmAddHerramienta fah = new FrmAddHerramienta();
            fah.ShowDialog();
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgHerramienta.RowCount > 0)
            {
                string r = mh.Borrar(eh);
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
