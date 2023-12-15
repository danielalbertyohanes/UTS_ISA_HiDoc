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
    public partial class FormJanjiTemuPasien : Form
    {
        public FormJanjiTemuPasien()
        {
            InitializeComponent();
        }
        FormUtama frm;
        private void FormJanjiTemuPasien_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.Owner;

            List<Pekerja> listdata = Pekerja.BacaData("jabatan_id", "2");
            comboBoxDokter.DataSource = listdata;
            comboBoxDokter.DisplayMember = "Nama";
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                Pekerja p = (Pekerja)comboBoxDokter.SelectedItem;
                if (!JanjiTemu.CekJanjiTemu(p, dateTimePickerTanggalJanjiTemu.Value.Date + dateTimePickerWaktuJanjiTemu.Value.TimeOfDay))
                {
                    JanjiTemu j = new JanjiTemu();
                    j.TglTemu = dateTimePickerTanggalJanjiTemu.Value.Date + dateTimePickerWaktuJanjiTemu.Value.TimeOfDay;
                    j.Pengguna = ((FormUtama)this.Owner).userLoginPasien;
                    j.Dokter = p;
                    JanjiTemu.TambahData(j);
                    MessageBox.Show("Appointment has been made!");
                }
                else
                {
                    throw new Exception("Doctor " + p.Nama + " already has an appointment on " + dateTimePickerTanggalJanjiTemu.Value.Date + " at " + dateTimePickerWaktuJanjiTemu.Value.TimeOfDay);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
