using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medismart_Tools.Presenters;

namespace Medismart_Tools.Views
{
    public partial class FormGantiTanggalKunjungan : Form
    {
        private string namaForm;

        public string NamaForm
        {
            get { return namaForm; }
            set { namaForm = value; }
        }

        private PGantiTanggal pGantiTanggal;

        internal PGantiTanggal PGantiTanggal
        {
            get { return pGantiTanggal; }
            set { pGantiTanggal = value; }
        }

        public FormGantiTanggalKunjungan()
        {
            InitializeComponent();
        }

        public FormGantiTanggalKunjungan(string value)
        {
            InitializeComponent();
            namaForm = value;
            this.Text = value;
            pGantiTanggal = new PGantiTanggal();
        }

        private void maskedTextBoxNomorMR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pGantiTanggal.NamaForm = namaForm;
                pGantiTanggal.cariPasien(maskedTextBoxNomorMR.Text);

                textBoxNamaPasien.Text = pGantiTanggal.Pasien.NAMA;
                textBoxAlamatPasien.Text = pGantiTanggal.Pasien.ALAMAT;

                refreshdataGridView();
            }
        }

        private void refreshdataGridView()
        {
            dataGridViewTransaksi.DataSource = pGantiTanggal.cariKunjungan();
        }

        private void gantiTanggalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kodeUnit = dataGridViewTransaksi.CurrentRow.Cells[8].Value.ToString();
            string nomorTransaksi = dataGridViewTransaksi.CurrentRow.Cells[0].Value.ToString();
            DateTime tanggalMasuk = (DateTime)dataGridViewTransaksi.CurrentRow.Cells[2].Value;

            FormDialogTanggalBaru formDialogTanggalBaru = new FormDialogTanggalBaru();
            //formDialogTanggalBaru.ShowDialog();

            if (formDialogTanggalBaru.ShowDialog() == DialogResult.OK)
            {
                switch (namaForm)
                {
                    case "Ganti Tanggal Kunjungan RWJ":
                        pGantiTanggal.GantiTanggalKunjungan(kodeUnit, nomorTransaksi, tanggalMasuk, formDialogTanggalBaru.TanggalBaru);
                        refreshdataGridView();
                        break;

                    case "Ganti Tanggal Kunjungan RWI":
                        DateTime tanggalKeluar = (DateTime)dataGridViewTransaksi.CurrentRow.Cells[2].Value;
                        pGantiTanggal.GantiTanggalKunjungan(kodeUnit, nomorTransaksi, tanggalMasuk, formDialogTanggalBaru.TanggalBaru);
                        refreshdataGridView();
                        break;

                    case "Ganti Tanggal Kunjungan IGD":
                        pGantiTanggal.GantiTanggalKunjungan(kodeUnit, nomorTransaksi, tanggalMasuk, formDialogTanggalBaru.TanggalBaru);
                        refreshdataGridView();
                        break;

                    case "Ganti Tanggal Kunjungan Laboratorium":
                        pGantiTanggal.GantiTanggalKunjungan(kodeUnit, nomorTransaksi, tanggalMasuk, formDialogTanggalBaru.TanggalBaru);
                        refreshdataGridView();
                        break;

                    case "Ganti Tanggal Kunjungan Radiologi":
                        pGantiTanggal.GantiTanggalKunjungan(kodeUnit, nomorTransaksi, tanggalMasuk, formDialogTanggalBaru.TanggalBaru);
                        refreshdataGridView();
                        break;
                }
            }
        }
    }
}
