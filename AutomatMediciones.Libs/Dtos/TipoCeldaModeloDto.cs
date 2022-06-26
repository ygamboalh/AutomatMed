namespace AutomatMediciones.Libs.Dtos
{
    public class TipoCeldaModeloDto
    {
        public int Id { get; set; }
        public int TipoCeldaId { get; set; }
        public int ModeloId { get; set; }
        public bool Activo { get; set; }

        public TipoCeldaDto TipoDeCelda { get; set; }
        public ModeloDto Modelo { get; set; }
    }
}
