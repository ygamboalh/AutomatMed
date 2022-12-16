using System;

namespace AutomatMediciones.Libs.Dtos
{
    public class PresupuestoItemDto
    {
        public string RecID { get; set; }
        public string IDProducto { get; set; }
        public string IDPresupuesto { get; set; }
        public string IDUsuario { get; set; }
        public double? Cantidad { get; set; }
        public double? CantidadCerrada { get; set; }
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
        public double? Probabilidad { get; set; }
        public DateTime? FechaSistema { get; set; }
        public DateTime? FechaCierre { get; set; }
        public DateTime? FechaEmision { get; set; }
        public string IDEjercicio { get; set; }
        public string IDPeriodo { get; set; }
        public byte? Estado { get; set; }
        public string Descripcion { get; set; }
        public string Descripcion2 { get; set; }
        public string Descripcion3 { get; set; }
        public string TipoProducto { get; set; }
        public DateTime? FechaInclusion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Codigo { get; set; }
        public string Fabricante { get; set; }
        public double? Descuento { get; set; }
        public double? SobrePrecio { get; set; }
        public byte? NroPrecio { get; set; }
        public string IDProdOb { get; set; }
        public byte? ObligOp { get; set; }
        public string NroItem { get; set; }
        public byte? PrecioOculto { get; set; }
        public string Notas { get; set; }
        public string PlazoEntrega { get; set; }
        public string FormaPago { get; set; }
        public int? Validez { get; set; }
        public int? NroFila { get; set; }
        public string DescripcionDescuento { get; set; }
        public string Unidad { get; set; }
        public byte? TipoUnidad { get; set; }
        public double? Impuesto { get; set; }
        public string ImpuestoDescripcion { get; set; }
        public string IDCotizacionMoneda { get; set; }
        public byte? TipoComision { get; set; }
        public double? Comision { get; set; }
        public byte? TipoComisionTerceros { get; set; }
        public double? ComisionTerceros { get; set; }
        public byte? NroMoneda { get; set; }
        public double? ImporteUnitario1 { get; set; }
        public double? ImporteUnitario2 { get; set; }
        public double? ImporteUnitario3 { get; set; }
        public double? ImporteUnitario4 { get; set; }
        public double? ImporteUnitario5 { get; set; }
        public double? ImporteUnitario6 { get; set; }
        public string IDUsuarioVendedor { get; set; }
        public string DescripcionGrupo { get; set; }
        public string NombreGrupo { get; set; }
        public byte? NroMonedaComisionTerceros { get; set; }

        public PresupuestoDto Presupuesto { get; set; }
    }
}
