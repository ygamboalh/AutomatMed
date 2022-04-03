namespace TacticaReparaciones.Servicios.Caracteristicas.Entidades
{
    public class VariableDeMedicion
    {
        public int VariableMedicionId { get; set; }
        public string Descripcion { get; set; }
        public decimal PrimerValorRango { get; set; }
        public decimal SegundoValorRango { get; set; }
        public decimal Tolerancia { get; set; }
    }
}
