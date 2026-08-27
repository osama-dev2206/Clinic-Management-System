using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsGetPatientRecordByName
    {
        readonly static string Quert = @"Select * from PatientFullDetails
       Where Name = @Name ;";

        public static DataTable GetPatientRecordByName(string Name)
        {

            SqlConnection connection = dbSettings.DbConnection();
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Quert, connection);
                cmd.Parameters.AddWithValue("@Name", Name);

                SqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);

            }
            catch { }
            finally
            {
                connection.Close();
            }

            return dt;
        }

    }
}
