namespace AutomatMediciones.Libs.Dtos
{
    public class ProductoPrecioDto
    {
        public string RecID { get; set; }
        public string IDProducto { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public int NroMonedaPrecio { get; set; }
        public int NroLista { get; set; }
    }
}
