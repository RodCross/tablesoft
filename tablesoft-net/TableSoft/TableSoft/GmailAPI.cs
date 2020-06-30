/**
 * NO TOCAR ESTA CLASE POR NADA DEL MUNDO
 * HASTA QUE LA LOGICA DE ENVIO DE MENSAJES
 * ESTE CORRECTAMENTE ENLAZADA CON LOS FORMULARIOS
 * DE "OLVIDASTE TU PASSWORD". POR FAVOR NO PERMITAS
 * QUE TENGAMOS QUE HACER TODO ESTO DE NUEVO
 */

using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;

namespace TableSoft
{
    public class GmailAPI
    {
        private static string[] Scopes = { GmailService.Scope.GmailCompose };
        private static string ApplicationName = "Yanapay Desktop";

        public void ConectarAPI()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            UsersResource.LabelsResource.ListRequest request = service.Users.Labels.List("me");

            YanapayEmail email = new YanapayEmail()
            {
                FromAddress = "noreply.yanapay@gmail.com",
                ToRecipients = "correodelreceptor123abc@gmail.com",
                Subject = "Asunto",
                Body = "Cuerpo",
                IsHtml = false
            };

            SendEmail(email, service);
        }

        public static void SendEmail(YanapayEmail email, GmailService service)
        {
            var mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.From = new System.Net.Mail.MailAddress(email.FromAddress);
            mailMessage.To.Add(email.ToRecipients);
            mailMessage.ReplyToList.Add(email.FromAddress);
            mailMessage.Subject = email.Subject;
            mailMessage.Body = email.Body;
            mailMessage.IsBodyHtml = email.IsHtml;

            // Por si necesitamos enviar archivos adjuntos alguna vez.
            // No lo creo necesario por ahora, pero borrémoslo cuando estemos seguros.

            //foreach (System.Net.Mail.Attachment attachment in email.Attachments)
            //{
            //    mailMessage.Attachments.Add(attachment);
            //}

            var mimeMessage = MimeKit.MimeMessage.CreateFromMailMessage(mailMessage);

            var gmailMessage = new Google.Apis.Gmail.v1.Data.Message
            {
                Raw = Encode(mimeMessage.ToString())
            };

            Google.Apis.Gmail.v1.UsersResource.MessagesResource.SendRequest request = service.Users.Messages.Send(gmailMessage, "me");

            request.Execute();
        }

        public static string Encode(string text)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(text);

            return System.Convert.ToBase64String(bytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }
    }
}
