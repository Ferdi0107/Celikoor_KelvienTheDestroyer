using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.SqlClient;

namespace KelvienTheDestroyerLIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;
        public Koneksi()
        {
            Configuration myC = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSettings = myC.SectionGroups["userSettings"];
            var sectionSetting = userSettings.Sections["Celikoor_Kel14.db"] as ClientSettingsSection;

            string vServer = sectionSetting.Settings.Get("server").Value.ValueXml.InnerText;
            string vDb = sectionSetting.Settings.Get("database").Value.ValueXml.InnerText;
            string vUID = sectionSetting.Settings.Get("uid").Value.ValueXml.InnerText;
            string vPwd = sectionSetting.Settings.Get("pwd").Value.ValueXml.InnerText;


            string connString = "Server=" + vServer + ";Database=" + vDb + ";Uid=" + vUID + ";Pwd=" + vPwd + ";default command timeout=60;";

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = connString;

            Connect();
        }
        public Koneksi(string pS, string pD, string pU, string pP)
        {
            string connString = "Server=" + pS + ";Database=" + pD + ";Uid=" + pU + ";Pwd=" + pP + ";";

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = connString;

            Connect();
        }

        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        public void Connect()
        {
            if(KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }
       
        public static void JalankanPerintahNonQuery(string perintah)
        {
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.KoneksiDB);

            cmd.ExecuteNonQuery();
        }
        public static MySqlDataReader JalankanPerintahReader(string perintah)
        {
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.KoneksiDB);

            MySqlDataReader drHasil = cmd.ExecuteReader();
            return drHasil;
        }
        private static void OpenSqlConnection()
        {
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("State: {0}", connection.State);
                Console.WriteLine("ConnectionTimeout: {0}",
                    connection.ConnectionTimeout);
            }
        }

        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file, using the
            // System.Configuration.ConfigurationSettings.AppSettings property
            return "Data Source=(local);Initial Catalog=AdventureWorks;"
                + "Integrated Security=SSPI;Connection Timeout=30";
        }
    }
}
