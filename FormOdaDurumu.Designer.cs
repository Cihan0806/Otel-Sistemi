namespace MainForm
{
    partial class FormOdaDurumu
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
            this.flpOdalar = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOdaDurumSonuc = new System.Windows.Forms.Label();
            this.btnOdaAra = new System.Windows.Forms.Button();
            this.txtOdaNoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpOdalar
            // 
            this.flpOdalar.AutoScroll = true;
            this.flpOdalar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpOdalar.Location = new System.Drawing.Point(12, 12);
            this.flpOdalar.Name = "flpOdalar";
            this.flpOdalar.Size = new System.Drawing.Size(538, 426);
            this.flpOdalar.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOdaDurumSonuc);
            this.groupBox1.Controls.Add(this.btnOdaAra);
            this.groupBox1.Controls.Add(this.txtOdaNoAra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(556, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oda Sorgula";
            // 
            // lblOdaDurumSonuc
            // 
            this.lblOdaDurumSonuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaDurumSonuc.Location = new System.Drawing.Point(6, 114);
            this.lblOdaDurumSonuc.Name = "lblOdaDurumSonuc";
            this.lblOdaDurumSonuc.Size = new System.Drawing.Size(220, 43);
            this.lblOdaDurumSonuc.TabIndex = 3;
            this.lblOdaDurumSonuc.Text = "Sonuç Bekleniyor...";
            this.lblOdaDurumSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOdaAra
            // 
            this.btnOdaAra.Location = new System.Drawing.Point(127, 72);
            this.btnOdaAra.Name = "btnOdaAra";
            this.btnOdaAra.Size = new System.Drawing.Size(99, 29);
            this.btnOdaAra.TabIndex = 2;
            this.btnOdaAra.Text = "Sorgula";
            this.btnOdaAra.UseVisualStyleBackColor = true;
            this.btnOdaAra.Click += new System.EventHandler(this.btnOdaAra_Click);
            // 
            // txtOdaNoAra
            // 
            this.txtOdaNoAra.Location = new System.Drawing.Point(10, 75);
            this.txtOdaNoAra.Name = "txtOdaNoAra";
            this.txtOdaNoAra.Size = new System.Drawing.Size(111, 25);
            this.txtOdaNoAra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda Numarası:";
            // 
            // FormOdaDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpOdalar);
            this.Name = "FormOdaDurumu";
            this.Text = "Tüm Odaların Durumu";
            this.Load += new System.EventHandler(this.FormOdaDurumu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.FlowLayoutPanel flpOdalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdaAra;
        private System.Windows.Forms.TextBox txtOdaNoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOdaDurumSonuc;
    }
}