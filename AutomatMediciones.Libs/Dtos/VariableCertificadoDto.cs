namespace AutomatMediciones.Libs.Dtos
{
    public class VariableCertificadoDto
    {
        public int VariableCertificadoId { get; set; }
        public int CertificadoId { get; set; }
        public int PatronId { get; set; }
        public decimal ValorMedido { get; set; }
        public int VariableInstrumentoId { get; set; }

        public CertificadoDto Certificado { get; set; }
        public PatronDto Patron { get; set; }
        public VariableInstrumentoDto VariableInstrumento { get; set; }
    }
}
