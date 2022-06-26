namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class TipoCeldaModelo
    {
        public int Id { get; set; }
        public int TipoCeldaId { get; set; }
        public int ModeloId { get; set; }
        public bool Activo { get; set; }
        public TipoCelda TipoDeCelda { get; set; }
        public Modelo Modelo { get; set; }
    }
}
