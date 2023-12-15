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
    public partial class FormJanjiTemuDokter : Form
    {
        public FormJanjiTemuDokter()
        {
            InitializeComponent();
        }
        FormUtama frm;
        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = dataGridViewResult.CurrentRow.Cells["Status"].Value.ToString();
            if (e.ColumnIndex == dataGridViewResult.Columns["btnAdd"].Index && e.RowIndex >= 0)
            {
                FormHasilPeriksa frm = new FormHasilPeriksa();
                frm.Owner = this;
                string kode = dataGridViewResult.CurrentRow.Cells["Id"].Value.ToString();
                List<JanjiTemu> listJanjiTemu = JanjiTemu.BacaData("j.id", kode);
                frm.vJanjiTemu = listJanjiTemu[0];
                if (status == "sudah")
                {
                    List<Riwayat> listRiwayat = Riwayat.BacaData("janji_temu_id", kode);
                    frm.vRiwayat = listRiwayat[0];
                }
                frm.posisi = "Dokter";
                frm.ShowDialog();
            }
            FormJanjiTemuDokter_Load(this, e);
        }

        private void FormJanjiTemuDokter_Load(object sender, EventArgs e)
        {
            frm = (FormUtama)this.Owner;
            List<JanjiTemu> listdata = JanjiTemu.BacaData("j.pekerja_id", frm.userLoginPegawai.Id.ToString());

            if (listdata.Count > 0)
            {
                dataGridViewResult.DataSource = listdata;

            }
            else
            {
                dataGridViewResult.DataSource = null;
            }

            if (dataGridViewResult.ColumnCount == 5)
            {
                string status = dataGridViewResult.CurrentRow.Cells["Status"].Value.ToString();
                DataGridViewButtonColumn b1 = new DataGridViewButtonColumn();
                if (status == "belum")
                {
                    b1.HeaderText = "Check Up Result";
                    b1.Text = "Add";
                    b1.Name = "btnAdd";
                    b1.UseColumnTextForButtonValue = true;
                    dataGridViewResult.Columns.Add(b1);

                }
                else
                {
                    b1.HeaderText = "Check Up Result";
                    b1.Text = "Read";
                    b1.Name = "btnAdd";
                    b1.UseColumnTextForButtonValue = true;
                    dataGridViewResult.Columns.Add(b1);
                }
            }
        }
    }
}
