using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapKakiTiga_LIB
{
    public class Jabatan
    {
        #region DATA MEMBERS
        private int id;
        private string nama;
        #endregion

        #region CONSTRUCTORS
        public Jabatan()
        {
            Id = 0;
            Nama = "";
        }
        public Jabatan(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return this.Nama.ToString();
        }
        #endregion

    }
}
