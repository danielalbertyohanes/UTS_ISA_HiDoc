using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapKakiTiga_LIB;

namespace ProjekUTS_CapKakiTiga
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            Pasien p = Pasien.CekLoginPasien(email, password);
            Pekerja pe = Pekerja.CekLoginPekerja(email, password);

            if (p is null && pe is null)
            {
                MessageBox.Show("Login failed!");
            }
            else if (pe is null)
            {
                FormUtama frm;
                frm = (FormUtama)this.Owner;

                frm.userLoginPasien = p;

                MessageBox.Show("Login successfully!");
                frm.Visible = true;
                this.Close();
            }
            else if (p is null)
            {
                FormUtama frm;
                frm = (FormUtama)this.Owner;

                frm.userLoginPegawai = pe;

                MessageBox.Show("Login successfully!");
                frm.Visible = true;
                this.Close();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Koneksi k = new Koneksi(db.Default.dbServer, db.Default.dbName, db.Default.dbUID, db.Default.dbPWD);
                //MessageBox.Show("Koneksi berhasil");

                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkLabelRegist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            FormRegister frm = new FormRegister();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
