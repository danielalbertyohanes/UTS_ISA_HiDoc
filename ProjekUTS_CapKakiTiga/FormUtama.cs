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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }
        public Pasien userLoginPasien;
        public Pekerja userLoginPegawai;

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            FormLogin frm = new FormLogin();
            frm.Owner = this;
            frm.ShowDialog();
            this.Visible = true;

            if (userLoginPasien != null)
            {
                labelName.Text = userLoginPasien.Nama + "!";
                AturMenu("Pasien");
            }
            else if (userLoginPegawai != null)
            {
                labelName.Text = userLoginPegawai.Nama + "!";
                AturMenu(userLoginPegawai.Posisi.Nama);
            }
            else
                this.Close();
        }

        private void AturMenu (string posisi)
        {
            if (posisi == "Pasien")
            {
                pasienToolStripMenuItem1.Text = "Menu";
                pasienToolStripMenuItem1.Visible = true;
                profilToolStripMenuItem.Visible = true;

                adminToolStripMenuItem.Visible = false;
                dokterToolStripMenuItem.Visible = false;
            }
            else if (posisi == "Dokter")
            {
                dokterToolStripMenuItem.Text = "Menu";
                pasienToolStripMenuItem1.Visible = false;
                profilToolStripMenuItem.Visible = false;
                adminToolStripMenuItem.Visible = false;

                dokterToolStripMenuItem.Visible = true;
            }
            else if (posisi == "Admin")
            {
                adminToolStripMenuItem.Text = "Menu";
                pasienToolStripMenuItem1.Visible = false;
                profilToolStripMenuItem.Visible = false;
                dokterToolStripMenuItem.Visible = false;

                adminToolStripMenuItem.Visible = true;
            }
        }

        private void tambahDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormTambahDokter"];
            if (f == null)
            {
                FormTambahDokter frm = new FormTambahDokter();
                frm.Owner = this;
                frm.ShowDialog();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormProfile"];
            if (f == null)
            {
                FormProfile frm = new FormProfile();
                frm.Owner = this;
                frm.ShowDialog();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void riwayatPemeriksaaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormRiwayatPemeriksaan"];
            if (f == null)
            {
                FormRiwayatPemeriksaan frm = new FormRiwayatPemeriksaan();
                frm.Owner = this;
                frm.ShowDialog();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void janjiTemuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormJanjiTemuPasien"];
            if (f == null)
            {
                FormJanjiTemuPasien frm = new FormJanjiTemuPasien();
                frm.Owner = this;
                frm.ShowDialog();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void JanjiTemuDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormJanjiTemuDokter"];
            if (f == null)
            {
                FormJanjiTemuDokter frm = new FormJanjiTemuDokter();
                frm.Owner = this;
                frm.ShowDialog();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormDisplayData"];
            if (f == null)
            {
                FormDisplayData frm = new FormDisplayData();
                frm.Owner = this;
                frm.posisi = "Dokter";
                frm.ShowDialog();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void displayPatientsDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormDisplayData"];
            if (f == null)
            {
                FormDisplayData frm = new FormDisplayData();
                frm.Owner = this;
                frm.posisi = "Pasien";
                frm.ShowDialog();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }
    }
}
