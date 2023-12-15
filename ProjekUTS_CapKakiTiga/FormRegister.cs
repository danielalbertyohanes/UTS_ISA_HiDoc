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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
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
                    Pasien u = new Pasien(textBoxNik.Text, textBoxFName.Text, dateTimePickerTglLahir.Value.ToShortDateString(), textBoxAddress.Text, textBoxPhone.Text, textBoxEmail.Text, textBoxRePassword.Text);
                    Pasien.TambahData(u);
                    MessageBox.Show("Account created!", "Information");
                    lblBack_Click(this, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to create account. Error: " + ex.Message, "Error");
                }
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormLogin"];
            if (f == null)
            {
                FormLogin frm = new FormLogin();
                frm.Show();
                frm.Visible = true;
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
            this.Close();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
