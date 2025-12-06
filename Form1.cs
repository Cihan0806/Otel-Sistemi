using System;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        private DatabaseHelper dbHelper;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string connectionString = "Server=VDSIPADRESI;Database=DATABASEADI;Uid=KULLANICIADI;Pwd=MYSQLSIFRESI;";

            dbHelper = new DatabaseHelper(connectionString);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adi = txtAdi.Text;
            string soyadi = txtSoyadi.Text;
            if (!int.TryParse(txtOdaNo.Text, out int odaNo))
            {
                MessageBox.Show("Oda numarası geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime girisTarihi = dtpGirisTarihi.Value;
            DateTime cikisTarihi = dtpCikisTarihi.Value;

            if (string.IsNullOrWhiteSpace(adi) || string.IsNullOrWhiteSpace(soyadi))
            {
                MessageBox.Show("Ad ve Soyad alanları boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cikisTarihi.Date <= girisTarihi.Date)
            {
                MessageBox.Show("Çıkış tarihi, giriş tarihinden en az 1 gün sonra olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!dbHelper.CheckRoomAvailability(odaNo))
            {
                MessageBox.Show($"Oda {odaNo} dolu veya geçersiz. Lütfen başka bir oda seçin.", "Oda Dolu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Misafir yeniMisafir = new Misafir
            {
                Adi = adi,
                Soyadi = soyadi,
                OdaNo = odaNo,
                GirisTarihi = girisTarihi,
                CikisTarihi = cikisTarihi
            };

            string sonuc = dbHelper.RegisterGuest(yeniMisafir);
            MessageBox.Show(sonuc, "Kayıt Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (sonuc.StartsWith("Misafir başarıyla"))
            {
                txtAdi.Clear();
                txtSoyadi.Clear();
                txtOdaNo.Clear();
            }
        }


        private void btnOdalar_Click(object sender, EventArgs e)
        {
            FormOdaYonetimi odaFormu = new FormOdaYonetimi(dbHelper);
            odaFormu.Show();
        }


        private void btnOdaDurumu_Click(object sender, EventArgs e)
        {
            FormOdaDurumu durumFormu = new FormOdaDurumu(dbHelper);
            durumFormu.Show();
        }

        private void txtOdaNo_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtOdaNo.Text))
            {
                lblOdaDurumu.Text = "";
                return;
            }


            if (int.TryParse(txtOdaNo.Text, out int odaNo))
            {

                bool musaitMi = dbHelper.CheckRoomAvailability(odaNo);

                if (musaitMi)
                {
                    lblOdaDurumu.Text = "✓ Oda Boş (Müsait)";
                    lblOdaDurumu.ForeColor = Color.Green;
                }
                else
                {
                    lblOdaDurumu.Text = "X Oda Dolu!";
                    lblOdaDurumu.ForeColor = Color.Red;
                }
            }
            else
            {

                lblOdaDurumu.Text = "Lütfen sadece sayı girin";
                lblOdaDurumu.ForeColor = Color.Orange;
            }
        }

        private void txtAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}