using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using EtkinlikVeOrganizasyonYonetimi.Models;

namespace EtkinlikVeOrganizasyonYonetimi.Database
{
    public class EtkinlikTurRepository
    {
        public List<EtkinlikTur> TumTurleriGetir()
        {
            List<EtkinlikTur> liste = new List<EtkinlikTur>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM EtkinlikTurleri ORDER BY TurAdi";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    liste.Add(new EtkinlikTur
                    {
                        TurId = (int)reader["TurId"],
                        TurAdi = reader["TurAdi"].ToString()
                    });
                }
            }

            return liste;
        }
    }
}