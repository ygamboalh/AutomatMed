using System;
using System.Collections.Generic;

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
        public int ResponsableId { get; set; }
        public string Observaciones { get; set; }
        public string Resultado { get; set; }
        public string RutaCertificado { get; set; }
        public UsuarioDto Responsable { get; set; }
        public InstrumentoDto Instrumento { get; set; }
        public List<VariableCertificadoDto> VariablesCertificado { get; set; }
    }
}
