namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class VariableCertificado
    {
        public int VariableCertificadoId { get; set; }
        public int CertificadoId { get; set; }
        public int PatronId { get; set; }
        public decimal ValorMedido { get; set; }
        public int VariableInstrumentoId { get; set; }
    }
}
