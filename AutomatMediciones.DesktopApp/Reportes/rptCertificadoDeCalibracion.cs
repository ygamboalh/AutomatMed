using AutomatMediciones.DesktopApp.Reportes.Dtos;
using AutomatMediciones.Dominio.Caracteristicas.Servicios;
using AutomatMediciones.Libs.Dtos;
using System.Linq;

namespace AutomatMediciones.DesktopApp.Reportes
{
    public partial class rptCertificadoCalibracion : DevExpress.XtraReports.UI.XtraReport
    {
        private readonly PatronService _patronService;
        private readonly CertificadoCalibracionService _certificadoCalibracionService;
        private readonly InstrumentoService _instrumentoService;
        private readonly VariableMedicionService _variableMedicionService;

        public rptCertificadoCalibracion(PatronService patronService, CertificadoCalibracionService certificadoCalibracionService,
            InstrumentoService instrumentoService, VariableMedicionService variableMedicionService)
        {
            InitializeComponent();
            _patronService = patronService;
            _certificadoCalibracionService = certificadoCalibracionService;
            _instrumentoService = instrumentoService;
            _variableMedicionService = variableMedicionService;
        }

        public void PrepararCertificado(CertificadoDto certificadoDto)
        {
            var variablesCertificados = _certificadoCalibracionService.ObtenerVariablesCertificados(certificadoDto.CertificadoId).Data;
            var patronesIdsVariablesCertificados = variablesCertificados.Select(x => x.PatronId).ToList();

            var patrones = _patronService.ObtenerPatrones(patronesIdsVariablesCertificados).Data;
            var patronesIds = patrones.Select(x => x.PatronId).ToList();

            var variablesPatrones = _patronService.ObtenerVariablesPatrones(patronesIds).Data;
            var variablesCertificadosVariablesInstrumentosIds = variablesCertificados.Select(x => x.VariableInstrumentoId).ToList();
            var variablesPatronesVariablesMedicionIds = variablesPatrones.Select(x => x.VariableMeicionId).ToList();

            var variablesInstrumentos = _instrumentoService.ObtenerVariablesInstrumentos(variablesCertificadosVariablesInstrumentosIds).Data;
            var variablesInstrumentosVariablesMedicionIds = variablesInstrumentos.Select(x => x.VariableMedicionId).ToList();

            var variablesDeMedicion = _variableMedicionService.ObtenerVariablesDeMedicion(variablesPatronesVariablesMedicionIds, variablesInstrumentosVariablesMedicionIds).Data;

            var variablesInstrumentosParaAlarmas = variablesInstrumentos.Where(x => variablesDeMedicion.Select(p => p.VariableMedicionId).Contains(x.VariableMedicionId)).ToList();

            var mediciones = (from variableCertificado in variablesCertificados
                              join patron in patrones on variableCertificado.PatronId equals patron.PatronId
                              join variablePatron in variablesPatrones on patron.PatronId equals variablePatron.PatronId
                              join variableInstrumento in variablesInstrumentos on variableCertificado.VariableInstrumentoId equals variableInstrumento.VariableInstrumentoId
                              join variableMedicion in variablesDeMedicion on new { p1 = variableInstrumento.VariableMedicionId, p2 = variablePatron.VariableMeicionId } equals new { p1 = variableMedicion.VariableMedicionId, p2 = variableMedicion.VariableMedicionId }
                              select new ValorMedicionDto
                              {
                                  VariableMedicionId = variableMedicion.VariableMedicionId,
                                  ValorPatron = variablePatron.ValorPatron,
                                  ToleranciaPatron = variablePatron.Tolerancia,
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
                Cliente = certificadoDto.Instrumento.NombreEmpresa,
                Patrones = patrones.Select(x => x.Nombre).ToList(),
                FechaCertificado = certificadoDto.Fecha,
                Alarmas = variablesInstrumentosParaAlarmas.Select(y => new AlarmaDto
                {
                    Alta = y.AlarmaAlta.Value,
                    Baja = y.AlarmaBaja.Value,
                    Sensor = variablesDeMedicion.FirstOrDefault(p => p.VariableMedicionId == y.VariableMedicionId).DescripcionCorta,
                    Stel = y.AlarmaStel.Value,
                    Twa = y.AlarmaTwa.Value
                }).ToList(),
                Mediciones = variablesDeMedicion.Select(y => new MedicionDto
                {
                    CondicionesAmbientales = certificadoDto.CondicionesAmbientales,
                    NombreVariable = y.Nombre,
                    VariableMedicionId = y.VariableMedicionId,
                    ValoresDeMedicion = mediciones.Where(x => x.VariableMedicionId == y.VariableMedicionId).ToList()
                }).ToList(),
                Medicion = variablesDeMedicion.Select(x => x.DescripcionCorta).ToList(),
                Resultado = certificadoDto.Resultado,
                Observaciones = certificadoDto.Observaciones
            };

            objectDataSource2.DataSource = reporte;
        }
    }
}
