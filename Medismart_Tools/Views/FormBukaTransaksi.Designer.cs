namespace Medismart_Tools.Views
{
    partial class FormBukaTransaksi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBukaTransaksi));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxAlamatPasien = new System.Windows.Forms.TextBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelNamaPasien = new System.Windows.Forms.Label();
            this.labelNomorMR = new System.Windows.Forms.Label();
            this.maskedTextBoxNomorMR = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNamaPasien = new System.Windows.Forms.TextBox();
            this.labelKeterangan = new System.Windows.Forms.Label();
            this.dataGridViewTransaksi = new System.Windows.Forms.DataGridView();
            this.contextMenuStripBukaTransaksi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bukaTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).BeginInit();
            this.contextMenuStripBukaTransaksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxAlamatPasien, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAlamat, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNamaPasien, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNomorMR, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.maskedTextBoxNomorMR, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNamaPasien, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelKeterangan, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewTransaksi, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxAlamatPasien
            // 
            this.textBoxAlamatPasien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAlamatPasien.Location = new System.Drawing.Point(492, 25);
            this.textBoxAlamatPasien.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAlamatPasien.Name = "textBoxAlamatPasien";
            this.textBoxAlamatPasien.Size = new System.Drawing.Size(292, 31);
            this.textBoxAlamatPasien.TabIndex = 5;
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(492, 0);
            this.labelAlamat.Margin = new System.Windows.Forms.Padding(0);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(68, 25);
            this.labelAlamat.TabIndex = 2;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelNamaPasien
            // 
            this.labelNamaPasien.AutoSize = true;
            this.labelNamaPasien.Location = new System.Drawing.Point(101, 0);
            this.labelNamaPasien.Margin = new System.Windows.Forms.Padding(0);
            this.labelNamaPasien.Name = "labelNamaPasien";
            this.labelNamaPasien.Size = new System.Drawing.Size(59, 25);
            this.labelNamaPasien.TabIndex = 1;
            this.labelNamaPasien.Text = "Nama";
            // 
            // labelNomorMR
            // 
            this.labelNomorMR.AutoSize = true;
            this.labelNomorMR.Location = new System.Drawing.Point(0, 0);
            this.labelNomorMR.Margin = new System.Windows.Forms.Padding(0);
            this.labelNomorMR.Name = "labelNomorMR";
            this.labelNomorMR.Size = new System.Drawing.Size(101, 25);
            this.labelNomorMR.TabIndex = 0;
            this.labelNomorMR.Text = "Nomor MR";
            // 
            // maskedTextBoxNomorMR
            // 
            this.maskedTextBoxNomorMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBoxNomorMR.Location = new System.Drawing.Point(0, 25);
            this.maskedTextBoxNomorMR.Margin = new System.Windows.Forms.Padding(0);
            this.maskedTextBoxNomorMR.Mask = "0-00-00-00";
            this.maskedTextBoxNomorMR.Name = "maskedTextBoxNomorMR";
            this.maskedTextBoxNomorMR.Size = new System.Drawing.Size(101, 31);
            this.maskedTextBoxNomorMR.TabIndex = 3;
            this.maskedTextBoxNomorMR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxNomorMR_KeyDown);
            // 
            // textBoxNamaPasien
            // 
            this.textBoxNamaPasien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNamaPasien.Location = new System.Drawing.Point(101, 25);
            this.textBoxNamaPasien.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNamaPasien.Name = "textBoxNamaPasien";
            this.textBoxNamaPasien.Size = new System.Drawing.Size(391, 31);
            this.textBoxNamaPasien.TabIndex = 4;
            // 
            // labelKeterangan
            // 
            this.labelKeterangan.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelKeterangan, 3);
            this.labelKeterangan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKeterangan.Location = new System.Drawing.Point(0, 536);
            this.labelKeterangan.Margin = new System.Windows.Forms.Padding(0);
            this.labelKeterangan.Name = "labelKeterangan";
            this.labelKeterangan.Size = new System.Drawing.Size(784, 25);
            this.labelKeterangan.TabIndex = 7;
            this.labelKeterangan.Text = "Klik kanan mouse -> Kembalikan, untuk membuka transaksinya";
            this.labelKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewTransaksi
            // 
            this.dataGridViewTransaksi.AllowUserToAddRows = false;
            this.dataGridViewTransaksi.AllowUserToDeleteRows = false;
            this.dataGridViewTransaksi.AllowUserToOrderColumns = true;
            this.dataGridViewTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTransaksi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewTransaksi, 3);
            this.dataGridViewTransaksi.ContextMenuStrip = this.contextMenuStripBukaTransaksi;
            this.dataGridViewTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransaksi.Location = new System.Drawing.Point(0, 56);
            this.dataGridViewTransaksi.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewTransaksi.MultiSelect = false;
            this.dataGridViewTransaksi.Name = "dataGridViewTransaksi";
            this.dataGridViewTransaksi.ReadOnly = true;
            this.dataGridViewTransaksi.RowHeadersVisible = false;
            this.dataGridViewTransaksi.Size = new System.Drawing.Size(784, 480);
            this.dataGridViewTransaksi.TabIndex = 6;
            // 
            // contextMenuStripBukaTransaksi
            // 
            this.contextMenuStripBukaTransaksi.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.contextMenuStripBukaTransaksi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukaTransaksiToolStripMenuItem});
            this.contextMenuStripBukaTransaksi.Name = "contextMenuStripBukaTransaksi";
            this.contextMenuStripBukaTransaksi.Size = new System.Drawing.Size(198, 34);
            // 
            // bukaTransaksiToolStripMenuItem
            // 
            this.bukaTransaksiToolStripMenuItem.Name = "bukaTransaksiToolStripMenuItem";
            this.bukaTransaksiToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.bukaTransaksiToolStripMenuItem.Text = "Buka Transaksi";
            this.bukaTransaksiToolStripMenuItem.Click += new System.EventHandler(this.bukaTransaksiToolStripMenuItem_Click);
            // 
            // FormBukaTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormBukaTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buka Transaksi";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksi)).EndInit();
            this.contextMenuStripBukaTransaksi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelNamaPasien;
        private System.Windows.Forms.Label labelNomorMR;
        private System.Windows.Forms.TextBox textBoxAlamatPasien;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNomorMR;
        private System.Windows.Forms.TextBox textBoxNamaPasien;
        private System.Windows.Forms.Label labelKeterangan;
        private System.Windows.Forms.DataGridView dataGridViewTransaksi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBukaTransaksi;
        private System.Windows.Forms.ToolStripMenuItem bukaTransaksiToolStripMenuItem;
    }
}