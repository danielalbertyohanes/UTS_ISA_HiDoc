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
    public partial class FormHasilPeriksa : Form
    {
        public FormHasilPeriksa()
        {
            InitializeComponent();
        }
        public JanjiTemu vJanjiTemu;
        public Riwayat vRiwayat;
        public string posisi;
        private void FormHasilPeriksa_Load(object sender, EventArgs e)
        {
            AturMenu();
            if (vRiwayat is object)
            {
                textBoxHasil.Text = vRiwayat.HasilPeriksa;
                buttonSave.Visible = false;
                buttonPrint.Visible = true;
            }
            else
            {
                buttonSave.Visible = true;
                buttonPrint.Visible = false;
            }
        }

        private void AturMenu()
        {
            labelTanggal.Text = vJanjiTemu.TglTemu.ToString();
            if (posisi == "Dokter")
            {
                labelNama.Text = "Patient : " + vJanjiTemu.Pengguna.Nama;
            }
            else if (posisi == "Pasien")
            {
                labelNama.Text = "Doctor : " + vJanjiTemu.Dokter.Nama;
            }
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Riwayat r = new Riwayat();
                r.HasilPeriksa = textBoxHasil.Text;
                r.Janji = vJanjiTemu;
                Riwayat.TambahData(r);
                JanjiTemu.UpdateStatus(vJanjiTemu.Id.ToString());
                MessageBox.Show("Data has been saved!");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Riwayat.PrintHasilPeriksa("janji_temu_id", vJanjiTemu.Id.ToString(), vJanjiTemu, "checkup.txt", new Font("Courier New", 12));
        }
    }
}
