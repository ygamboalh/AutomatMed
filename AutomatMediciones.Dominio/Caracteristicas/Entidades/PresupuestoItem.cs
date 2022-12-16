
using System;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class PresupuestoItem
    {
        public string RecID { get; set; }
        public string IDProducto { get; set; }
        public string IDPresupuesto { get; set; }
        public string IDUsuario { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CantidadCerrada { get; set; }
        public decimal ImportePrecio1 { get; set; }
        public decimal ImportePrecio2 { get; set; }
        public decimal ImportePrecio3 { get; set; }
        public decimal ImportePrecio4 { get; set; }
        public decimal ImportePrecio5 { get; set; }
        public decimal ImportePrecio6 { get; set; }
        public decimal? ImporteCosto1 { get; set; }
        public decimal? ImporteCosto2 { get; set; }
        public decimal? ImporteCosto3 { get; set; }
        public decimal? ImporteCosto4 { get; set; }
        public decimal? ImporteCosto5 { get; set; }
        public decimal? ImporteCosto6 { get; set; }
        public decimal Probabilidad { get; set; }
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
        public decimal Descuento { get; set; }
        public decimal SobrePrecio { get; set; }
        public int NroPrecio { get; set; }
        public string IDProdOb { get; set; }
        public byte? ObligOp { get; set; }
        public string NroItem { get; set; }
        public int PrecioOculto { get; set; }
        public string Notas { get; set; }
        public string PlazoEntrega { get; set; }
        public string FormaPago { get; set; }
        public int Validez { get; set; }
        public int NroFila { get; set; }
        public string DescripcionDescuento { get; set; }
        public string Unidad { get; set; }
        public int TipoUnidad { get; set; }
        public decimal Impuesto { get; set; }
        public string ImpuestoDescripcion { get; set; }
        public string IDCotizacionMoneda { get; set; }
        public int TipoComision { get; set; }
        public decimal Comision { get; set; }
        public int TipoComisionTerceros { get; set; }
        public decimal ComisionTerceros { get; set; }
        public int? NroMoneda { get; set; }
        public decimal? ImporteUnitario1 { get; set; }
        public decimal? ImporteUnitario2 { get; set; }
        public decimal? ImporteUnitario3 { get; set; }
        public decimal? ImporteUnitario4 { get; set; }
        public decimal? ImporteUnitario5 { get; set; }
        public decimal? ImporteUnitario6 { get; set; }
        public string IDUsuarioVendedor { get; set; }
        public string DescripcionGrupo { get; set; }
        public string NombreGrupo { get; set; }
        public byte? NroMonedaComisionTerceros { get; set; }

        public Presupuesto Presupuesto { get; set; }
    }
}
