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
    public partial class FrmAddHerramienta : Form
    {
        ManejadorHerramient mh;
        EntidadesHerramienta eh;
        public FrmAddHerramienta()
        {
            InitializeComponent();
            mh = new ManejadorHerramient();
            eh = new EntidadesHerramienta();
            if (FrmHerramienta.eh._Codigoherramienta != "")
            {
                txtCodigo.Text = FrmHerramienta.eh._Codigoherramienta;
                txtNombre.Text = FrmHerramienta.eh._Nombre;
                txtMedida.Text = FrmHerramienta.eh._Medida;
                txtMarca.Text = FrmHerramienta.eh._Marca;
                txtDescripcion.Text = FrmHerramienta.eh._Descripcion;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmHerramienta.eh._Codigoherramienta == "")
            {
                MessageBox.Show(mh.Guardar(new EntidadesHerramienta(FrmHerramienta.eh._Codigoherramienta, txtNombre.Text, txtMedida.Text, txtMarca.Text, txtDescripcion.Text)));
            }
            else
            {
                MessageBox.Show(mh.Editar(new EntidadesHerramienta(FrmHerramienta.eh._Codigoherramienta, txtNombre.Text, txtMedida.Text, txtMarca.Text, txtDescripcion.Text)));
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
