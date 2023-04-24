using System;
using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class PresupuestoDto
    {
        public string RecID { get; set; }
        public string IDRef { get; set; }
        public string IDCampania { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Nombre { get; set; }
        public int? ID { get; set; }
        public int Revision { get; set; }
        public int? Estado { get; set; }
        public int NroMoneda { get; set; }
        public string MonedaRecId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string IDContrato { get; set; }
        public string Descripcion { get; set; }
        public bool MostrarImpuestos { get; set; }
        public string MotivoCierre { get; set; }
        public string Introduccion { get; set; }
        public string Cierre { get; set; }
        public string IDConsulta { get; set; }
        public decimal Subtotal { get; set; }
        public decimal SubTotal2 { get; set; }
        public decimal Impuesto { get; set; }
        public decimal ImpuestosInternos { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public int? Validez { get; set; }
        public decimal EmbalajeIM { get; set; }
        public decimal EmbalajeIF { get; set; }
        public decimal GastosIM { get; set; }
        public decimal GastosIF { get; set; }
        public decimal TransPuertoIM { get; set; }
        public decimal TransPuertoIF { get; set; }
        public decimal FleteIntIM { get; set; }
        public decimal FleteIntIF { get; set; }
        public decimal SeguroIM { get; set; }
        public decimal SeguroIF { get; set; }
        public int TipoEW { get; set; }
        public string IDFormula { get; set; }
        public int TipoComision { get; set; }
        public int PorcentajeComision { get; set; }
        public decimal ImporteComision { get; set; }
        public int NroMonedaComision { get; set; }
        public string Escenario { get; set; }
        public DateTime? FechaCierre { get; set; }
        public byte? Origen { get; set; }
        public byte? ExcluirAnalisis { get; set; }
        public string IDUsuario { get; set; }
        public string IDUsuarioAutorizacion { get; set; }
        public string IDUsuarioCreacion { get; set; }
        public string Tipo { get; set; }
        public byte? ModalidadCliente { get; set; }
        public string Auditoria { get; set; }
        public string CustomID { get; set; }
        public byte? ActualizarAuto { get; set; }
        public string NoServicioTecnico { get; set; }
        public string ClasificacionInstrumento{ get; set; }
        public int IngresoId { get; set; }
        public int InstrumentoId { get; set; }
        public int ModeloId { get; set; }
        public string NombreCliente { get; set; }
        public string ClienteId { get; set; }
        public string CorreoUsuario { get; set; }
        public decimal PrecioTotaldeProductos { get; set; }

        public MonedaDto Moneda { get; set; }
        public List<ProductoDto> Productos { get; set; }
        public List<PresupuestoItemDto> PresupuestoItems { get; set; }
    }
}
