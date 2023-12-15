using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapKakiTiga_LIB
{
    public class Cetak
    {
        #region DATA MEMBER
        private Font tipeFont;
        private StreamReader fileCetak;
        private float marginKiri, marginKanan, marginAtas, marginBawah;
        #endregion

        #region CONSTRUCTOR
        public Cetak(Font pTipeFont, string pAlamat, float pKiri, float pKanan, float pAtas, float pBawah)
        {
            TipeFont = pTipeFont;
            FileCetak = new StreamReader(pAlamat);
            MarginKiri = pKiri;
            MarginKanan = pKanan;
            MarginAtas = pAtas;
            MarginBawah = pBawah;
        }
        #endregion

        #region PROPERTY
        public Font TipeFont { get => tipeFont; set => tipeFont = value; }
        public StreamReader FileCetak { get => fileCetak; set => fileCetak = value; }
        public float MarginKiri { get => marginKiri; set => marginKiri = value; }
        public float MarginKanan { get => marginKanan; set => marginKanan = value; }
        public float MarginAtas { get => marginAtas; set => marginAtas = value; }
        public float MarginBawah { get => marginBawah; set => marginBawah = value; }
        #endregion

        #region METHODS
        public void CetakKertas(object sender, PrintPageEventArgs e)
        {
            int maxBaris = (int)((e.MarginBounds.Height - MarginAtas - MarginBawah) / TipeFont.GetHeight(e.Graphics));
            float Y;
            float X = MarginKiri;
            int jumBaris = 0;

            string teksCetak = FileCetak.ReadLine();
            while (jumBaris < maxBaris && teksCetak != null)
            {
                Y = MarginAtas + (jumBaris * TipeFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(teksCetak, TipeFont, Brushes.Black, X, Y);

                jumBaris++;
                teksCetak = FileCetak.ReadLine();
            }
            if (teksCetak == null)
                e.HasMorePages = false;
            else
                e.HasMorePages = true;
        }

        public void KirimkePrinter()
        {
            PrintDocument p = new PrintDocument();
            p.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            p.PrintPage += new PrintPageEventHandler(CetakKertas);
            p.Print();

            FileCetak.Close();
        }
        #endregion
    }
}
