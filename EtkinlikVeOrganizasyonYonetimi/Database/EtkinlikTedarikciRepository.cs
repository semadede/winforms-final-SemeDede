using EtkinlikVeOrganizasyonYonetimi.Models;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace EtkinlikVeOrganizasyonYonetimi.Database
{
    public class EtkinlikTedarikciRepository
    {
        public List<EtkinlikTedarikci> EtkinlikTedarikcileriniGetir(int etkinlikId)
        {
            List<EtkinlikTedarikci> liste = new List<EtkinlikTedarikci>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT et.*, t.FirmaAdi
                    FROM EtkinlikTedarikciler et
                    JOIN Tedarikciler t ON et.TedarikciId = t.TedarikciId
                    WHERE et.EtkinlikId = @EtkinlikId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EtkinlikId", etkinlikId);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new EtkinlikTedarikci
                    {
                        Id = (int)reader["Id"],
                        EtkinlikId = (int)reader["EtkinlikId"],
                        TedarikciId = (int)reader["TedarikciId"],
                        FirmaAdi = reader["FirmaAdi"].ToString(),
                        TeslimTarihi = (DateTime)reader["TeslimTarihi"],
                        TeslimOnaylandi = (bool)reader["TeslimOnaylandi"],
                        Notlar = reader["Notlar"].ToString(),
                        Durum = reader["Durum"].ToString()
                    });
                }
            }

            return liste;
        }

        public void TedarikciAta(EtkinlikTedarikci atama)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO EtkinlikTedarikciler 
                    (EtkinlikId, TedarikciId, TeslimTarihi, TeslimOnaylandi, Notlar, Durum)
                    VALUES 
                    (@EtkinlikId, @TedarikciId, @TeslimTarihi, @TeslimOnaylandi, @Notlar, @Durum)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EtkinlikId", atama.EtkinlikId);
                cmd.Parameters.AddWithValue("@TedarikciId", atama.TedarikciId);
                cmd.Parameters.AddWithValue("@TeslimTarihi", atama.TeslimTarihi);
                cmd.Parameters.AddWithValue("@TeslimOnaylandi", atama.TeslimOnaylandi);
                cmd.Parameters.AddWithValue("@Notlar", atama.Notlar ?? "");
                cmd.Parameters.AddWithValue("@Durum", atama.Durum);
                cmd.ExecuteNonQuery();
            }
        }

        // Atama siler
        public void AtamaSil(int id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM EtkinlikTedarikciler WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // 48 saat kontrolu — teslim onayi olmayan tedarikcileri Kritik yap
        public void KritikTedarikciGuncelle()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    UPDATE EtkinlikTedarikciler
                    SET Durum = 'Kritik'
                    WHERE TeslimOnaylandi = 0
                    AND Durum != 'Iptal'
                    AND EXISTS (
                        SELECT 1 FROM Etkinlikler e 
                        WHERE e.EtkinlikId = EtkinlikTedarikciler.EtkinlikId
                        AND DATEDIFF(HOUR, GETDATE(), e.BaslangicTarihi) <= 48
                        AND DATEDIFF(HOUR, GETDATE(), e.BaslangicTarihi) > 0
                    )";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}