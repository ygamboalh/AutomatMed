namespace AutomatMediciones.Libs.Dtos.View
{
    public class PresupuestoHistorialDto
    {
        public string PresupuestoId { get; set; }
        public string PresupuestoDetalleId { get; set; }
        public string Moneda { get; set; }
        public string IdCotizacionMoneda { get; set; }
        public string ProductoId { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public string Modelo { get; set; }
        public string Cliente { get; set; }
        public string Instrumento { get; set; }
        public bool Seleccionar { get; set; }
    }
}
