using AccesoDatos.AgenciaA;
using Entidades.AgenciaA;
using System.Windows.Forms;

namespace Manejadores.AgenciaA
{
    public class ManejadorProducto
    {
        AccesoBase ab = new AccesoBase("localhost", "root", "", "agencia_automotriz", 3306);

        public string Guardar(EntidadesProducto ep)
        {
            return ab.Comando(string.Format("insert into producto values('{0}','{1}','{2}','{3}')", ep._Codigobarras,ep._Nombre,ep._Descripcion,ep._Marca));
        }
        public void Mostrar(string dato, DataGridView tabla)
        {
            tabla.DataSource = ab.Mostrar(string.Format("select * from producto where nombre like '%{0}%' or codigobarras like '%{0}%'", dato), "producto").Tables["producto"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadesProducto ep)
        {
            return ab.Comando(string.Format("update producto set nombre = '{0}', descripcion = '{1}', marca = '{2}', marca = '{3}' where codigobarras ='{4}'", ep._Nombre,
                ep._Descripcion, ep._Marca,ep._Codigobarras));
        }
        public string Borrar(EntidadesProducto ep)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar" + ep._Descripcion, "Atención!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ab.Comando(string.Format("delete from producto where codigobarras = '{0}'", ep._Codigobarras));
            }
            return r;
        }
    }
}
