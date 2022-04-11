using AutoMapper;
using AutomatMediciones.Libs.Dtos;
using AutomatMediciones.Servicios.Caracteristicas.Entidades;

namespace AutomatMediciones.Servicios.Common
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
        }
    }
}
