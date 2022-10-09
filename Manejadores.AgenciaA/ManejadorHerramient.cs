using AccesoDatos.AgenciaA;
using Entidades.AgenciaA;
using System.Windows.Forms;

namespace Manejadores.AgenciaA
{
    public class ManejadorHerramient
    {
        AccesoBase ab = new AccesoBase("localhost", "root", "", "agencia_automotriz", 3306);

        public string Guardar(EntidadesHerramienta eh)
        {
            return ab.Comando(string.Format("insert into herramienta values('{0}','{1}','{2}','{3}','{4}')", eh._Codigoherramienta, eh._Nombre, eh._Medida, eh._Descripcion, eh._Marca));
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = ab.Mostrar(string.Format("select * from herramienta where nombre like '%{0}%' or codigoherramienta like '%{0}%'", dato), "herramienta").Tables["herramienta"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadesHerramienta eh)
        {
            return ab.Comando(string.Format("update herramienta set nombre = '{0}', medida = '{1}', descripcion = '{2}', marca = '{3}' where codigoherramienta ='{4}'", eh._Nombre,
                eh._Medida, eh._Descripcion, eh._Marca, eh._Codigoherramienta));
        }
        public string Borrar(EntidadesHerramienta eh)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar" + eh._Descripcion, "Atención!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ab.Comando(string.Format("delete from herramientas where codigoherramienta = '{0}'", eh._Codigoherramienta));
            }
            return r;
        }
    }
}
