using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TableSoftEmail
{
    [WebService(Namespace = "http://pucp.edu.pe/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class EmailWS : System.Web.Services.WebService
    {
        [WebMethod]
        public bool EnviarCorreo(YanapayEmail email)
        {
            try
            {
                GmailAPI.ConectarAPI(email);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return false;
            }
        }
        [WebMethod]
        public string EnviarCorreoString(string subject,string body, string recipient)
        {
            try
            {
                YanapayEmail email = new YanapayEmail()
                {
                    FromAddress = "noreply.yanapay@gmail.com",
                    ToRecipients = recipient,
                    Subject = subject,
                    Body = body,
                    IsHtml = false
                };
                GmailAPI.ConectarAPI(email);
                return "enviado";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
    }
}
