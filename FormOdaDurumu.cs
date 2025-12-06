using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MainForm
{
    public partial class FormOdaDurumu : Form
    {
        private DatabaseHelper dbHelper;

        public FormOdaDurumu(DatabaseHelper db)
        {
            InitializeComponent();
            this.dbHelper = db;
        }

        private void FormOdaDurumu_Load(object sender, EventArgs e)
        {
            OdalarıGorsellestir();
        }

        private void OdalarıGorsellestir()
        {
            flpOdalar.Controls.Clear(); 

            Dictionary<int, string> odaDurumlari = dbHelper.GetAllRoomStatuses();

            foreach (var oda in odaDurumlari)
            {
                Button odaButonu = new Button();
                odaButonu.Text = oda.Key.ToString(); 
                odaButonu.Size = new Size(75, 75);
                odaButonu.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                odaButonu.ForeColor = Color.White;
                odaButonu.Margin = new Padding(5);

                
                if (oda.Value.Equals("Bos", StringComparison.OrdinalIgnoreCase))
                {
                    odaButonu.BackColor = Color.ForestGreen;
                }
                else
                {
                    odaButonu.BackColor = Color.IndianRed;
                }

                flpOdalar.Controls.Add(odaButonu);
            }
        }

        private void btnOdaAra_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOdaNoAra.Text, out int odaNo))
            {
                lblOdaDurumSonuc.Text = "Geçersiz Numara";
                lblOdaDurumSonuc.ForeColor = Color.Black;
                return;
            }

            string durum = dbHelper.GetRoomStatus(odaNo);

            if (durum == null)
            {
                lblOdaDurumSonuc.Text = "Oda Bulunamadı";
                lblOdaDurumSonuc.ForeColor = Color.Black;
            }
            else if (durum.Equals("Bos", StringComparison.OrdinalIgnoreCase))
            {
                lblOdaDurumSonuc.Text = "BOŞ";
                lblOdaDurumSonuc.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblOdaDurumSonuc.Text = "DOLU";
                lblOdaDurumSonuc.ForeColor = Color.IndianRed;
            }
        }
    }
}