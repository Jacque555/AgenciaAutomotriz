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
    public partial class FrmProducto : Form
    {
        EntidadesProducto ep;
        ManejadorProducto mp;
        public FrmProducto()
        {
            ep = new EntidadesProducto();
            mp = new ManejadorProducto();
            InitializeComponent();
        }

        int i = 0;
        void Actualizar()
        {
            mp.Mostrar(txtBuscar.Text, dtgProducto);
        }
        private void dtgProducto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            ep._Codigobarras = dtgProducto.CurrentRow.Cells["codidobarras"].Value.ToString();
            ep._Nombre = dtgProducto.CurrentRow.Cells["nombre"].Value.ToString();
            ep._Descripcion = dtgProducto.CurrentRow.Cells["descripcion"].Value.ToString();
            ep._Marca = dtgProducto.CurrentRow.Cells["marca"].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
