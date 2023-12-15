using CapKakiTiga_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekUTS_CapKakiTiga
{
    public partial class FormDisplayData : Form
    {
        public FormDisplayData()
        {
            InitializeComponent();
        }
        public string posisi;
        List<Pekerja> listDokter = new List<Pekerja>();
        List<Pasien> listPasien = new List<Pasien>();
        private void FormDisplayData_Load(object sender, EventArgs e)
        {
            if(posisi == "Dokter")
            {
                listDokter = Pekerja.BacaData("jabatan_id", "2");
                if (listDokter.Count > 0)
                {
                    dataGridViewResult.DataSource = listDokter;

                }
                else
                {
                    dataGridViewResult.DataSource = null;
                }
            }
            else if (posisi == "Pasien")
            {
                listPasien = Pasien.BacaData("", "");
                if (listPasien.Count > 0)
                {
                    dataGridViewResult.DataSource = listPasien;

                }
                else
                {
                    dataGridViewResult.DataSource = null;
                }
            }
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //1 membuka aplikasi excel
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            if (excelApp == null) //cek apakah ada aplikasi excel atau tidak
            {
                MessageBox.Show("Microsoft Excel is not found!");
                return; //jika tidak ada, batalkan event ini
            }

            //2 ciptakan workbook
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();

            //3 ciptakan worksheet
            excelWorkbook.Worksheets.Add();
            Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = excelWorkbook.Worksheets[1];

            if (posisi == "Dokter")
            {
                //menulis ke excel
                excelWorksheet.Cells[1, 1] = "Doctors Data Recap";

                excelWorksheet.Cells[3, 1] = "ID";
                excelWorksheet.Cells[3, 2] = "NIK";
                excelWorksheet.Cells[3, 3] = "Name";
                excelWorksheet.Cells[3, 4] = "Birthdate";
                excelWorksheet.Cells[3, 5] = "Address";
                excelWorksheet.Cells[3, 6] = "Phone Number";
                excelWorksheet.Cells[3, 7] = "Start Working Date";
                excelWorksheet.Cells[3, 8] = "Email";

                for (int i = 0; i < listDokter.Count; i++)
                {
                    excelWorksheet.Cells[i + 4, 1] = listDokter[i].Id;
                    excelWorksheet.Cells[i + 4, 2] = listDokter[i].Nik;
                    excelWorksheet.Cells[i + 4, 3] = listDokter[i].Nama;
                    excelWorksheet.Cells[i + 4, 4] = listDokter[i].TglLahir;
                    excelWorksheet.Cells[i + 4, 5] = listDokter[i].Alamat;
                    excelWorksheet.Cells[i + 4, 6] = listDokter[i].NoHp;
                    excelWorksheet.Cells[i + 4, 7] = listDokter[i].TglMulaiBekerja.ToString("dd-MM-yyyy");
                    excelWorksheet.Cells[i + 4, 8] = listDokter[i].Email;
                }
            }

            else if (posisi == "Pasien")
            {
                excelWorksheet.Cells[1, 1] = "Patients Data Recap";

                excelWorksheet.Cells[3, 1] = "NIK";
                excelWorksheet.Cells[3, 2] = "Name";
                excelWorksheet.Cells[3, 3] = "Birthdate";
                excelWorksheet.Cells[3, 4] = "Address";
                excelWorksheet.Cells[3, 5] = "Phone Number";
                excelWorksheet.Cells[3, 6] = "Email";

                for (int i = 0; i < listPasien.Count; i++)
                {
                    excelWorksheet.Cells[i + 4, 1] = listPasien[i].Nik;
                    excelWorksheet.Cells[i + 4, 2] = listPasien[i].Nama;
                    excelWorksheet.Cells[i + 4, 3] = listPasien[i].TglLahir;
                    excelWorksheet.Cells[i + 4, 4] = listPasien[i].Alamat;
                    excelWorksheet.Cells[i + 4, 5] = listPasien[i].NoHp;
                    excelWorksheet.Cells[i + 4, 6] = listPasien[i].Email;
                }
            }

            //simpan file-nya
            try
            {
                excelApp.DisplayAlerts = false;
                if (posisi == "Dokter")
                    excelWorkbook.SaveAs("DoctorsDataRecap.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault);
                else if (posisi == "Pasien")
                    excelWorkbook.SaveAs("PatientsDataRecap.xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault);
                excelWorkbook.Close();
                MessageBox.Show("Excel file has been made");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            //menghapus objek dari memory
            Marshal.ReleaseComObject(excelWorkbook);
            Marshal.ReleaseComObject(excelApp);
        }
    }
}
