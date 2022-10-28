using AutomatMediciones.Libs.Dtos;

namespace AutomatMediciones.DesktopApp.Pantallas.Diagnosticos.Dtos
{

    public class IngresoInstrumento : IngresoInstrumentoDto
    {
        public string ClasificacionConcatenada { get; set; }
        public bool Seleccionado { get; set; }
    }
}
