using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipManager
{
    public class VeriTabaniBaglantisi
    {
        public static SqlConnection GetConnection
        {
            get
            {
                SqlConnection conn = new("Server=DESKTOP-UQD4ET0; Database=PersonelTakip; TrustServerCertificate=True; Trusted_Connection=True;");
                conn.Open();
                return conn;
            }
        }
    }
}
