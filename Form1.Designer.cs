namespace MainForm
{
    partial class Form1
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
            panelMenu = new Panel();
            btnOdaDurumu = new Button();
            lblTitle = new Label();
            btnOdalar = new Button();
            btnYeniMisafir = new Button();
            panelMain = new Panel();
            dtpCikisTarihi = new DateTimePicker();
            label6 = new Label();
            btnKaydet = new Button();
            label5 = new Label();
            dtpGirisTarihi = new DateTimePicker();
            txtOdaNo = new TextBox();
            label4 = new Label();
            txtSoyadi = new TextBox();
            label3 = new Label();
            txtAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblOdaDurumu = new Label();
            panelMenu.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(45, 52, 54);
            panelMenu.Controls.Add(btnOdaDurumu);
            panelMenu.Controls.Add(lblTitle);
            panelMenu.Controls.Add(btnOdalar);
            panelMenu.Controls.Add(btnYeniMisafir);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(257, 519);
            panelMenu.TabIndex = 0;
            // 
            // btnOdaDurumu
            // 
            btnOdaDurumu.FlatAppearance.BorderSize = 0;
            btnOdaDurumu.FlatStyle = FlatStyle.Flat;
            btnOdaDurumu.Font = new Font("Segoe UI", 9.75F);
            btnOdaDurumu.ForeColor = Color.White;
            btnOdaDurumu.Location = new Point(0, 218);
            btnOdaDurumu.Margin = new Padding(4, 3, 4, 3);
            btnOdaDurumu.Name = "btnOdaDurumu";
            btnOdaDurumu.Padding = new Padding(12, 0, 0, 0);
            btnOdaDurumu.Size = new Size(257, 52);
            btnOdaDurumu.TabIndex = 4;
            btnOdaDurumu.Text = "Oda Durumları";
            btnOdaDurumu.TextAlign = ContentAlignment.MiddleLeft;
            btnOdaDurumu.UseVisualStyleBackColor = true;
            btnOdaDurumu.Click += btnOdaDurumu_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(40, 27);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(162, 21);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Otel Yönetim Paneli";
            // 
            // btnOdalar
            // 
            btnOdalar.FlatAppearance.BorderSize = 0;
            btnOdalar.FlatStyle = FlatStyle.Flat;
            btnOdalar.Font = new Font("Segoe UI", 9.75F);
            btnOdalar.ForeColor = Color.White;
            btnOdalar.Location = new Point(0, 160);
            btnOdalar.Margin = new Padding(4, 3, 4, 3);
            btnOdalar.Name = "btnOdalar";
            btnOdalar.Padding = new Padding(12, 0, 0, 0);
            btnOdalar.Size = new Size(257, 52);
            btnOdalar.TabIndex = 1;
            btnOdalar.Text = "Oda Yönetimi";
            btnOdalar.TextAlign = ContentAlignment.MiddleLeft;
            btnOdalar.UseVisualStyleBackColor = true;
            btnOdalar.Click += btnOdalar_Click;
            // 
            // btnYeniMisafir
            // 
            btnYeniMisafir.FlatAppearance.BorderSize = 0;
            btnYeniMisafir.FlatStyle = FlatStyle.Flat;
            btnYeniMisafir.Font = new Font("Segoe UI", 9.75F);
            btnYeniMisafir.ForeColor = Color.White;
            btnYeniMisafir.Location = new Point(0, 102);
            btnYeniMisafir.Margin = new Padding(4, 3, 4, 3);
            btnYeniMisafir.Name = "btnYeniMisafir";
            btnYeniMisafir.Padding = new Padding(12, 0, 0, 0);
            btnYeniMisafir.Size = new Size(257, 52);
            btnYeniMisafir.TabIndex = 0;
            btnYeniMisafir.Text = "Yeni Misafir Kaydı";
            btnYeniMisafir.TextAlign = ContentAlignment.MiddleLeft;
            btnYeniMisafir.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(lblOdaDurumu);
            panelMain.Controls.Add(dtpCikisTarihi);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(btnKaydet);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(dtpGirisTarihi);
            panelMain.Controls.Add(txtOdaNo);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(txtSoyadi);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(txtAdi);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(257, 0);
            panelMain.Margin = new Padding(4, 3, 4, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(676, 519);
            panelMain.TabIndex = 1;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Font = new Font("Segoe UI", 9.75F);
            dtpCikisTarihi.Location = new Point(166, 365);
            dtpCikisTarihi.Margin = new Padding(4, 3, 4, 3);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(356, 25);
            dtpCikisTarihi.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(162, 342);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 17);
            label6.TabIndex = 10;
            label6.Text = "Çıkış Tarihi:";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(0, 184, 148);
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(166, 425);
            btnKaydet.Margin = new Padding(4, 3, 4, 3);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(357, 50);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Misafiri Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(162, 273);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 8;
            label5.Text = "Giriş Tarihi:";
            // 
            // dtpGirisTarihi
            // 
            dtpGirisTarihi.Font = new Font("Segoe UI", 9.75F);
            dtpGirisTarihi.Location = new Point(166, 297);
            dtpGirisTarihi.Margin = new Padding(4, 3, 4, 3);
            dtpGirisTarihi.Name = "dtpGirisTarihi";
            dtpGirisTarihi.Size = new Size(356, 25);
            dtpGirisTarihi.TabIndex = 7;
            // 
            // txtOdaNo
            // 
            txtOdaNo.Font = new Font("Segoe UI", 9.75F);
            txtOdaNo.Location = new Point(166, 230);
            txtOdaNo.Margin = new Padding(4, 3, 4, 3);
            txtOdaNo.Name = "txtOdaNo";
            txtOdaNo.Size = new Size(356, 25);
            txtOdaNo.TabIndex = 6;
            txtOdaNo.TextChanged += txtOdaNo_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(162, 207);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 5;
            label4.Text = "Oda No:";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Font = new Font("Segoe UI", 9.75F);
            txtSoyadi.Location = new Point(166, 164);
            txtSoyadi.Margin = new Padding(4, 3, 4, 3);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(356, 25);
            txtSoyadi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(162, 141);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 3;
            label3.Text = "Misafir Soyadı:";
            // 
            // txtAdi
            // 
            txtAdi.Font = new Font("Segoe UI", 9.75F);
            txtAdi.Location = new Point(166, 98);
            txtAdi.Margin = new Padding(4, 3, 4, 3);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(356, 25);
            txtAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(162, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "Misafir Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 52, 54);
            label1.Location = new Point(160, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 0;
            label1.Text = "Yeni Misafir Kaydı";
            // 
            // lblOdaDurumu
            // 
            lblOdaDurumu.AutoSize = true;
            lblOdaDurumu.Location = new Point(484, 273);
            lblOdaDurumu.Name = "lblOdaDurumu";
            lblOdaDurumu.Size = new Size(0, 15);
            lblOdaDurumu.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Otel Otomasyonu";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);

        }

        
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnYeniMisafir;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOdaDurumu;
        private Label lblOdaDurumu;
    }
}