using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsListAllDoctors
    {
        static string Query = @"Select * From DoctorsFullDetails; ";

        public static DataTable ListAllDoctors()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

              if(reader.HasRows) dt.Load(reader);
                reader.Close();
            }
            catch
            { }
            finally
            {
                connection.Close();
            }
            return dt; 
        }

    }


}
