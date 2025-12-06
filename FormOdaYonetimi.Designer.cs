namespace MainForm
{
    partial class FormOdaYonetimi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvDoluOdalar = new DataGridView();
            OdaNo = new DataGridViewTextBoxColumn();
            MisafirAdi = new DataGridViewTextBoxColumn();
            GirisTarihi = new DataGridViewTextBoxColumn();
            CikisTarihi = new DataGridViewTextBoxColumn();
            KalanGun = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            misafiriÇıkarToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDoluOdalar).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDoluOdalar
            // 
            dgvDoluOdalar.AllowUserToAddRows = false;
            dgvDoluOdalar.AllowUserToDeleteRows = false;
            dgvDoluOdalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoluOdalar.BackgroundColor = Color.White;
            dgvDoluOdalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoluOdalar.Columns.AddRange(new DataGridViewColumn[] { OdaNo, MisafirAdi, GirisTarihi, CikisTarihi, KalanGun });
            dgvDoluOdalar.ContextMenuStrip = contextMenuStrip1;
            dgvDoluOdalar.Location = new Point(14, 61);
            dgvDoluOdalar.Margin = new Padding(4, 3, 4, 3);
            dgvDoluOdalar.Name = "dgvDoluOdalar";
            dgvDoluOdalar.ReadOnly = true;
            dgvDoluOdalar.RowHeadersVisible = false;
            dgvDoluOdalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoluOdalar.Size = new Size(905, 444);
            dgvDoluOdalar.TabIndex = 0;
            dgvDoluOdalar.CellFormatting += dgvDoluOdalar_CellFormatting;
            // 
            // OdaNo
            // 
            OdaNo.DataPropertyName = "OdaNo";
            OdaNo.HeaderText = "Oda No";
            OdaNo.Name = "OdaNo";
            OdaNo.ReadOnly = true;
            // 
            // MisafirAdi
            // 
            MisafirAdi.DataPropertyName = "MisafirAdi";
            MisafirAdi.HeaderText = "Misafir Adı Soyadı";
            MisafirAdi.Name = "MisafirAdi";
            MisafirAdi.ReadOnly = true;
            // 
            // GirisTarihi
            // 
            GirisTarihi.DataPropertyName = "GirisTarihi";
            GirisTarihi.HeaderText = "Giriş Tarihi";
            GirisTarihi.Name = "GirisTarihi";
            GirisTarihi.ReadOnly = true;
            // 
            // CikisTarihi
            // 
            CikisTarihi.DataPropertyName = "CikisTarihi";
            CikisTarihi.HeaderText = "Çıkış Tarihi";
            CikisTarihi.Name = "CikisTarihi";
            CikisTarihi.ReadOnly = true;
            // 
            // KalanGun
            // 
            KalanGun.DataPropertyName = "KalanGun";
            KalanGun.HeaderText = "Kalan Gün";
            KalanGun.Name = "KalanGun";
            KalanGun.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { misafiriÇıkarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(144, 26);
            // 
            // misafiriÇıkarToolStripMenuItem
            // 
            misafiriÇıkarToolStripMenuItem.Name = "misafiriÇıkarToolStripMenuItem";
            misafiriÇıkarToolStripMenuItem.Size = new Size(143, 22);
            misafiriÇıkarToolStripMenuItem.Text = "Misafiri Çıkar";
            misafiriÇıkarToolStripMenuItem.Click += misafiriCikarToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(14, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 30);
            label1.TabIndex = 1;
            label1.Text = "Dolu Odaların Durumu";
            // 
            // FormOdaYonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(label1);
            Controls.Add(dgvDoluOdalar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormOdaYonetimi";
            Text = "Oda Yönetim Paneli";
            Load += FormOdaYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDoluOdalar).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        
        private System.Windows.Forms.DataGridView dgvDoluOdalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MisafirAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CikisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KalanGun;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem misafiriÇıkarToolStripMenuItem;
    }
}