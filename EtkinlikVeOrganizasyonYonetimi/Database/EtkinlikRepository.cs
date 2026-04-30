using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Database
{
    public class EtkinlikRepository
    {
        // Tüm etkinlikleri mekan ve tür adlarıyla birlikte getirir
        public List<Etkinlik> TumEtkinlikleriGetir()
        {
            List<Etkinlik> liste = new List<Etkinlik>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT e.*, m.MekanAdi, t.TurAdi 
                    FROM Etkinlikler e
                    JOIN Mekanlar m ON e.MekanId = m.MekanId
                    JOIN EtkinlikTurleri t ON e.TurId = t.TurId
                    ORDER BY e.BaslangicTarihi DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new Etkinlik
                    {
                        EtkinlikId = (int)reader["EtkinlikId"],
                        EtkinlikAdi = reader["EtkinlikAdi"].ToString(),
                        TurId = (int)reader["TurId"],
                        TurAdi = reader["TurAdi"].ToString(),
                        MekanId = (int)reader["MekanId"],
                        MekanAdi = reader["MekanAdi"].ToString(),
                        BaslangicTarihi = (DateTime)reader["BaslangicTarihi"],
                        BitisTarihi = (DateTime)reader["BitisTarihi"],
                        MusteriAdi = reader["MusteriAdi"].ToString(),
                        MusteriTelefon = reader["MusteriTelefon"].ToString(),
                        Durum = reader["Durum"].ToString(),
                        SozlesmeBedeli = (decimal)reader["SozlesmeBedeli"],
                        OlusturanKullaniciId = reader["OlusturanKullaniciId"] == DBNull.Value ? 0 : (int)reader["OlusturanKullaniciId"]
                    });
                }
            }

            return liste;
        }

        // Etkinlik siler
        public void EtkinlikSil(int etkinlikId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Etkinlikler WHERE EtkinlikId = @EtkinlikId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EtkinlikId", etkinlikId);
                cmd.ExecuteNonQuery();
            }
        }

        // Tek etkinlik getirir (düzenleme için)
        public Etkinlik EtkinlikGetir(int etkinlikId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT e.*, m.MekanAdi, t.TurAdi 
                    FROM Etkinlikler e
                    JOIN Mekanlar m ON e.MekanId = m.MekanId
                    JOIN EtkinlikTurleri t ON e.TurId = t.TurId
                    WHERE e.EtkinlikId = @EtkinlikId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EtkinlikId", etkinlikId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Etkinlik
                    {
                        EtkinlikId = (int)reader["EtkinlikId"],
                        EtkinlikAdi = reader["EtkinlikAdi"].ToString(),
                        TurId = (int)reader["TurId"],
                        TurAdi = reader["TurAdi"].ToString(),
                        MekanId = (int)reader["MekanId"],
                        MekanAdi = reader["MekanAdi"].ToString(),
                        BaslangicTarihi = (DateTime)reader["BaslangicTarihi"],
                        BitisTarihi = (DateTime)reader["BitisTarihi"],
                        MusteriAdi = reader["MusteriAdi"].ToString(),
                        MusteriTelefon = reader["MusteriTelefon"].ToString(),
                        Durum = reader["Durum"].ToString(),
                        SozlesmeBedeli = (decimal)reader["SozlesmeBedeli"],
                        OlusturanKullaniciId = reader["OlusturanKullaniciId"] == DBNull.Value ? 0 : (int)reader["OlusturanKullaniciId"]
                    };
                }

                return null;
            }
        }

        // Yeni etkinlik ekler
        public void EtkinlikEkle(Etkinlik etkinlik)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Etkinlikler 
                    (EtkinlikAdi, TurId, MekanId, BaslangicTarihi, BitisTarihi, MusteriAdi, MusteriTelefon, Durum, SozlesmeBedeli, OlusturanKullaniciId)
                    VALUES 
                    (@EtkinlikAdi, @TurId, @MekanId, @BaslangicTarihi, @BitisTarihi, @MusteriAdi, @MusteriTelefon, @Durum, @SozlesmeBedeli, @OlusturanKullaniciId)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EtkinlikAdi", etkinlik.EtkinlikAdi);
                cmd.Parameters.AddWithValue("@TurId", etkinlik.TurId);
                cmd.Parameters.AddWithValue("@MekanId", etkinlik.MekanId);
                cmd.Parameters.AddWithValue("@BaslangicTarihi", etkinlik.BaslangicTarihi);
                cmd.Parameters.AddWithValue("@BitisTarihi", etkinlik.BitisTarihi);
                cmd.Parameters.AddWithValue("@MusteriAdi", etkinlik.MusteriAdi);
                cmd.Parameters.AddWithValue("@MusteriTelefon", etkinlik.MusteriTelefon ?? "");
                cmd.Parameters.AddWithValue("@Durum", etkinlik.Durum);
                cmd.Parameters.AddWithValue("@SozlesmeBedeli", etkinlik.SozlesmeBedeli);
                cmd.Parameters.AddWithValue("@OlusturanKullaniciId", etkinlik.OlusturanKullaniciId);
                cmd.ExecuteNonQuery();
            }
        }

        // Etkinlik günceller
        public void EtkinlikGuncelle(Etkinlik etkinlik)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    UPDATE Etkinlikler SET
                    EtkinlikAdi = @EtkinlikAdi,
                    TurId = @TurId,
                    MekanId = @MekanId,
                    BaslangicTarihi = @BaslangicTarihi,
                    BitisTarihi = @BitisTarihi,
                    MusteriAdi = @MusteriAdi,
                    MusteriTelefon = @MusteriTelefon,
                    Durum = @Durum,
                    SozlesmeBedeli = @SozlesmeBedeli
                    WHERE EtkinlikId = @EtkinlikId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EtkinlikAdi", etkinlik.EtkinlikAdi);
                cmd.Parameters.AddWithValue("@TurId", etkinlik.TurId);
                cmd.Parameters.AddWithValue("@MekanId", etkinlik.MekanId);
                cmd.Parameters.AddWithValue("@BaslangicTarihi", etkinlik.BaslangicTarihi);
                cmd.Parameters.AddWithValue("@BitisTarihi", etkinlik.BitisTarihi);
                cmd.Parameters.AddWithValue("@MusteriAdi", etkinlik.MusteriAdi);
                cmd.Parameters.AddWithValue("@MusteriTelefon", etkinlik.MusteriTelefon ?? "");
                cmd.Parameters.AddWithValue("@Durum", etkinlik.Durum);
                cmd.Parameters.AddWithValue("@SozlesmeBedeli", etkinlik.SozlesmeBedeli);
                cmd.Parameters.AddWithValue("@EtkinlikId", etkinlik.EtkinlikId);
                cmd.ExecuteNonQuery();
            }
        }

        // Mekan çakışma kontrolü
        public bool CakismaVarMi(int mekanId, DateTime baslangic, DateTime bitis, int kurulumSuresiSaat, int? haricEtkinlikId = null)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Kurulum süresi dahil kontrol
                DateTime genisBitis = bitis.AddHours(kurulumSuresiSaat);
                DateTime genisBaslangic = baslangic.AddHours(-kurulumSuresiSaat);

                string sql = @"
                    SELECT COUNT(*) FROM Etkinlikler 
                    WHERE MekanId = @MekanId 
                    AND Durum != 'Iptal'
                    AND (@Baslangic < BitisTarihi AND @Bitis > BaslangicTarihi)";

                if (haricEtkinlikId.HasValue)
                    sql += " AND EtkinlikId != @HaricId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MekanId", mekanId);
                cmd.Parameters.AddWithValue("@Baslangic", genisBaslangic);
                cmd.Parameters.AddWithValue("@Bitis", genisBitis);

                if (haricEtkinlikId.HasValue)
                    cmd.Parameters.AddWithValue("@HaricId", haricEtkinlikId.Value);

                int sayi = (int)cmd.ExecuteScalar();
                return sayi > 0;
            }
        }
    }
}