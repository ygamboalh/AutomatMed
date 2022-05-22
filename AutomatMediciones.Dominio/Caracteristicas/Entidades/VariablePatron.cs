namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class VariablePatron
    {
        public int VariablePatronId { get; set; }
        public int VariableMeicionId { get; set; }
        public int PatronId { get; set; }
        public decimal ValorPatron { get; set; }
        public decimal Tolerancia { get; set; }
        public bool Activo { get; set; }

        public Patron Patron { get; set; }
        public VariableDeMedicion VariableDeMedicion { get; set; }
    }
}
