using CapKakiTiga_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekUTS_CapKakiTiga
{
    public partial class FormTambahDokter : Form
    {
        public FormTambahDokter()
        {
            InitializeComponent();
        }

        private void FormRegisterDokter_Load(object sender, EventArgs e)
        {
            
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegist_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxRePassword.Text)
            {
                MessageBox.Show("Re-enter the correct Password!");
                textBoxPassword.Clear();
                textBoxRePassword.Clear();
                textBoxPassword.Focus();
            }
            else
            {
                try
                {
                    Pekerja u = new Pekerja();
                    u.Nik = textBoxNik.Text;
                    u.Nama = textBoxFName.Text;
                    u.TglLahir = dateTimePickerTglLahir.Value.ToShortDateString();
                    u.Alamat = textBoxAddress.Text;
                    u.NoHp = textBoxPhone.Text;
                    u.Email = textBoxEmail.Text;
                    u.Password = textBoxRePassword.Text;
                    Pekerja.TambahData(u);
                    MessageBox.Show("Account created!", "Information");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create account. Error: " + ex.Message, "Error");
                    this.Close();
                }
            }
        }
    }
}
