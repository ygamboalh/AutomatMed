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
        public string RecID { get; set; }
        public string IDProducto { get; set; }
        public string IDPresupuesto { get; set; }
        public double? Cantidad { get; set; }
        public double? ImportePrecio1 { get; set; }
        public double? ImportePrecio2 { get; set; }
        public double? ImportePrecio3 { get; set; }
        public double? ImportePrecio4 { get; set; }
        public double? ImportePrecio5 { get; set; }
        public double? ImportePrecio6 { get; set; }
        public double? ImporteCosto1 { get; set; }
        public double? ImporteCosto2 { get; set; }
        public double? ImporteCosto3 { get; set; }
        public double? ImporteCosto4 { get; set; }
        public double? ImporteCosto5 { get; set; }
        public double? ImporteCosto6 { get; set; }
        public string Descripcion { get; set; }
      
        public PresupuestoViewDto Presupuesto { get; set; }
    }
}
