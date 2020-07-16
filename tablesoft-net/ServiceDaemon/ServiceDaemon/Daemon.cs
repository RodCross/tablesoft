using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDaemon
{
    partial class Daemon : ServiceBase
    {
        public Daemon()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            stLapso.Start();
        }

        protected override void OnStop()
        {
            stLapso.Stop();
        }

        private void stLapso_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MySqlConnection con;
            MySqlCommand comando;
            try
            {
                con = new MySqlConnection(DBManager.cadenaConexion);
                con.Open();
                comando = new MySqlCommand();
                comando.Connection = con;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "actualizar_retraso";
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                EventLog.WriteEntry(ex.Message, EventLogEntryType.Error);
            }

        }
    }
}
