using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    internal static class dbSettings
    {
        public static string ConnectionString =
    @"Server=OSAMA-PC;Database=Simple_Clinic;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection DbConnection()
        {
            try { return new SqlConnection(ConnectionString); }
            catch { return null;  }
        }


    }


}
