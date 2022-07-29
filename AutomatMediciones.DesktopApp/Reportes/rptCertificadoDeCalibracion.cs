using AutomatMediciones.DesktopApp.Reportes.Dtos;
using AutomatMediciones.Libs.Dtos;
using System.Linq;

namespace AutomatMediciones.DesktopApp.Reportes
{
    public partial class rptCertificadoCalibracion : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCertificadoCalibracion()
        {
            InitializeComponent();
        }

        public void PrepararCertificado(CertificadoDto certificadoDto)
        {
            var patrones = certificadoDto.VariablesCertificado.Where(x => x.Certificado.CertificadoId == certificadoDto.CertificadoId).Select(y => y.Patron.Nombre).ToList();
            var variablesInstrumentos = certificadoDto.VariablesCertificado.Where(x => x.CertificadoId == certificadoDto.CertificadoId).Select(x => x.VariableInstrumento).ToList();

            var variablesCertificados = certificadoDto.VariablesCertificado.Where(x => x.CertificadoId == certificadoDto.CertificadoId).ToList();
            var variablesPatrones = variablesCertificados.Where(x => x.CertificadoId == certificadoDto.CertificadoId).Select(x => x.Patron).SelectMany(x => x.VariablesPatrones).ToList();
            var variablesDeMedicion = variablesInstrumentos.Select(x => x.VariableDeMedicion).ToList();

            var mediciones = (from variableCertificado in variablesCertificados
                                join variableInstrumento in variablesInstrumentos on variableCertificado.VariableInstrumentoId equals variableInstrumento.VariableInstrumentoId
                                join variableMedicion in variablesDeMedicion on variableInstrumento.VariableMedicionId equals variableMedicion.VariableMedicionId                               
                                select new ValorMedicionDto
                                {
                                    VariableMedicionId = variableMedicion.VariableMedicionId,
                                    ValorPatron = variablesPatrones.FirstOrDefault(x => x.PatronId == variableCertificado.PatronId).ValorPatron,
                                    ToleranciaPatron = variablesPatrones.FirstOrDefault(x => x.PatronId == variableCertificado.PatronId).Tolerancia,
                                    ToleranciaInstrumento = variableMedicion.Tolerancia,
                                    ValorMedido = variableCertificado.ValorMedido
                                }).ToList();

            var reporte = new RptCertificadoDto
            {
                NumeroCertificado = certificadoDto.NumeroCertificado,
                TipoInstrumento = certificadoDto.Instrumento.Clasificacion.TipoInstrumento.Descripcion,
                Modelo = certificadoDto.Instrumento.Clasificacion.Modelo.Descripcion,
                Marca = certificadoDto.Instrumento.Clasificacion.Marca.Descripcion,
                Resumen = certificadoDto.Instrumento.Clasificacion.TipoInstrumento.Resumen,
                Metodologia = certificadoDto.Instrumento.Clasificacion.TipoInstrumento.Metodologia,
                NombreResponsable = certificadoDto.Responsable.Nombre,
                CondicionesAmbientales = certificadoDto.CondicionesAmbientales,
                Cliente = certificadoDto.Instrumento.NombreEmpresa,
                Patrones = patrones,
                FechaCertificado = certificadoDto.Fecha,
                Alarmas = variablesInstrumentos.Select(y => new AlarmaDto
                {
                    Alta = y.AlarmaAlta.Value,
                    Baja = y.AlarmaBaja.Value,
                    Sensor = y.VariableDeMedicion.DescripcionCorta,
                    Stel = y.AlarmaStel.Value,
                    Twa = y.AlarmaTwa.Value
                }).ToList(),
                Mediciones = variablesDeMedicion.Select(y => new MedicionDto
                {
                    NombreVariable = y.Nombre,
                    VariableMedicionId = y.VariableMedicionId,
                    ValoresDeMedicion = mediciones
                }).ToList()
                
            };

            objectDataSource2.DataSource = reporte;
        }
    }
}
