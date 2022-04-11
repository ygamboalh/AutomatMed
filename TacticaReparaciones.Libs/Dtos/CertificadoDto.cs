using System;

namespace AutomatMediciones.Libs.Dtos
{
    public class CertificadoDto
    {
        public int CertificadoId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string NumeroCertificado { get; set; }
        public int InstrumentoId { get; set; }
        public string CondicionesAmbientales { get; set; }
        public string Responsable { get; set; }
    }
}
