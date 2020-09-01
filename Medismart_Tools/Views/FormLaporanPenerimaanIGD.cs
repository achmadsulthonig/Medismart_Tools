using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medismart_Tools.Views
{
    public partial class FormLaporanPenerimaanIGD : Form
    {
        public FormLaporanPenerimaanIGD()
        {
            InitializeComponent();
        }
        private string namaForm;

        public string NamaForm
        {
            get { return namaForm; }
            set { namaForm = value; }
        }
        public FormLaporanPenerimaanIGD(string value)
        {
            InitializeComponent();
            namaForm = value;
            this.Text = "Laporan " + value;


        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            FormPreviewLaporanPenerimaanIGD formPreviewLaporanPenerimaanIGD = new FormPreviewLaporanPenerimaanIGD();
            formPreviewLaporanPenerimaanIGD.ShowDialog();
        }
    }
}
