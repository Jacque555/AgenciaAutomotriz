namespace Entidades.AgenciaA
{
    public class EntidadesProducto
    {
        public EntidadesProducto()
        {
        }

        public EntidadesProducto(string codigobarras, string nombre, string descripcion, string marca)
        {
            _Codigobarras = codigobarras;
            _Nombre = nombre;
            _Descripcion = descripcion;
            _Marca = marca;
        }

        public string _Codigobarras { get; set; }
        public string _Nombre { get; set; }
        public string _Descripcion { get; set; }
        public string _Marca { get; set; }
    }
}
