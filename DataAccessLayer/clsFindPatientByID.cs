using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsFindPatientByID
    {
        private static string Query = @"Select * From PatientDetailsForFinding
       Where PatientDetailsForFinding.PatientId = @ID ; ";

        public static DataTable FindPatinetByID(int PatientId)
        {
            DataTable table = new DataTable();
            SqlConnection Connection = dbSettings.DbConnection();
            try
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", PatientId);

                SqlDataReader reader = Command.ExecuteReader();

                table.Load(reader);

            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }

            return table;
        }


    }
}
