using EtkinlikVeOrganizasyonYonetimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace EtkinlikVeOrganizasyonYonetimi.Database
{
    public class KategoriRepository
    {
        public List<Kategori> TumKategorileriGetir()
        {
            List<Kategori> liste = new List<Kategori>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Kategoriler ORDER BY KategoriAdi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new Kategori
                    {
                        KategoriId = (int)reader["KategoriId"],
                        KategoriAdi = reader["KategoriAdi"].ToString(),
                        ZorunluMu = (bool)reader["ZorunluMu"]
                    });
                }
            }

            return liste;
        }
    }
}
