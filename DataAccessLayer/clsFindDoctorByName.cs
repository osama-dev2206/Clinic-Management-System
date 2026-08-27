using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data_Access_Layer
{
   public static class clsFindDoctorByName
    {

        readonly static string Query = @"Select * from DoctorsFullDetails
         Where DoctorName =  @Name ; "; 

        public static DataTable FindDoctorByName(string Name)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@Name", Name);

                SqlDataReader sqlData = cmd.ExecuteReader();
                dataTable.Load(sqlData);

            }
            catch
            { }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

    }
}
