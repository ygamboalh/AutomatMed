namespace TacticaReparaciones.Libs.Dtos
{
    public class VariablePatronDto
    {
        public int VariablePatronId { get; set; }
        public int VariableMeicionId { get; set; }
        public int PatronId { get; set; }
        public decimal ValorPatron { get; set; }
        public decimal Tolerancia { get; set; }
    }
}
