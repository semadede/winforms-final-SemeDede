using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Database
{
    public class MekanRepository
    {
        public List<Mekan> TumMekanlariGetir()
        {
            List<Mekan> liste = new List<Mekan>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Mekanlar ORDER BY MekanAdi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new Mekan
                    {
                        MekanId = (int)reader["MekanId"],
                        MekanAdi = reader["MekanAdi"].ToString(),
                        Kapasite = (int)reader["Kapasite"],
                        Adres = reader["Adres"].ToString(),
                        KurulumSuresiSaat = (int)reader["KurulumSuresiSaat"]
                    });
                }
            }

            return liste;
        }

        public void MekanEkle(Mekan mekan)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO Mekanlar (MekanAdi, Kapasite, Adres, KurulumSuresiSaat) VALUES (@MekanAdi, @Kapasite, @Adres, @KurulumSuresiSaat)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MekanAdi", mekan.MekanAdi);
                cmd.Parameters.AddWithValue("@Kapasite", mekan.Kapasite);
                cmd.Parameters.AddWithValue("@Adres", mekan.Adres ?? "");
                cmd.Parameters.AddWithValue("@KurulumSuresiSaat", mekan.KurulumSuresiSaat);
                cmd.ExecuteNonQuery();
            }
        }

        public void MekanSil(int mekanId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Mekanlar WHERE MekanId = @MekanId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MekanId", mekanId);
                cmd.ExecuteNonQuery();
            }
        }

    }
        
}