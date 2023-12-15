using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapKakiTiga_LIB
{
    public class Pekerja
    {
        #region DATAMEMBERS
        private int id;
        private string nik;
        private string nama;
        private string tglLahir;
        private string alamat;
        private string noHp;
        private DateTime tglMulaiBekerja;
        private string email;
        private string password;
        private Jabatan posisi;
        #endregion

        #region CONSTRUCTORS
        public Pekerja(int id, string nik, string nama, string tglLahir, string alamat, string noHp, DateTime tglMulaiBekerja, string email, string password, Jabatan posisi)
        {
            Id = id;
            Nik = nik;
            Nama = nama;
            TglLahir = tglLahir;
            Alamat = alamat;
            NoHp = noHp;
            TglMulaiBekerja = tglMulaiBekerja;
            Email = email;
            Password = password;
            Posisi = posisi;
        }

        public Pekerja() 
        {
            Id = 0;
            Nik = "";
            Nama = "";
            TglLahir = "";
            Alamat = "";
            NoHp = "";
            TglMulaiBekerja = DateTime.Now;
            Email = "";
            Password = "";
            Posisi = new Jabatan();
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nik { get => nik; set => nik = value; }
        public string Nama { get => nama; set => nama = value; }
        public string TglLahir { get => tglLahir; set => tglLahir = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string NoHp { get => noHp; set => noHp = value; }
        public DateTime TglMulaiBekerja { get => tglMulaiBekerja; set => tglMulaiBekerja = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public Jabatan Posisi { get => posisi; set => posisi = value; }
        #endregion

        #region METHODS
        public static Pekerja CekLoginPekerja(string email, string password)
        {
            EnkripsiAES aES = new EnkripsiAES();
            Hashing hashing = new Hashing();

            string emailEncrypt = aES.Encryption(email);
            string passEncrypt = hashing.Encrypt(password);

            string sql = "select * from pekerja p inner join jabatan j on p.jabatan_id = j.id where p.email='" + emailEncrypt + "' and p.password='" + passEncrypt + "';";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            Pekerja userLogin = new Pekerja();
            if (hasil.Read() == true)
            {   //urutan GetValue(0) adalah sesuai dengan SQL yang sudah disusun
                //jika menggunakan select * maka urutan sesuai dengan urutan dalam tabel yang dituju
                userLogin.Id = int.Parse(hasil.GetValue(0).ToString());
                userLogin.Nik = aES.Decryption(hasil.GetValue(1).ToString());
                userLogin.Nama = aES.Decryption(hasil.GetValue(2).ToString());
                userLogin.TglLahir = aES.Decryption(hasil.GetValue(3).ToString());
                userLogin.Alamat = aES.Decryption(hasil.GetValue(4).ToString());
                userLogin.NoHp = aES.Decryption(hasil.GetValue(5).ToString());
                userLogin.TglMulaiBekerja = DateTime.Parse(hasil.GetValue(6).ToString());
                userLogin.Email = aES.Decryption(hasil.GetValue(7).ToString());

                Jabatan j = new Jabatan();
                j.Id = int.Parse(hasil.GetValue(9).ToString());
                j.Nama = hasil.GetValue(11).ToString();
                userLogin.Posisi = j;
            }
            else //jika username dan pwd tdk terdaftar, kembalikan null
                userLogin = null;
            return userLogin;
        }

        public static List<Pekerja> BacaData(string kolom = "", string nilai = "")
        {
            EnkripsiAES aES = new EnkripsiAES();
            string sql;
            if (kolom == "") //jika user tidak memberikan filter
                sql = "select * from pekerja pe inner join jabatan j on pe.jabatan_id = j.id;";
            else //jika ada filter
                sql = "select * from pekerja pe inner join jabatan j on pe.jabatan_id = j.id where " + kolom + " like '%" + nilai + "%';";

            // STEP 2. JALANkan perintah query
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            // STEP 3. pindahkan datareader ke list
            List<Pekerja> listData = new List<Pekerja>();
            while (hasil.Read() == true)
            {
                Pekerja p = new Pekerja();

                p.Id = int.Parse(hasil.GetValue(0).ToString());
                p.Nik = aES.Decryption(hasil.GetValue(1).ToString());
                p.Nama = aES.Decryption(hasil.GetValue(2).ToString());
                p.TglLahir = aES.Decryption(hasil.GetValue(3).ToString());
                p.Alamat = aES.Decryption(hasil.GetValue(4).ToString());
                p.NoHp = aES.Decryption(hasil.GetValue(5).ToString());
                p.TglMulaiBekerja = DateTime.Parse(hasil.GetValue(6).ToString());
                p.Email = aES.Decryption(hasil.GetValue(7).ToString());

                Jabatan j = new Jabatan();
                j.Id = int.Parse(hasil.GetValue(9).ToString());
                j.Nama = hasil.GetValue(11).ToString();
                p.Posisi = j;

                //kosongi password, karena tdk boleh membaca password orang lain
                listData.Add(p); //tambahkan objek kategori ke list
            }
            return listData;
        }

        public static void TambahData(Pekerja p)
        {
            EnkripsiAES aES = new EnkripsiAES();
            Hashing hashing = new Hashing();

            string sql = "INSERT INTO pekerja (nik, nama, tgllahir, alamat, noHP, tglmulaibekerja, email, password, jabatan_id) VALUES " +
                "('" + aES.Encryption(p.Nik) + "', '" + aES.Encryption(p.Nama) + "', '" + aES.Encryption(p.TglLahir) + "', " +
                "'" + aES.Encryption(p.Alamat) + "', '" + aES.Encryption(p.NoHp) + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + 
                "'" + aES.Encryption(p.Email) + "', '" + hashing.Encrypt(p.Password) + "', '2');";
            Koneksi.JalankanPerintahNonQuery(sql);
        }

        public override string ToString()
        {
            return this.Nama.ToString();
        }
        #endregion
    }
}
