using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Database
{
    public class TedarikciRepository
    {
        public List<Tedarikci> TumTedarikcileriGetir()
        {
            List<Tedarikci> liste = new List<Tedarikci>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT t.*, k.KategoriAdi 
                    FROM Tedarikciler t
                    JOIN Kategoriler k ON t.KategoriId = k.KategoriId
                    ORDER BY t.FirmaAdi";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new Tedarikci
                    {
                        TedarikciId = (int)reader["TedarikciId"],
                        FirmaAdi = reader["FirmaAdi"].ToString(),
                        KategoriId = (int)reader["KategoriId"],
                        KategoriAdi = reader["KategoriAdi"].ToString(),
                        Telefon = reader["Telefon"].ToString(),
                        Aktif = (bool)reader["Aktif"]
                    });
                }
            }

            return liste;
        }

        public void TedarikciEkle(Tedarikci tedarikci)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO Tedarikciler (FirmaAdi, KategoriId, Telefon, Aktif) VALUES (@FirmaAdi, @KategoriId, @Telefon, @Aktif)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirmaAdi", tedarikci.FirmaAdi);
                cmd.Parameters.AddWithValue("@KategoriId", tedarikci.KategoriId);
                cmd.Parameters.AddWithValue("@Telefon", tedarikci.Telefon ?? "");
                cmd.Parameters.AddWithValue("@Aktif", tedarikci.Aktif);
                cmd.ExecuteNonQuery();
            }
        }

        public void TedarikciSil(int tedarikciId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Tedarikciler WHERE TedarikciId = @TedarikciId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TedarikciId", tedarikciId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Tedarikci> KategoriAdinaGoreTedarikcileriGetir(int kategoriId)
        {
            List<Tedarikci> liste = new List<Tedarikci>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT t.*, k.KategoriAdi 
                    FROM Tedarikciler t
                    JOIN Kategoriler k ON t.KategoriId = k.KategoriId
                    WHERE t.KategoriId = @KategoriId AND t.Aktif = 1";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@KategoriId", kategoriId);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new Tedarikci
                    {
                        TedarikciId = (int)reader["TedarikciId"],
                        FirmaAdi = reader["FirmaAdi"].ToString(),
                        KategoriId = (int)reader["KategoriId"],
                        KategoriAdi = reader["KategoriAdi"].ToString(),
                        Telefon = reader["Telefon"].ToString(),
                        Aktif = (bool)reader["Aktif"]
                    });
                }
            }

            return liste;
        }
    }
}