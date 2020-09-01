using Medismart_Tools.Views;
using System;
using System.Windows.Forms;

namespace Medismart_Tools
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetting formSetting = new FormSetting();
            formSetting.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxMedismart_Tools formAboutBox = new AboutBoxMedismart_Tools();
            formAboutBox.ShowDialog();
        }

        private void bukaFormBukaTransaksi(object sender)
        {
            FormBukaTransaksi formBukaTransaksi = new FormBukaTransaksi(sender.ToString());
            formBukaTransaksi.MdiParent = this;
            formBukaTransaksi.Show();
        }
        private void bukaTransaksiRWJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bukaFormBukaTransaksi(sender);
        }

        private void bukaTransaksiIGDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bukaFormBukaTransaksi(sender);
        }

        private void bukaTransaksiRWIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bukaFormBukaTransaksi(sender);
        }

        private void bukaTransaksiLaboratoriumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bukaFormBukaTransaksi(sender);
        }

        private void bukaTransaksiRadiologiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bukaFormBukaTransaksi(sender);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void gantiTanggalKunjunganRWJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bukaFormGantiTanggalKunjungan(sender);
        }

        private void bukaFormGantiTanggalKunjungan(object sender)
        {
            FormGantiTanggalKunjungan formGantiTanggalKunjungan = new FormGantiTanggalKunjungan(sender.ToString());
            formGantiTanggalKunjungan.MdiParent = this;
            formGantiTanggalKunjungan.Show();
        }

        private void gantiTanggalKunjunganIGDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bukaFormGantiTanggalKunjungan(sender);
        }

        private void gantiTanggalKunjunganRWIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bukaFormGantiTanggalKunjungan(sender);
        }

        private void gantiTanggalKunjunganLaboratoriumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bukaFormGantiTanggalKunjungan(sender);
        }

        private void gantiTanggalKunjunganRadiologiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bukaFormGantiTanggalKunjungan(sender);
        }

        private void penerimaanPerPasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaporanPenerimaanIGD formLaporanPenerimaanIGD = new FormLaporanPenerimaanIGD(sender.ToString());
            formLaporanPenerimaanIGD.MdiParent = this;
            formLaporanPenerimaanIGD.Show();
        }
    }
}