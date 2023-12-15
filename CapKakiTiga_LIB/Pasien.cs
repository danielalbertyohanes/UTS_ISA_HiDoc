using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapKakiTiga_LIB
{
    public class Pasien
    {
        #region DATAMEMBERS
        private string nik;
        private string nama;
        private string tglLahir;
        private string alamat;
        private string noHp;
        private string email;
        private string password;
        #endregion

        #region CONSTRUCTORS
        public Pasien()
        {
            this.Nik = "";
            this.Nama = "";
            this.TglLahir = "";
            this.Alamat = "";
            this.NoHp = "";
            this.Email = "";
            this.Password = "";
        }
        public Pasien(string nik, string nama, string tglLahir, string alamat, string noHp, string email, string password)
        {
            this.Nik = nik;
            this.Nama = nama;
            this.TglLahir = tglLahir;
            this.Alamat = alamat;
            this.NoHp = noHp;
            this.Email = email;
            this.Password = password;
        }
        #endregion

        #region PROPERTIES
        public string Nik { get => nik; set => nik = value; }
        public string Nama { get => nama; set => nama = value; }
        public string TglLahir { get => tglLahir; set => tglLahir = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string NoHp { get => noHp; set => noHp = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region METHODS
        public static Pasien CekLoginPasien(string email, string password)
        {
            EnkripsiAES aES = new EnkripsiAES();
            Hashing hashing = new Hashing();

            string emailEncrypt = aES.Encryption(email);
            string passEncrypt = hashing.Encrypt(password);

            string sql = "select * from pasien where email='" + emailEncrypt + "' and password='" + passEncrypt + "';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            Pasien userLogin = new Pasien();
            if (hasil.Read() == true)
            {   //urutan GetValue(0) adalah sesuai dengan SQL yang sudah disusun
                //jika menggunakan select * maka urutan sesuai dengan urutan dalam tabel yang dituju
                userLogin.Nik = aES.Decryption(hasil.GetValue(0).ToString());
                userLogin.Nama = aES.Decryption(hasil.GetValue(1).ToString());
                userLogin.TglLahir = aES.Decryption(hasil.GetValue(2).ToString());
                userLogin.Alamat = aES.Decryption(hasil.GetValue(3).ToString());
                userLogin.NoHp = aES.Decryption(hasil.GetValue(4).ToString());
                userLogin.Email = aES.Decryption(hasil.GetValue(5).ToString());
            }
            else //jika username dan pwd tdk terdaftar, kembalikan null
                userLogin = null;
            return userLogin;
        }

        public static List<Pasien> BacaData(string kolom = "", string nilai = "")
        {
            EnkripsiAES aES = new EnkripsiAES();
            string sql;
            if (kolom == "") //jika user tidak memberikan filter
                sql = "select * from pasien;";
            else //jika ada filter
                sql = "select * from pasien where " + kolom + " like '%" + nilai + "%';";

            // STEP 2. JALANkan perintah query
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            // STEP 3. pindahkan datareader ke list
            List<Pasien> listData = new List<Pasien>();
            while (hasil.Read() == true)
            {
                Pasien p = new Pasien();

                p.Nik = aES.Decryption(hasil.GetValue(0).ToString());
                p.Nama = aES.Decryption(hasil.GetValue(1).ToString());
                p.TglLahir = aES.Decryption(hasil.GetValue(2).ToString());
                p.Alamat = aES.Decryption(hasil.GetValue(3).ToString());
                p.NoHp = aES.Decryption(hasil.GetValue(4).ToString());
                p.Email = aES.Decryption(hasil.GetValue(5).ToString());

                //kosongi password, karena tdk boleh membaca password orang lain
                listData.Add(p); //tambahkan objek kategori ke list
            }
            return listData;
        }

        public static void TambahData(Pasien p)
        {
            EnkripsiAES aES = new EnkripsiAES();
            Hashing hashing = new Hashing();

            string sql = "INSERT INTO pasien (nik, nama, tgllahir, alamat, noHP, email, password) VALUES " +
                "('" + aES.Encryption(p.Nik) + "', '" + aES.Encryption(p.Nama) + "', '" + aES.Encryption(p.TglLahir) + "', " +
                "'" + aES.Encryption(p.Alamat) + "', '" + aES.Encryption(p.NoHp) + "', '" + aES.Encryption(p.Email) + "', " +
                "'" + hashing.Encrypt(p.Password) + "');";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public override string ToString()
        {
            return this.Nama.ToString();
        }
        #endregion
    }
}
