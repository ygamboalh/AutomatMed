using AutomatMediciones.Libs.Dtos;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos
{
    public class InstrumentoLista : InstrumentoDto
    {
        public bool Seleccionado { get; set; }
        public string Comentarios { get; set; }
    }
}
