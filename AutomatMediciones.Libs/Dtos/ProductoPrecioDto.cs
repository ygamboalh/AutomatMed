namespace AutomatMediciones.Libs.Dtos
{
    public class ProductoPrecioDto
    {
        public string RecID { get; set; }
        public string IDProducto { get; set; }
        public double Precio { get; set; }
        public double Costo { get; set; }
        public int NroMonedaPrecio { get; set; }
        public int NroLista { get; set; }
    }
}
