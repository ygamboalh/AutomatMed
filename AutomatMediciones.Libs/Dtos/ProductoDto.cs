using System.Collections.Generic;

namespace AutomatMediciones.Libs.Dtos
{
    public class ProductoDto
    {
        public string RecID { get; set; }
        public string SubFamilia { get; set; }
        public string Descripcion { get; set; }
        public string Fabricante { get; set; }
        public string TipoProducto { get; set; }
        public string Imagen { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public int? Estado { get; set; }
        public int? CodUnidad { get; set; }
        public string IdCarpeta { get; set; }
        public decimal Precio { get; set; }
        public int MonedaId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Impuesto { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public MonedaDto Moneda { get; set; }
        public List<ProductoPrecioDto> ProductoPrecios { get; set; }
    }
}
