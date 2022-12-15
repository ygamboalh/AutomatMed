using System;

namespace AutomatMediciones.Libs.Dtos
{
    public class MonedaCotizacionDto
    {
        public string RecId { get; set; }
        public decimal CotizacionMonedaDos { get; set; }
        public decimal CotizacionMonedaTres { get; set; }
        public decimal CotizacionMonedaCuatro { get; set; }
        public decimal CotizacionMonedaCinco { get; set; }
        public decimal CotizacionMonedaSeis { get; set; }
        public DateTime FechaHora { get; set; }
        public int Tipo { get; set; }
        public string IdUsuario { get; set; }
    }
}
