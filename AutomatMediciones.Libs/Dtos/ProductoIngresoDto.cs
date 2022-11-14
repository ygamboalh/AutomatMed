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
        public int InstrumentoId { get; set; }
        public int ModeloId { get; set; }
        public string ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public decimal Precio { get; set; }
        public int MonedaId { get; set; }

        public InstrumentoDto Instrumento { get; set; }
        public ModeloDto Modelo { get; set; }
    }
    
}
