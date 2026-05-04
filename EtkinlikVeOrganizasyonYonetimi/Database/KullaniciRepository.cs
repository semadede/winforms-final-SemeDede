using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Database
{
    public class KullaniciRepository
    {
        public Kullanici GirisYap(string kullaniciAdi, string sifre)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", sifre);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Kullanici
                    {
                        KullaniciId = (int)reader["KullaniciId"],
                        KullaniciAdi = reader["KullaniciAdi"].ToString(),
                        Rol = reader["Rol"].ToString()
                    };
                }
                return null;
            }
        }

        public List<Kullanici> TumKullanicilariGetir()
        {
            List<Kullanici> liste = new List<Kullanici>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Kullanicilar ORDER BY KullaniciAdi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new Kullanici
                    {
                        KullaniciId = (int)reader["KullaniciId"],
                        KullaniciAdi = reader["KullaniciAdi"].ToString(),
                        Rol = reader["Rol"].ToString()
                    });
                }
            }

            return liste;
        }

        public void KullaniciEkle(string kullaniciAdi, string sifre, string rol)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Rol) VALUES (@KullaniciAdi, @Sifre, @Rol)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", sifre);
                cmd.Parameters.AddWithValue("@Rol", rol);
                cmd.ExecuteNonQuery();
            }
        }

        public void KullaniciSil(int kullaniciId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Kullanicilar WHERE KullaniciId = @KullaniciId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@KullaniciId", kullaniciId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Kullanici> SadeceMusterileriGetir()
        {
            List<Kullanici> liste = new List<Kullanici>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Kullanicilar WHERE Rol = 'Kullanici' ORDER BY KullaniciAdi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new Kullanici
                    {
                        KullaniciId = (int)reader["KullaniciId"],
                        KullaniciAdi = reader["KullaniciAdi"].ToString(),
                        Rol = reader["Rol"].ToString()
                    });
                }
            }

            return liste;
        }
    }
}