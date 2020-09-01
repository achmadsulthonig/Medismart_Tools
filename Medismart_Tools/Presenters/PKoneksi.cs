using Medismart_Tools.Models;
using System.Windows.Forms;

namespace Medismart_Tools.Presenters
{
    internal class PKoneksi
    {
        private FormSetting formSetting;

        public FormSetting FormSetting
        {
            get { return formSetting; }
            set { formSetting = value; }
        }

        private Koneksi koneksi;

        public Koneksi Koneksi
        {
            get { return koneksi; }
            set { koneksi = value; }
        }

        public void saveKoneksi(string dataSource, string initialCatalog, string userID, string password)
        {
            koneksi.SaveConnection(dataSource, initialCatalog, userID, password);
        }

        public PKoneksi()
        {
            koneksi = new Koneksi();
        }

        public void IsConnected()
        {
            if (koneksi.IsConnected())
                MessageBox.Show("Koneksi ke server berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Koneksi ke server gagal, cek kembali inputannya", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}