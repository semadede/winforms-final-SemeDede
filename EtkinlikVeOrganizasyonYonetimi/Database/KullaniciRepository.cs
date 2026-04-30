using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Database
{
    public class KullaniciRepository
    {
        // Kullanıcı adı ve şifreyle giriş kontrolü yapar
        // Doğruysa Kullanici nesnesini döndürür, yanlışsa null döner
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
    }
}
