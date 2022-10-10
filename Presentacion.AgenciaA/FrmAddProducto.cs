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
    public partial class FrmAddProducto : Form
    {
        EntidadesProducto ep;
        ManejadorProducto mp;
        public FrmAddProducto()
        {
            InitializeComponent();
            ep = new EntidadesProducto();
            mp = new ManejadorProducto();
            if (FrmProducto.ep._Codigobarras != "")
            {
                txtCodigo.Text = FrmHerramienta.eh._Codigoherramienta;
                txtNombre.Text = FrmHerramienta.eh._Nombre;
                txtDescripcion.Text = FrmHerramienta.eh._Descripcion;
                txtMarca.Text = FrmHerramienta.eh._Marca;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmProducto.ep._Codigobarras == "")
            {
                MessageBox.Show(mp.Guardar(new EntidadesProducto(FrmProducto.ep._Codigobarras, txtNombre.Text, txtDescripcion.Text, txtMarca.Text)));
            }
            else
            {
                MessageBox.Show(mp.Editar(new EntidadesProducto(FrmProducto.ep._Codigobarras, txtNombre.Text, txtDescripcion.Text, txtMarca.Text)));
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
