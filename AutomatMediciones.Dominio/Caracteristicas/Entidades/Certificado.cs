using System;

namespace AutomatMediciones.Dominio.Caracteristicas.Entidades
{
    public class Certificado
    {
        public int CertificadoId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string NumeroCertificado { get; set; }
        public int InstrumentoId { get; set; }
        public string CondicionesAmbientales { get; set; }
        public int ResponsableId { get; set; }

        public Usuario Responsable { get; set; }
        public Instrumento Intrumento { get; set; }
    }
}
