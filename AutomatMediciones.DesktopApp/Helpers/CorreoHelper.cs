using AutomatMediciones.DesktopApp.Pantallas.Ingresos.Dtos;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace AutomatMediciones.DesktopApp.Helpers
{
    public class CorreoHelper
    {
        private bool RemoteServerCertificateValidationCallback(object sender,
                                                               System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                                                               System.Security.Cryptography.X509Certificates.X509Chain chain,
                                                               System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public bool EnviarCorreo(CorreoNotificacionDto correoDto)
        {
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(RemoteServerCertificateValidationCallback);

            var server = new SmtpClient(correoDto.Configuracion.Servidor, correoDto.Configuracion.Puerto);

            server.DeliveryMethod = SmtpDeliveryMethod.Network;
            server.Host = correoDto.Configuracion.Servidor;
            server.Port = correoDto.Configuracion.Puerto;
            server.ServicePoint.MaxIdleTime = 1;
            server.Timeout = 30000;
            server.EnableSsl = true;
            server.UseDefaultCredentials = false;
            server.Credentials = new NetworkCredential(correoDto.Configuracion.CorreoOrigen, correoDto.Configuracion.Password);

            MailMessage message = new MailMessage();
            var body = correoDto.Body;

            var listaDestinatarios = string.Join(",", correoDto.CorreoDestinatario);
            var listaDestinatariosCopia = string.Join(",", correoDto.CopiasEnCorreo);

            try
            {
                message.From = new MailAddress(correoDto.Configuracion.CorreoOrigen, correoDto.Configuracion.Nombre);
                message.To.Add(listaDestinatarios);
                message.Subject = correoDto.Configuracion.Asunto;
                message.SubjectEncoding = Encoding.UTF8;
                message.Body = body;
                message.Priority = MailPriority.Normal;
                message.IsBodyHtml = true;
                message.BodyEncoding = Encoding.UTF8;

                if (listaDestinatariosCopia.Any()) message.CC.Add(listaDestinatariosCopia);

                server.Host = correoDto.Configuracion.Servidor;

                if (correoDto.Adjuntos != null)
                {
                    foreach (var item in correoDto.Adjuntos)
                    {
                        Stream archivo = item.Value;
                        string nombre = item.Key;

                        archivo.Seek(0, SeekOrigin.Begin);
                        message.Attachments.Add(new Attachment(archivo, nombre, correoDto.AdjuntoMediaType));
                    }
                }

                server.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool EnviarCorreo(CorreoNotificacionCambioResponsableDto correoDto)
        {
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(RemoteServerCertificateValidationCallback);

            var server = new SmtpClient(correoDto.Configuracion.Servidor, correoDto.Configuracion.Puerto);

            server.DeliveryMethod = SmtpDeliveryMethod.Network;
            server.Host = correoDto.Configuracion.Servidor;
            server.Port = correoDto.Configuracion.Puerto;
            server.ServicePoint.MaxIdleTime = 1;
            server.Timeout = 30000;
            server.EnableSsl = true;
            server.UseDefaultCredentials = false;
            server.Credentials = new NetworkCredential(correoDto.Configuracion.CorreoOrigen, correoDto.Configuracion.Password);

            MailMessage message = new MailMessage();
            var body = correoDto.Body;

            var listaDestinatarios = string.Join(",", correoDto.CorreoDestinatario); 
            try
            {
                message.From = new MailAddress(correoDto.Configuracion.CorreoOrigen, correoDto.Configuracion.Nombre);
                message.To.Add(listaDestinatarios);
                message.Subject = correoDto.Configuracion.Asunto;
                message.SubjectEncoding = Encoding.UTF8;
                message.Body = body;
                message.Priority = MailPriority.Normal;
                message.IsBodyHtml = true;
                message.BodyEncoding = Encoding.UTF8;

                server.Host = correoDto.Configuracion.Servidor;

                server.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
