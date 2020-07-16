using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDaemon
{
    public abstract class DBManager
    {
        public static String type = "mysql";
        public static String urlMySQL = "server = lp2-pixies.chjoagiapimg.us-east-1.rds.amazonaws.com;";
        public static String user = "user=admin;";
        public static String password = "password=yosoyellobo;";
        public static String database = "database=dbpixies;";
        public static String port = "port=3306;";
        public static String cadenaConexion = urlMySQL + user + password + database + port;
    }
}
