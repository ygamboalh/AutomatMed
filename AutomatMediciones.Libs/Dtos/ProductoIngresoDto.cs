using System;
namespace AutomatMediciones.Libs.Dtos
{
    public class ProductoIngresoDto
    {
        public int Id { get; set; }
        public string ProductoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
        public int PresupuestoControlId { get; set; }
        public int IngresoId { get; set; }
        public decimal Cantidad { get; set; }
    }

}
