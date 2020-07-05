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
        public string Saludar(string a)
        {
            return "Hello " + a;
        }
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
    }
}
