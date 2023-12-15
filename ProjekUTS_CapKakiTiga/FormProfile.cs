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
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }
        FormUtama frm;
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.Owner;

            textBoxNik.Text = frm.userLoginPasien.Nik;
            textBoxFName.Text = frm.userLoginPasien.Nama;
            textBoxBirthDate.Text = frm.userLoginPasien.TglLahir;
            textBoxAddress.Text = frm.userLoginPasien.Alamat;
            textBoxPhone.Text = frm.userLoginPasien.NoHp;
            textBoxEmail.Text = frm.userLoginPasien.Email;
        }
    }
}
