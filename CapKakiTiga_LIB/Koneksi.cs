using MySql.Data.MySqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapKakiTiga_LIB
{
    public class Koneksi
    {
        #region data members
        private MySqlConnection koneksiDB;
        #endregion

        #region constructor
        public Koneksi()
        {
            //buka konfigurasi App.Config
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //Ambil section userSettings yang otomatis dibuat berdasarkan file .settings
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            //Ambil bagian setting SistemPenjualanPembelian.db
            var settingsSection = userSettings.Sections["ProjekUTS_CapKakiTiga.db"] as ClientSettingsSection;

            //Ambil tiap variable setting
            string DbServer = settingsSection.Settings.Get("dbServer").Value.ValueXml.InnerText;
            string DbName = settingsSection.Settings.Get("dbName").Value.ValueXml.InnerText;
            string DbUsername = settingsSection.Settings.Get("dbUID").Value.ValueXml.InnerText;
            string DbPassword = settingsSection.Settings.Get("dbPWD").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUsername + ";password=" + DbPassword;
            koneksiDB = new MySqlConnection();

            koneksiDB.ConnectionString = strCon;
            Connect();


        }
        public Koneksi(string pServer, string pDb, string pUID, string pPWD)
        {
            string vConnString = "Server=" + pServer + ";Database=" + pDb + ";Uid=" + pUID + ";Pwd=" + pPWD + ";";

            koneksiDB = new MySqlConnection();
            koneksiDB.ConnectionString = vConnString;

            koneksiDB.Open();
        }
        #endregion

        #region properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region method
        public void Connect()
        {
            if (koneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            koneksiDB.Open();
        }

        public static MySqlDataReader JalankanPerintahQuery(string sql)
        {
            //untuk select
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            MySqlDataReader hasil = c.ExecuteReader();
            return hasil;
        }
        public static void JalankanPerintahNonQuery(string sql)
        {
            //untuk insert update delete
            Koneksi k = new Koneksi();
            MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB);
            c.ExecuteNonQuery();
        }
        #endregion
    }
}
