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
    public partial class FormDialogTanggalBaru : Form
    {
        private DateTime tanggalBaru;

        public DateTime TanggalBaru
        {
            get { return tanggalBaru; }
            set { tanggalBaru = value; }
        }
        
        public FormDialogTanggalBaru()
        {
            InitializeComponent();
            dateTimePickerTanggalBaru.Value = DateTime.Today;
        }

        private void dateTimePickerTanggalBaru_ValueChanged(object sender, EventArgs e)
        {
            tanggalBaru = dateTimePickerTanggalBaru.Value;
        }
    }
}
