using Medismart_Tools.Presenters;
using System;
using System.Windows.Forms;

namespace Medismart_Tools
{
    public partial class FormSetting : Form
    {
        private PKoneksi pKoneksi;

        internal PKoneksi PKoneksi
        {
            get { return pKoneksi; }
            set { pKoneksi = value; }
        }

        public FormSetting()
        {
            InitializeComponent();
            pKoneksi = new PKoneksi();
            InitialValue();
        }

        public void InitialValue()
        {
            textBoxDataSource.Text = pKoneksi.Koneksi.DataSource;
            textBoxInitialCatalog.Text = pKoneksi.Koneksi.InitialCatalog;
            textBoxUserID.Text = pKoneksi.Koneksi.UserID;
            textBoxPassword.Text = pKoneksi.Koneksi.Password;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            pKoneksi.saveKoneksi(textBoxDataSource.Text, textBoxInitialCatalog.Text, textBoxUserID.Text, textBoxPassword.Text);
        }

        private void buttonTestConnection_Click(object sender, EventArgs e)
        {
            pKoneksi.IsConnected();
        }
    }
}