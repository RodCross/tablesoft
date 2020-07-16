using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableSoft
{
    class EnvioCorreoNotificacion
    {
        private static EmailWS.EmailWSSoapClient servicioEmail = new EmailWS.EmailWSSoapClient();
        
        public static bool NuevoComentario(TicketWS.ticket ticket, TicketWS.empleado emp)
        {

            StreamReader streamReader = new StreamReader("../../emails/EmailNotificacionComentario.html", System.Text.Encoding.UTF8);
            string body = streamReader.ReadToEnd();
            body = body.Replace("*NOMBREPH*", emp.nombre);
            body = body.Replace("*APELLIDOPH*", emp.apellidoPaterno);
            body = body.Replace("*TIPOPH*", "agente");
            body = body.Replace("*TICKETIDPH*", ticket.ticketId.ToString());
            body = body.Replace("*ASUNTOPH*", ticket.asunto);

            EmailWS.YanapayEmail correo = new EmailWS.YanapayEmail();
            correo.FromAddress = "noreply.yanapay@gmail.com";
            correo.ToRecipients = emp.personaEmail;
            correo.Subject = "Yanapay - Nuevo comentario";
            correo.Body = body;
            correo.IsHtml = true;

            return servicioEmail.EnviarCorreo(correo);
        }

        public static bool NuevoComentario(TicketWS.ticket ticket, TicketWS.agente age)
        {

            StreamReader streamReader = new StreamReader("../../emails/EmailNotificacionComentario.html", System.Text.Encoding.UTF8);
            string body = streamReader.ReadToEnd();
            body = body.Replace("*NOMBREPH*", age.nombre);
            body = body.Replace("*APELLIDOPH*", age.apellidoPaterno);
            body = body.Replace("*TIPOPH*", "empleado");
            body = body.Replace("*TICKETIDPH*", ticket.ticketId.ToString());
            body = body.Replace("*ASUNTOPH*", ticket.asunto);

            EmailWS.YanapayEmail correo = new EmailWS.YanapayEmail();
            correo.FromAddress = "noreply.yanapay@gmail.com";
            correo.ToRecipients = age.personaEmail;
            correo.Subject = "Yanapay - Nuevo comentario";
            correo.Body = body;
            correo.IsHtml = true;

            return servicioEmail.EnviarCorreo(correo);
        }

        public static bool NuevoCambioEstado(TicketWS.ticket ticket, TicketWS.cambioEstadoTicket update)
        {
            StreamReader streamReader = new StreamReader("../../emails/EmailNotificacionEstado.html", System.Text.Encoding.UTF8);
            string body = streamReader.ReadToEnd();
            body = body.Replace("*ROLPH*", frmLogin.agenteLogueado.rol.nombre.ToLower());
            body = body.Replace("*TICKETIDPH*", ticket.ticketId.ToString());
            body = body.Replace("*ASUNTOPH*", ticket.asunto);
            body = body.Replace("*ESTADOPH*", update.estadoTo.nombre);
            body = body.Replace("*COMENTARIOPH*", update.comentario);

            EmailWS.YanapayEmail correo = new EmailWS.YanapayEmail();
            correo.FromAddress = "noreply.yanapay@gmail.com";
            correo.ToRecipients = ticket.alumnoEmail;
            correo.Subject = "Yanapay - Nueva actualización";
            correo.Body = body;
            correo.IsHtml = true;

            return servicioEmail.EnviarCorreo(correo);
        }

        public static bool NuevoTicketEnviado(TicketWS.ticket ticket)
        {
            StreamReader streamReader = new StreamReader("../../emails/EmailTicketEnviado.html", System.Text.Encoding.UTF8);
            string body = streamReader.ReadToEnd();
            body = body.Replace("*TICKETIDPH*", ticket.ticketId.ToString());
            body = body.Replace("*ASUNTOPH*", ticket.asunto);

            EmailWS.YanapayEmail correo = new EmailWS.YanapayEmail();
            correo.FromAddress = "noreply.yanapay@gmail.com";
            correo.ToRecipients = ticket.alumnoEmail;
            correo.Subject = "Yanapay - Nuevo ticket enviado";
            correo.Body = body;
            correo.IsHtml = true;

            return servicioEmail.EnviarCorreo(correo);
        }
    }
}
