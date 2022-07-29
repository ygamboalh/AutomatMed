using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMediciones.DesktopApp.Reportes.Dtos
{
    public class RptCertificadoDto
    {
        public string NumeroCertificado { get; set; }
        public string TipoInstrumento { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public List<string> Medicion { get; set; }
        public string Cliente { get; set; }
        public string Resumen { get; set; }
        public string Metodologia { get; set; }
        public List<string> Patrones { get; set; }
        public List<AlarmaDto> Alarmas { get; set; }
        public List<MedicionDto> Mediciones { get; set; }
        public string Observaciones { get; set; }
        public string Resultado { get; set; }

        public string NombreResponsable { get; set; }
        public DateTime FechaCertificado { get; set; }
    }

    public class AlarmaDto
    {
        public string Sensor { get; set; }
        public decimal Alta { get; set; }
        public decimal Baja { get; set; }
        public decimal Twa { get; set; }
        public decimal Stel { get; set; }
    }

    public class MedicionDto
    {
        public string CondicionesAmbientales { get; set; }
        public string NombreVariable { get; set; }
        public int VariableMedicionId { get; set; }
        public List<ValorMedicionDto> ValoresDeMedicion { get; set; }

    }

    public class ValorMedicionDto
    {
        public decimal ValorPatron { get; set; }
        public decimal ToleranciaPatron { get; set; }
        public decimal ValorMedido { get; set; }
        public decimal ToleranciaInstrumento { get; set; }
        public int VariableMedicionId { get; set; }
    }


}
