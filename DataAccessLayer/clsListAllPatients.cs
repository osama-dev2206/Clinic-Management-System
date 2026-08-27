using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsListAllPatients
    {
        static string query = " Select * From PatientFullDetails;";

        public static DataTable ListAllPatients()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                var Reader = cmd.ExecuteReader();

                if(Reader.HasRows) dt.Load(Reader);

                Reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

    }
}
