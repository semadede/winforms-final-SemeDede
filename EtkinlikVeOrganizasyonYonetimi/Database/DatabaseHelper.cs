using System.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtkinlikVeOrganizasyonYonetimi.Database
{
    public static class DatabaseHelper
    {

        // App.config'deki connection string'i okur
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["EtkinlikDB"].ConnectionString;

        // Veritabanına bağlantı nesnesi döndürür
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

    }
}
