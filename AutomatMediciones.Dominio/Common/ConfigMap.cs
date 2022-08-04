using AutoMapper;
using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using AutomatMediciones.Libs.Dtos;

namespace AutomatMediciones.Dominio.Common
{
    public class ConfigMap : Profile
    {
        public ConfigMap() : base("TacticaProfile")
        {
            CreateMap<Estado, EstadoDto>().ReverseMap();
            CreateMap<Ingreso, IngresoDto>().ReverseMap();
            CreateMap<Instrumento, InstrumentoDto>().ReverseMap();
            CreateMap<Marca, MarcaDto>().ReverseMap();
            CreateMap<Modelo, ModeloDto>().ReverseMap();
            CreateMap<TipoInstrumento, TipoInstrumentoDto>().ReverseMap();
            CreateMap<TipoTrabajo, TipoTrabajoDto>().ReverseMap();
            CreateMap<ClasificacionInstrumento, ClasificacionInstrumentoDto>().ReverseMap();
            CreateMap<VariableDeMedicion, VariableMedicionDto>().ReverseMap();
            CreateMap<TipoInstrumentoVariable, TipoInstrumentoVariableDto>().ReverseMap();
            CreateMap<IngresoInstrumento, IngresoInstrumentoDto>().ReverseMap();
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<Empresa, EmpresaDto>().ReverseMap();
            CreateMap<ConfiguracionNotificacion, ConfiguracionNotificacionDto>().ReverseMap();
            CreateMap<Patron, PatronDto>().ReverseMap();
            CreateMap<VariableInstrumento, VariableInstrumentoDto>().ReverseMap();
            CreateMap<VariablePatron, VariablePatronDto>().ReverseMap();
            CreateMap<Certificado, CertificadoDto>().ReverseMap();
            CreateMap<VariableCertificado, VariableCertificadoDto>().ReverseMap();
            CreateMap<TipoCelda, TipoCeldaDto>().ReverseMap();
            CreateMap<Celda, CeldaDto>().ReverseMap();
            CreateMap<TipoCeldaModelo, TipoCeldaModeloDto>().ReverseMap();
            CreateMap<CeldaInstrumento, CeldaInstrumentoDto>().ReverseMap();
            CreateMap<EstadoCelda, EstadoCeldaDto>().ReverseMap();

        }
    }
}
