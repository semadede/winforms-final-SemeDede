using EtkinlikVeOrganizasyonYonetimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace EtkinlikVeOrganizasyonYonetimi.Database
{
    public class ButceRepository
    {
        public Butce ButceGetir(int etkinlikId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Butceler WHERE EtkinlikId = @EtkinlikId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EtkinlikId", etkinlikId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Butce
                    {
                        ButceId = (int)reader["ButceId"],
                        EtkinlikId = (int)reader["EtkinlikId"],
                        PlanlananButce = (decimal)reader["PlanlananButce"],
                        YoneticiOnayi = (bool)reader["YoneticiOnayi"]
                    };
                }

                return null;
            }
        }

        public void ButceKaydet(int etkinlikId, decimal planlananButce)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Önce var mı kontrol et
                string kontrol = "SELECT COUNT(*) FROM Butceler WHERE EtkinlikId = @EtkinlikId";
                SqlCommand kontrolCmd = new SqlCommand(kontrol, conn);
                kontrolCmd.Parameters.AddWithValue("@EtkinlikId", etkinlikId);
                int sayi = (int)kontrolCmd.ExecuteScalar();

                if (sayi > 0)
                {
                    // Güncelle
                    string update = "UPDATE Butceler SET PlanlananButce = @PlanlananButce WHERE EtkinlikId = @EtkinlikId";
                    SqlCommand updateCmd = new SqlCommand(update, conn);
                    updateCmd.Parameters.AddWithValue("@PlanlananButce", planlananButce);
                    updateCmd.Parameters.AddWithValue("@EtkinlikId", etkinlikId);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    // Yeni ekle
                    string insert = "INSERT INTO Butceler (EtkinlikId, PlanlananButce, YoneticiOnayi) VALUES (@EtkinlikId, @PlanlananButce, 0)";
                    SqlCommand insertCmd = new SqlCommand(insert, conn);
                    insertCmd.Parameters.AddWithValue("@EtkinlikId", etkinlikId);
                    insertCmd.Parameters.AddWithValue("@PlanlananButce", planlananButce);
                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        public decimal GerceklesenToplamGetir(int etkinlikId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT ISNULL(SUM(gm.Tutar), 0)
                    FROM GerceklesenMaliyetler gm
                    JOIN Butceler b ON gm.ButceId = b.ButceId
                    WHERE b.EtkinlikId = @EtkinlikId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EtkinlikId", etkinlikId);
                return (decimal)cmd.ExecuteScalar();
            }
        }

        public List<GerceklesenMaliyet> MaliyetleriGetir(int etkinlikId)
        {
            List<GerceklesenMaliyet> liste = new List<GerceklesenMaliyet>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT gm.*
                    FROM GerceklesenMaliyetler gm
                    JOIN Butceler b ON gm.ButceId = b.ButceId
                    WHERE b.EtkinlikId = @EtkinlikId
                    ORDER BY gm.Tarih DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EtkinlikId", etkinlikId);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new GerceklesenMaliyet
                    {
                        MaliyetId = (int)reader["MaliyetId"],
                        ButceId = (int)reader["ButceId"],
                        Aciklama = reader["Aciklama"].ToString(),
                        Tutar = (decimal)reader["Tutar"],
                        Tarih = (DateTime)reader["Tarih"]
                    });
                }
            }

            return liste;
        }

        public void MaliyetEkle(GerceklesenMaliyet maliyet)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO GerceklesenMaliyetler (ButceId, Aciklama, Tutar, Tarih)
                    VALUES (@ButceId, @Aciklama, @Tutar, @Tarih)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ButceId", maliyet.ButceId);
                cmd.Parameters.AddWithValue("@Aciklama", maliyet.Aciklama);
                cmd.Parameters.AddWithValue("@Tutar", maliyet.Tutar);
                cmd.Parameters.AddWithValue("@Tarih", maliyet.Tarih);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

