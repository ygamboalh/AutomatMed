namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class Producto
    {
        public string RecID { get; set; }
        public string SubFamilia { get; set; }
        public string Descripcion { get; set; }
        public string Fabricante { get; set; }
        public string TipoProducto { get; set; }
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int? Estado { get; set; }
        public int? CodUnidad { get; set; }
        public string IdCarpeta { get; set; }
    }
}
