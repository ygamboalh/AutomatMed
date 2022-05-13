using AutomatMediciones.Libs.Dtos;
using System.Collections.Generic;
using System.IO;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos
{
    public class CorreoNotificacionDto
    {
        public ConfiguracionNotificacionDto Configuracion { get; set; }
        public string Body { get; set; }
        public List<string> CopiasEnCorreo { get; set; }
        public string CorreoDestinatario { get; set; }
        public string NombreDestinatario { get; set; }
        public string NombreEmpresa { get; set; }
        public int IngresoId { get; set; }
        public Dictionary<string, Stream>? Adjuntos { get; set; }
        public string AdjuntoMediaType { get; set; }
    }

    public class CorreoNotificacionCambioResponsableDto
    {
        public ConfiguracionNotificacionDto Configuracion { get; set; }
        public string Body { get; set; }     
        public string CorreoDestinatario { get; set; }
        public string NombreDestinatario { get; set; }
    }
}
