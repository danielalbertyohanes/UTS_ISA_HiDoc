using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapKakiTiga_LIB
{
    public class JanjiTemu
    {
        #region DATA MEMBERS
        private int id;
        private DateTime tglTemu;
        private string status;
        private Pasien pengguna;
        private Pekerja dokter;
        #endregion

        #region CONSTRUCTORS
        public JanjiTemu(int id, DateTime tglTemu, string status, Pasien pengguna, Pekerja dokter)
        {
            Id = id;
            TglTemu = tglTemu;
            Status = status;
            Pengguna = pengguna;
            Dokter = dokter;
        }

        public JanjiTemu() 
        {
            Id = 0;
            TglTemu = DateTime.Now;
            Status = "";
            Pengguna = new Pasien();
            Dokter = new Pekerja();
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public DateTime TglTemu { get => tglTemu; set => tglTemu = value; }
        public string Status { get => status; set => status = value; }
        public Pasien Pengguna { get => pengguna; set => pengguna = value; }
        public Pekerja Dokter { get => dokter; set => dokter = value; }
        #endregion

        #region METHODS
        public static void TambahData(JanjiTemu j)
        {
            EnkripsiAES aES = new EnkripsiAES();
            string sql = "INSERT INTO janji_temu (tgltemu, status, pasien_nik, pekerja_id) VALUES " +
                "('" + j.TglTemu.ToString("yyyy-MM-dd hh:mm:ss") + "', 'belum','" + aES.Encryption(j.Pengguna.Nik) + "', '" + j.Dokter.Id + "');";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static void UpdateStatus(string id)
        {
            EnkripsiAES aES = new EnkripsiAES();
            string sql = "UPDATE janji_temu SET status = 'sudah' WHERE id='" + id + "';";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static bool CekJanjiTemu(Pekerja dokter, DateTime tglJam)
        {
            string sql = "SELECT tgltemu FROM janji_temu WHERE tgltemu ='" + tglJam + "' AND pekerja_id = '" + dokter.Id + "'";
            MySqlDataReader dataReader = Koneksi.JalankanPerintahQuery(sql);
            if (dataReader.Read() == true)
                return true;
            return false;
        }

        public static List<JanjiTemu> BacaData(string kolom = "", string nilai = "")
        {
            EnkripsiAES aES = new EnkripsiAES();
            string sql;
            if (kolom == "") //jika user tidak memberikan filter
                sql = "select j.id, j.tgltemu, p.nama, pe.nama, j.status from janji_temu j inner join pasien p on j.pasien_nik = p.nik inner join pekerja pe on j.pekerja_id = pe.id;";
            else if (kolom == "j.pasien_nik")
                sql = "select j.id, j.tgltemu, p.nama, pe.nama, j.status from janji_temu j inner join pasien p on j.pasien_nik = p.nik inner join pekerja pe on j.pekerja_id = pe.id where " + kolom + " like '%" + aES.Encryption(nilai) + "%';";
            else //jika ada filter
                sql = "select j.id, j.tgltemu, p.nama, pe.nama, j.status from janji_temu j inner join pasien p on j.pasien_nik = p.nik inner join pekerja pe on j.pekerja_id = pe.id where " + kolom + " like '%" + nilai + "%';";

            // STEP 2. JALANkan perintah query
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            // STEP 3. pindahkan datareader ke list
            List<JanjiTemu> listData = new List<JanjiTemu>();
            while (hasil.Read() == true)
            {
                JanjiTemu j = new JanjiTemu();
                j.Id = int.Parse(hasil.GetValue(0).ToString());
                j.TglTemu = DateTime.Parse(hasil.GetValue(1).ToString());
                
                Pasien p = new Pasien();
                p.Nama = aES.Decryption(hasil.GetValue(2).ToString());

                Pekerja pe = new Pekerja();
                pe.Nama = aES.Decryption(hasil.GetValue(3).ToString());
                j.Status = hasil.GetValue(4).ToString();
                j.Pengguna = p;
                j.Dokter = pe;
                listData.Add(j); //tambahkan objek kategori ke list
            }
            return listData;
        }
        #endregion
    }
}
