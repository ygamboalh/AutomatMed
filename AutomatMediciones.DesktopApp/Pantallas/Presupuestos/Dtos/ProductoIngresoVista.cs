using AutomatMediciones.Libs.Dtos;

namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos.Dtos
{
    public class ProductoIngresoVista : ProductoIngresoDto
    {
        public int IdCotizacionMoneda { get; set; }
        public string Moneda { get; set; }
        public bool Seleccionar { get; set; }
    }
}
