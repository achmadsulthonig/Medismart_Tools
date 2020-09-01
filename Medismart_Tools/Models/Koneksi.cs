using System;
using System.Windows.Forms;

namespace Medismart_Tools.Models
{
    public class Koneksi
    {
        private string dataSource;

        public string DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }

        private string initialCatalog;

        public string InitialCatalog
        {
            get { return initialCatalog; }
            set { initialCatalog = value; }
        }

        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string connection;

        public string Connection
        {
            get { return connection; }
            set { connection = value; }
        }
        
        public void SaveConnection(string dataSource, string initialCatalog, string userID, string password)
        {
            try
            {
                Medismart_Tools.Properties.Settings.Default.CS = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", dataSource, initialCatalog, userID, password);
                Medismart_Tools.Properties.Settings.Default.DataSource = dataSource;
                Medismart_Tools.Properties.Settings.Default.InitialCatalog = initialCatalog;
                Medismart_Tools.Properties.Settings.Default.UserID = userID;
                Medismart_Tools.Properties.Settings.Default.Password = password;

                Medismart_Tools.Properties.Settings.Default.Save();

                MessageBox.Show("Connection setting has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DCMedismartToolsDataContext dataContext;

        public DCMedismartToolsDataContext DataContext
        {
            get
            {
                return dataContext;
            }
            set { dataContext = value; }
        }

        public Koneksi()
        {
            try
            {
                dataSource = Medismart_Tools.Properties.Settings.Default.DataSource;
                initialCatalog = Medismart_Tools.Properties.Settings.Default.InitialCatalog;
                userID = Medismart_Tools.Properties.Settings.Default.UserID;
                password = Medismart_Tools.Properties.Settings.Default.Password;
                dataContext = new DCMedismartToolsDataContext(Medismart_Tools.Properties.Settings.Default.CS);
                connection = Medismart_Tools.Properties.Settings.Default.CS;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsConnected()
        {
            try
            {
                dataContext = new DCMedismartToolsDataContext(Medismart_Tools.Properties.Settings.Default.CS);
                dataContext.Connection.Open();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }   
        }
    }
}