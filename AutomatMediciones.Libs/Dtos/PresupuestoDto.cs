using System;

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
        public int? Revision { get; set; }
        public byte? Estado { get; set; }
        public byte? NroMoneda { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string IDContrato { get; set; }
        public string Descripcion { get; set; }
        public byte? MostrarImpuestos { get; set; }
        public string MotivoCierre { get; set; }
        public string Introduccion { get; set; }
        public string Cierre { get; set; }
        public string IDConsulta { get; set; }
        public double? Subtotal { get; set; }
        public double? SubTotal2 { get; set; }
        public double? Impuesto { get; set; }
        public double? ImpuestosInternos { get; set; }
        public double? Descuento { get; set; }
        public double? Total { get; set; }
        public int? Validez { get; set; }
        public double? EmbalajeIM { get; set; }
        public double? EmbalajeIF { get; set; }
        public double? GastosIM { get; set; }
        public double? GastosIF { get; set; }
        public double? TransPuertoIM { get; set; }
        public double? TransPuertoIF { get; set; }
        public double? FleteIntIM { get; set; }
        public double? FleteIntIF { get; set; }
        public double? SeguroIM { get; set; }
        public double? SeguroIF { get; set; }
        public byte? TipoEW { get; set; }
        public string IDFormula { get; set; }
        public byte? TipoComision { get; set; }
        public int? PorcentajeComision { get; set; }
        public double? ImporteComision { get; set; }
        public byte? NroMonedaComision { get; set; }
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
    }
}
