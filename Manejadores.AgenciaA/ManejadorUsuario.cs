using AccesoDatos.AgenciaA;
using Entidades.AgenciaA;
using System.Windows.Forms;

namespace Manejadores.AgenciaA
{
    public class ManejadorUsuario
    {
        AccesoBase ab = new AccesoBase("localhost", "root", "", "agencia_automotriz", 3306);

        public string Guardar(EntidadUsuario eu)
        {
            return ab.Comando(string.Format("insert into usuario values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')", 
                eu._RFC, eu._Contrasena, eu._Nombre, eu._ApellidoP, eu._ApellidoM, eu._Fechanacimiento, eu._FKIDPermisos));
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = ab.Mostrar(string.Format("select * from usuario where nombre like '%{0}%' or rfc like '%{0}%'", dato), "usuario").Tables["usuario"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadUsuario eu)
        {
            return ab.Comando(string.Format("update usuario set rfc = '{0}', nombre = '{1}', apellidop = '{2}', apeliidom = '{3}', fechamaciemiento ='{4}', fkidpermisos = '{5}' where idusuario ='{6}'", 
                eu._RFC, eu._Nombre,eu._ApellidoP,eu._ApellidoM,eu._Fechanacimiento,eu._FKIDPermisos,eu._IDUsuario));
        }
        public string Borrar(EntidadUsuario eu)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Está seguro de eliminar" + eu._Nombre, "Atención!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ab.Comando(string.Format("delete from usuario where idusuario = '{0}'", eu._IDUsuario));
            }
            return r;
        }
    }
}
