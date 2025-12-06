using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic; 
using System.Data;
using System.Windows.Forms;


public class DatabaseHelper
{
    private string connectionString;

    
    public DatabaseHelper(string connStr)
    {
        this.connectionString = connStr;
    }

   
    private MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    
    public bool CheckRoomAvailability(int odaNo)
    {
        using (MySqlConnection conn = GetConnection())
        {
            try
            {
                conn.Open();
                string query = "SELECT Durumu FROM Odalar WHERE OdaNo = @OdaNo";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OdaNo", odaNo);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) 
                    {
                        string durum = reader["Durumu"].ToString();
                        return (durum.Equals("Bos", StringComparison.OrdinalIgnoreCase));
                    }
                    else 
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda kontrol hatası: " + ex.Message);
                return false;
            }
        }
    }

    
    public string RegisterGuest(Misafir guest)
    {
        using (MySqlConnection conn = GetConnection())
        {
            try
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    
                    string guestQuery = "INSERT INTO Misafirler (Adi, Soyadi, OdaNo, GirisTarihi, CikisTarihi) VALUES (@Adi, @Soyadi, @OdaNo, @GirisTarihi, @CikisTarihi)";
                    MySqlCommand guestCmd = new MySqlCommand(guestQuery, conn, transaction);
                    guestCmd.Parameters.AddWithValue("@Adi", guest.Adi);
                    guestCmd.Parameters.AddWithValue("@Soyadi", guest.Soyadi);
                    guestCmd.Parameters.AddWithValue("@OdaNo", guest.OdaNo);
                    guestCmd.Parameters.AddWithValue("@GirisTarihi", guest.GirisTarihi);
                    guestCmd.Parameters.AddWithValue("@CikisTarihi", guest.CikisTarihi);
                    guestCmd.ExecuteNonQuery();

                    
                    string roomQuery = "UPDATE Odalar SET Durumu = 'Dolu' WHERE OdaNo = @OdaNo";
                    MySqlCommand roomCmd = new MySqlCommand(roomQuery, conn, transaction);
                    roomCmd.Parameters.AddWithValue("@OdaNo", guest.OdaNo);
                    roomCmd.ExecuteNonQuery();

                    transaction.Commit();
                    return "Misafir başarıyla kaydedildi ve oda durumu 'Dolu' olarak güncellendi.";
                }
            }
            catch (Exception ex)
            {
                return "Kayıt hatası: " + ex.Message;
            }
        }
    }

    
    public Dictionary<int, string> GetAllRoomStatuses()
    {
        var statuses = new Dictionary<int, string>();
        using (MySqlConnection conn = GetConnection())
        {
            try
            {
                conn.Open();
                string query = "SELECT OdaNo, Durumu FROM Odalar ORDER BY OdaNo ASC";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statuses.Add(reader.GetInt32("OdaNo"), reader.GetString("Durumu"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda durumları çekilirken hata: " + ex.Message);
            }
        }
        return statuses;
    }

    
    public string GetRoomStatus(int odaNo)
    {
        string status = null;
        using (MySqlConnection conn = GetConnection())
        {
            try
            {
                conn.Open();
                string query = "SELECT Durumu FROM Odalar WHERE OdaNo = @OdaNo";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OdaNo", odaNo);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    status = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda durumu sorgulanırken hata: " + ex.Message);
            }
        }
        return status;
    }

    
    public string CheckOutGuest(int odaNo)
    {
        using (MySqlConnection conn = GetConnection())
        {
            try
            {
                conn.Open();
                
                string query = "UPDATE Odalar SET Durumu = 'Bos' WHERE OdaNo = @OdaNo";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OdaNo", odaNo);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return "Misafir çıkışı yapıldı ve oda 'Boş' olarak ayarlandı.";
                }
                else
                {
                    return "İşlem sırasında bir hata oluştu veya oda zaten boş.";
                }
            }
            catch (Exception ex)
            {
                return "Çıkış işlemi hatası: " + ex.Message;
            }
        }
    }

    
    public DataTable GetDoluOdalar()
    {
        DataTable dt = new DataTable();
        using (MySqlConnection conn = GetConnection())
        {
            try
            {
                conn.Open();
                
                string query = @"
                    SELECT 
                        o.OdaNo,
                        CONCAT(m.Adi, ' ', m.Soyadi) AS MisafirAdi,
                        m.GirisTarihi,
                        m.CikisTarihi,
                        DATEDIFF(m.CikisTarihi, CURDATE()) AS KalanGun
                    FROM 
                        Odalar o
                    JOIN 
                        Misafirler m ON o.OdaNo = m.OdaNo
                    WHERE 
                        o.Durumu = 'Dolu'
                    ORDER BY 
                        o.OdaNo;
                ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }
            return dt;
        }
    }
} 


public class Misafir
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public int OdaNo { get; set; }
    public DateTime GirisTarihi { get; set; }
    public DateTime CikisTarihi { get; set; }
}