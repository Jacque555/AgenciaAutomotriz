namespace Entidades.AgenciaA
{
    public class EntidadesHerramienta
    {
        public EntidadesHerramienta()
        {
        }

        public EntidadesHerramienta(string codigoherramienta, string nombre, string medida, string marca, string descripcion)
        {
            _Codigoherramienta = codigoherramienta;
            _Nombre = nombre;
            _Medida = medida;
            _Marca = marca;
            _Descripcion = descripcion;
        }

        public string _Codigoherramienta { get; set; }
        public string _Nombre { get; set; }
        public string _Medida { get; set; }
        public string _Marca { get; set; }
        public string _Descripcion { get; set; }
    }
}
