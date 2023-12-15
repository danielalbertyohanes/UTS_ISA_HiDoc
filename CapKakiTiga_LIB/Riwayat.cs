using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapKakiTiga_LIB
{
    public class Riwayat
    {
        #region DATA MEMBERS
        private int id;
        private string hasilPeriksa;
        private JanjiTemu janji;
        #endregion

        #region CONSTRUCTORS
        public Riwayat(int id, string hasilPeriksa, JanjiTemu janji)
        {
            Id = id;
            HasilPeriksa = hasilPeriksa;
            Janji = janji;
        }
        
        public Riwayat()
        {
            Id = 0;
            HasilPeriksa = "";
            Janji = new JanjiTemu();
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string HasilPeriksa { get => hasilPeriksa; set => hasilPeriksa = value; }
        public JanjiTemu Janji { get => janji; set => janji = value; }
        #endregion

        #region METHODS
        public static void TambahData(Riwayat r)
        {
            EnkripsiAES aES = new EnkripsiAES();

            string sql = "INSERT INTO riwayat (hasilperiksa, janji_temu_id) VALUES ('" + aES.Encryption(r.HasilPeriksa) + "', '" + r.Janji.Id + "');";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public static List<Riwayat> BacaData(string kolom = "", string nilai = "")
        {
            EnkripsiAES aES = new EnkripsiAES();
            string sql;
            if (kolom == "") //jika user tidak memberikan filter
                sql = "select * from riwayat;";
            else //jika ada filter
                sql = "select * from riwayat where " + kolom + " like '%" + nilai + "%';";

            // STEP 2. JALANkan perintah query
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            // STEP 3. pindahkan datareader ke list
            List<Riwayat> listData = new List<Riwayat>();
            while (hasil.Read() == true)
            {
                Riwayat r = new Riwayat();
                r.Id = int.Parse(hasil.GetValue(0).ToString());
                r.HasilPeriksa = aES.Decryption(hasil.GetValue(1).ToString());

                JanjiTemu j = new JanjiTemu();
                j.Id = int.Parse(hasil.GetValue(2).ToString());
                r.Janji = j;
                
                listData.Add(r); //tambahkan objek kategori ke list
            }
            return listData;
        }

        public static void PrintHasilPeriksa(string printKriteria, string nilaiKriteria, JanjiTemu janjiTemu, string fileName, Font fontType)
        {
            List<Riwayat> listHasil = new List<Riwayat>();
            listHasil = Riwayat.BacaData(printKriteria, nilaiKriteria);

            StreamWriter tempFile = new StreamWriter(fileName);
            foreach (Riwayat r in listHasil)
            {
                tempFile.WriteLine("");
                tempFile.WriteLine("Check Up Result");
                tempFile.WriteLine("=".PadRight(50, '='));
                tempFile.WriteLine("Name            : " + janjiTemu.Pengguna.Nama);
                tempFile.WriteLine("Date   : " + janjiTemu.TglTemu);
                tempFile.WriteLine("Doctor          : " + janjiTemu.Dokter);
                tempFile.WriteLine("");
                tempFile.WriteLine("Result : ");
                tempFile.WriteLine(r.hasilPeriksa);
                tempFile.WriteLine("");

            }
            tempFile.Close();

            Cetak c = new Cetak(fontType, fileName, 20, 10, 10, 10);
            c.KirimkePrinter();
        }

        public override string ToString()
        {
            return this.HasilPeriksa.ToString();
        }
        #endregion
    }
}
