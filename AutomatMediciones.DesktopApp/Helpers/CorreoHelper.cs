using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AutomatMediciones.DesktopApp.Helpers
{

    public class CorreoHelper
    {
        public bool EnviarCorreo(CorreoNotificacionDto correoDto)
        {
            var correo = AplicacionHelper.ObtenerCorreoNotificacion();
            var contrasenia = AplicacionHelper.ObtenerPassCorreoNotificacion();
            var host = AplicacionHelper.ObtenerHostCorreo();

            var server = new SmtpClient();

            server.DeliveryMethod = SmtpDeliveryMethod.Network;
            server.Host = host;
            server.Port = 587;


            server.ServicePoint.MaxIdleTime = 1;
            server.Timeout = 30000;
            server.EnableSsl = true;
            server.UseDefaultCredentials = true;
            server.Credentials = new NetworkCredential(correo, contrasenia);

            MailMessage message = new MailMessage();

            var body = correoDto.Body;


            var listaDestinatarios = string.Join(",", correoDto.CorreoDestinatario);
            var listaDestinatariosCopia = string.Join(",", correoDto.CopiasEnCorreo);


            try
            {
                message.From = new MailAddress(correo);
                message.To.Add(listaDestinatarios);
                message.Subject = correoDto.Configuracion.Asunto;
                message.SubjectEncoding = Encoding.UTF8;
                message.Body = body;
                message.Priority = MailPriority.Normal;
                message.IsBodyHtml = true;
                message.BodyEncoding = Encoding.UTF8;
                message.CC.Add(listaDestinatariosCopia);
                server.Host = host;


                server.Send(message);


                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public async Task<bool> EnviarEmail(CorreoNotificacionDto correoDto)
        {
            var llaveApi = correoDto.Configuracion.ApiKey;
            var cliente = new SendGridClient(llaveApi);
            var mensaje = new SendGridMessage()
            {
                From = new EmailAddress(correoDto.Configuracion.CorreoOrigen, correoDto.Configuracion.Nombre),
                Subject = $"{correoDto.Configuracion.Asunto} | Ingreso #{correoDto.IngresoId} | {correoDto.NombreEmpresa}",
                PlainTextContent = correoDto.Body,

            };

            mensaje.AddTo(new EmailAddress(correoDto.CorreoDestinatario, correoDto.NombreDestinatario));
            var respuesta = await cliente.SendEmailAsync(mensaje);

            if (respuesta.IsSuccessStatusCode) return true;
            else return false;

        }
    }
}
