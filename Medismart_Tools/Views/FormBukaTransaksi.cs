using Medismart_Tools.Presenters;
using System;
using System.Windows.Forms;

namespace Medismart_Tools.Views
{
    public partial class FormBukaTransaksi : Form
    {
        private string namaForm;

        public string NamaForm
        {
            get { return namaForm; }
            set { namaForm = value; }
        }

        private PBukaTransaksi pBukaTransaksi;

        internal PBukaTransaksi PBukaTransaksi
        {
            get { return pBukaTransaksi; }
            set { pBukaTransaksi = value; }
        }

        public FormBukaTransaksi()
        {
            InitializeComponent();
        }

        public FormBukaTransaksi(string value)
        {
            InitializeComponent();
            namaForm = value;
            this.Text = value;
            pBukaTransaksi = new Presenters.PBukaTransaksi();
        }

        public void UpdateDataPasien(PASIEN selectedPasien)
        {
            try
            {
                textBoxNamaPasien.Text = selectedPasien.NAMA;
                textBoxAlamatPasien.Text = selectedPasien.ALAMAT;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void maskedTextBoxNomorMR_KeyDown(object sender, KeyEventArgs e)
      {
            if (e.KeyCode == Keys.Enter)
            {
                pBukaTransaksi.NamaForm = namaForm;
                pBukaTransaksi.cariPasien(maskedTextBoxNomorMR.Text);

                textBoxNamaPasien.Text = pBukaTransaksi.Pasien.NAMA;
                textBoxAlamatPasien.Text = pBukaTransaksi.Pasien.ALAMAT;

                refreshdataGridView();
            }
        }

        private void refreshdataGridView()
        {
            dataGridViewTransaksi.DataSource = pBukaTransaksi.cariKunjungan();
        }

        private void bukaTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kodeUnit = dataGridViewTransaksi.CurrentRow.Cells[8].Value.ToString();
            string nomorTransaksi = dataGridViewTransaksi.CurrentRow.Cells[0].Value.ToString();
            DateTime tanggalMasuk = (DateTime)dataGridViewTransaksi.CurrentRow.Cells[2].Value;

            switch (namaForm)
            {
                case "Buka Transaksi RWJ":
                    pBukaTransaksi.BukaTransaksiNonRWI(kodeUnit, nomorTransaksi, tanggalMasuk);
                    refreshdataGridView();
                    break;

                case "Buka Transaksi RWI":
                    DateTime tanggalKeluar = (DateTime)dataGridViewTransaksi.CurrentRow.Cells[2].Value;
                    pBukaTransaksi.BukaTransaksiRWI(kodeUnit, nomorTransaksi, tanggalMasuk);
                    refreshdataGridView();
                    break;

                case "Buka Transaksi IGD":
                    pBukaTransaksi.BukaTransaksiNonRWI(kodeUnit, nomorTransaksi, tanggalMasuk);
                    refreshdataGridView();
                    break;

                case "Buka Transaksi Laboratorium":
                    pBukaTransaksi.BukaTransaksiNonRWI(kodeUnit, nomorTransaksi, tanggalMasuk);
                    refreshdataGridView();
                    break;

                case "Buka Transaksi Radiologi":
                    pBukaTransaksi.BukaTransaksiNonRWI(kodeUnit, nomorTransaksi, tanggalMasuk);
                    refreshdataGridView();
                    break;
            }
        }
    }
}