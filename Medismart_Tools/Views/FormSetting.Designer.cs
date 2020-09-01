namespace Medismart_Tools
{
    partial class FormSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControlSetting = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelConnection = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTestConnection = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUserID = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.labelInitialCatalog = new System.Windows.Forms.Label();
            this.textBoxInitialCatalog = new System.Windows.Forms.TextBox();
            this.labelDataSource = new System.Windows.Forms.Label();
            this.textBoxDataSource = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlSetting.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tableLayoutPanelConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControlSetting, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.84947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15053F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(392, 242);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Location = new System.Drawing.Point(196, 205);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(196, 37);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tabControlSetting
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControlSetting, 2);
            this.tabControlSetting.Controls.Add(this.tabPageConnection);
            this.tabControlSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSetting.Location = new System.Drawing.Point(0, 0);
            this.tabControlSetting.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlSetting.Name = "tabControlSetting";
            this.tabControlSetting.SelectedIndex = 0;
            this.tabControlSetting.Size = new System.Drawing.Size(392, 205);
            this.tabControlSetting.TabIndex = 0;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.tableLayoutPanelConnection);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 32);
            this.tabPageConnection.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Size = new System.Drawing.Size(384, 169);
            this.tabPageConnection.TabIndex = 0;
            this.tabPageConnection.Text = "Database Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelConnection
            // 
            this.tableLayoutPanelConnection.ColumnCount = 2;
            this.tableLayoutPanelConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelConnection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelConnection.Controls.Add(this.buttonTestConnection, 0, 4);
            this.tableLayoutPanelConnection.Controls.Add(this.labelPassword, 0, 3);
            this.tableLayoutPanelConnection.Controls.Add(this.textBoxPassword, 1, 3);
            this.tableLayoutPanelConnection.Controls.Add(this.labelUserID, 0, 2);
            this.tableLayoutPanelConnection.Controls.Add(this.textBoxUserID, 1, 2);
            this.tableLayoutPanelConnection.Controls.Add(this.labelInitialCatalog, 0, 1);
            this.tableLayoutPanelConnection.Controls.Add(this.textBoxInitialCatalog, 1, 1);
            this.tableLayoutPanelConnection.Controls.Add(this.labelDataSource, 0, 0);
            this.tableLayoutPanelConnection.Controls.Add(this.textBoxDataSource, 1, 0);
            this.tableLayoutPanelConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelConnection.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelConnection.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelConnection.Name = "tableLayoutPanelConnection";
            this.tableLayoutPanelConnection.RowCount = 5;
            this.tableLayoutPanelConnection.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelConnection.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelConnection.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelConnection.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelConnection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelConnection.Size = new System.Drawing.Size(384, 169);
            this.tableLayoutPanelConnection.TabIndex = 0;
            // 
            // buttonTestConnection
            // 
            this.buttonTestConnection.AutoSize = true;
            this.tableLayoutPanelConnection.SetColumnSpan(this.buttonTestConnection, 2);
            this.buttonTestConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTestConnection.Location = new System.Drawing.Point(0, 124);
            this.buttonTestConnection.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTestConnection.Name = "buttonTestConnection";
            this.buttonTestConnection.Size = new System.Drawing.Size(384, 45);
            this.buttonTestConnection.TabIndex = 8;
            this.buttonTestConnection.Text = "Test Connection";
            this.buttonTestConnection.UseVisualStyleBackColor = true;
            this.buttonTestConnection.Click += new System.EventHandler(this.buttonTestConnection_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPassword.Location = new System.Drawing.Point(0, 93);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(87, 31);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword.Location = new System.Drawing.Point(87, 93);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(297, 31);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserID.Location = new System.Drawing.Point(0, 62);
            this.labelUserID.Margin = new System.Windows.Forms.Padding(0);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(87, 31);
            this.labelUserID.TabIndex = 4;
            this.labelUserID.Text = "User";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUserID.Location = new System.Drawing.Point(87, 62);
            this.textBoxUserID.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(297, 31);
            this.textBoxUserID.TabIndex = 5;
            // 
            // labelInitialCatalog
            // 
            this.labelInitialCatalog.AutoSize = true;
            this.labelInitialCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInitialCatalog.Location = new System.Drawing.Point(0, 31);
            this.labelInitialCatalog.Margin = new System.Windows.Forms.Padding(0);
            this.labelInitialCatalog.Name = "labelInitialCatalog";
            this.labelInitialCatalog.Size = new System.Drawing.Size(87, 31);
            this.labelInitialCatalog.TabIndex = 2;
            this.labelInitialCatalog.Text = "Database";
            // 
            // textBoxInitialCatalog
            // 
            this.textBoxInitialCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInitialCatalog.Location = new System.Drawing.Point(87, 31);
            this.textBoxInitialCatalog.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxInitialCatalog.Name = "textBoxInitialCatalog";
            this.textBoxInitialCatalog.Size = new System.Drawing.Size(297, 31);
            this.textBoxInitialCatalog.TabIndex = 3;
            // 
            // labelDataSource
            // 
            this.labelDataSource.AutoSize = true;
            this.labelDataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDataSource.Location = new System.Drawing.Point(0, 0);
            this.labelDataSource.Margin = new System.Windows.Forms.Padding(0);
            this.labelDataSource.Name = "labelDataSource";
            this.labelDataSource.Size = new System.Drawing.Size(87, 31);
            this.labelDataSource.TabIndex = 0;
            this.labelDataSource.Text = "Server";
            // 
            // textBoxDataSource
            // 
            this.textBoxDataSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDataSource.Location = new System.Drawing.Point(87, 0);
            this.textBoxDataSource.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxDataSource.Name = "textBoxDataSource";
            this.textBoxDataSource.Size = new System.Drawing.Size(297, 31);
            this.textBoxDataSource.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.AutoSize = true;
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(0, 205);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(196, 37);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 242);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControlSetting.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tableLayoutPanelConnection.ResumeLayout(false);
            this.tableLayoutPanelConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TabControl tabControlSetting;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelConnection;
        private System.Windows.Forms.Label labelDataSource;
        private System.Windows.Forms.TextBox textBoxDataSource;
        private System.Windows.Forms.Button buttonTestConnection;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label labelInitialCatalog;
        private System.Windows.Forms.TextBox textBoxInitialCatalog;
    }
}