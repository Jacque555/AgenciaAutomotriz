using System;
using AccesoDatos.AgenciaA;
using Entidades.AgenciaA;
using System.Windows.Forms;

namespace Manejadores.AgenciaA
{
    public class ManejadorLoginRegistro
    {
        public AccesoBase _base;
        public ManejadorLoginRegistro()
        {
            _base = new AccesoBase("localhost", "root", "", "agencia_automotriz", 3306);
        }
        public string Guardar(EntidadUsuario eu)
        {
            return _base.Comando(string.Format("insert into usuario values(null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                eu._RFC, eu._Contrasena, eu._Nombre, eu._ApellidoP, eu._ApellidoM, eu._Fechanacimiento, eu._FKIDPermisos));
        }
        public int Login(string lUsuario, string lContrasena)
        {
            string consulta = string.Format("SELECT count(*) FROM usuario WHERE rfc = '{0}' AND contrasena = '{1}';", lUsuario, lContrasena);
            int c = int.Parse(_base.ConsultaRetorno(consulta));
            return c;
        }
        public int  ValidarUsuario(string vUsuario, string vContrasena)
        {
            int c = 0;
            try
            {
                c = Login(vUsuario, vContrasena);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la validación" + ex.Message);
            }
            return c;
        }
        public string Permisos(string permiso)
        {
            string consulta = string.Format("SELECT idpermisos FROM permisos WHERE idpermisos = '{0}';", permiso);
            string c = _base.ConsultaRetorno(consulta);
            return c;
        }
        public string Permiso(string rfc)
        {
            string consulta = string.Format("SELECT fkidpermisos from usuario where rfc = '{0}';", rfc);
            string c = _base.ConsultaRetorno(consulta);
            return c;
        }
    }
}
