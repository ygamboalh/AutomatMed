using AutoMapper;
using TacticaReparaciones.Libs.Dtos;
using TacticaReparaciones.Servicios.Caracteristicas.Entidades;

namespace TacticaReparaciones.Servicios.Common
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
        }
    }
}
