using System;
using System.Data;
using System.Windows.Forms;

namespace MainForm
{
    public partial class FormOdaYonetimi : Form
    {
        private DatabaseHelper dbHelper;

        public FormOdaYonetimi(DatabaseHelper db)
        {
            InitializeComponent();
            this.dbHelper = db;
        }

        private void FormOdaYonetimi_Load(object sender, EventArgs e)
        {
            ListeyiGuncelle();
        }

        private void ListeyiGuncelle()
        {
            try
            {
                DataTable doluOdalar = dbHelper.GetDoluOdalar();
                dgvDoluOdalar.DataSource = doluOdalar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda listesi yüklenirken hata oluþtu: " + ex.Message);
            }
        }

        
        private void misafiriCikarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (dgvDoluOdalar.SelectedRows.Count > 0)
            {
                
                int seciliOdaNo = Convert.ToInt32(dgvDoluOdalar.SelectedRows[0].Cells["OdaNo"].Value);

                
                DialogResult dialogResult = MessageBox.Show(seciliOdaNo + " nolu odadaki misafirin çýkýþýný yapmak istediðinize emin misiniz?", "Çýkýþ Onayý", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    string sonuc = dbHelper.CheckOutGuest(seciliOdaNo);
                    MessageBox.Show(sonuc);

                   
                    ListeyiGuncelle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen çýkarmak istediðiniz misafirin bulunduðu satýrý seçin.");
            }
        }

        private void dgvDoluOdalar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (this.dgvDoluOdalar.Columns[e.ColumnIndex].Name == "KalanGun")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int gunSayisi))
                {
                    
                    if (gunSayisi <= 0)
                    {
                        e.CellStyle.BackColor = Color.Red;       
                        e.CellStyle.ForeColor = Color.White;     

                        
                        e.CellStyle.SelectionBackColor = Color.DarkRed;
                        e.CellStyle.SelectionForeColor = Color.White;
                    }
                    
                    else
                    {
                        e.CellStyle.BackColor = Color.White;
                        e.CellStyle.ForeColor = Color.Black;
                        
                        e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                        e.CellStyle.SelectionForeColor = SystemColors.HighlightText;
                    }
                }
            }
        }
    }
}