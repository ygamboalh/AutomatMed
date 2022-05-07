using AutomatMediciones.Libs.Dtos;
using System;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos
{
    public class InstrumentoLista : InstrumentoDto
    {
        public bool Seleccionado { get; set; }
        public string ClasificacionConcatenada { get; set; }
        public InformacionAdicionalInstrumento InformacionAdicional { get; set; }

    }

    public class InformacionAdicionalInstrumento
    {
        public TipoTrabajoDto TipoTrabajo { get; set; }
        public int InstrumentoId { get; set; }
        public DateTime? FechaEntregaRequerida { get; set; }
        public int Prioridad { get; set; }
        public string Comentarios { get; set; }
        public int TipoTrabajoId { get; set; }
        public string ComentariosAcercaDelInstrumento { get; set; }
    }
}
