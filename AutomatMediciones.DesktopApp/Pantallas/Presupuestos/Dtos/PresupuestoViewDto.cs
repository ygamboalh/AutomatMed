using AutomatMediciones.Libs.Dtos;
using System;
using System.Collections.Generic;

namespace AutomatMediciones.DesktopApp.Pantallas.Presupuestos.Dtos
{
    public class PresupuestoViewDto
    {
        public string RecID { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Nombre { get; set; }
        public int NroMoneda { get; set; }
        public decimal Total { get; set; }
        public string Moneda { get; set; }
        public List<PresupuestoDetalleViewDto> PresupuestoItems { get; set; }
    }
    
    public class PresupuestoDetalleViewDto
    {
        public string Descripcion { get; set; }
        public double? Cantidad { get; set; }
        public decimal Precio { get; set; }
       
    }
}
