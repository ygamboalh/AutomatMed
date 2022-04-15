using AutomatMediciones.Libs.Dtos;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;

namespace AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos
{
    public class CorreoNotificacionDto
    {
        public ConfiguracionNotificacionDto Configuracion { get; set; }
        public string Body { get; set; }
        public List<EmailAddress> CopiasEnCorreo { get; set; }
        public string CorreoDestinatario { get; set; }
        public string NombreDestinatario { get; set; }
        public string NombreEmpresa { get; set; }
    }
}
