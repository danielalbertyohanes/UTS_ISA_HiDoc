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
    public partial class FormRiwayatPemeriksaan : Form
    {
        public FormRiwayatPemeriksaan()
        {
            InitializeComponent();
        }
        FormUtama frm;
        private void FormRiwayatPemeriksaan_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.Owner;
            List<JanjiTemu> listData = JanjiTemu.BacaData("j.pasien_nik", frm.userLoginPasien.Nik);
            if (listData.Count > 0)
            {
                dataGridViewResult.DataSource = listData;

            }
            else
            {
                dataGridViewResult.DataSource = null;
            }

            if (dataGridViewResult.ColumnCount == 5)
            {
                string status = dataGridViewResult.CurrentRow.Cells["Status"].Value.ToString();
                DataGridViewButtonColumn b1 = new DataGridViewButtonColumn();
                if (status == "sudah")
                {
                    b1.HeaderText = "Check Up Result";
                    b1.Text = "Read";
                    b1.Name = "btnRead";
                    b1.UseColumnTextForButtonValue = true;
                    dataGridViewResult.Columns.Add(b1);
                }
            }
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewResult.Columns["btnRead"].Index && e.RowIndex >= 0)
            {
                FormHasilPeriksa frm = new FormHasilPeriksa();
                frm.Owner = this;
                string kode = dataGridViewResult.CurrentRow.Cells["Id"].Value.ToString();
                List<Riwayat> listRiwayat = Riwayat.BacaData("janji_temu_id", kode);
                List<JanjiTemu> listJanjiTemu = JanjiTemu.BacaData("j.id", kode);
                frm.vJanjiTemu = listJanjiTemu[0];
                frm.vRiwayat = listRiwayat[0];
                frm.posisi = "Pasien";
                frm.ShowDialog();
            }
            FormRiwayatPemeriksaan_Load(this, e);
        }
    }
}
