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
        private readonly static string QueryGetByPersonID = @"Select * From PatientFullDetails
       Where PatientFullDetails.PersonId = @ID ; ";

        private readonly static string QueryGetByPatientID = @"Select * From PatientFullDetails
          where PatientId = @ID ; ";

        public static DataTable FindPatinetByPersonID(int PersonID)
        {
            DataTable table = new DataTable();
            SqlConnection Connection = dbSettings.DbConnection();
            try
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(QueryGetByPersonID, Connection);
                Command.Parameters.AddWithValue("@ID", PersonID);

                SqlDataReader reader = Command.ExecuteReader();

               if(reader.HasRows) table.Load(reader);
                reader.Close();
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


        public static DataTable FindPatinetByPatientID(int PatientID)
        {
            DataTable table = new DataTable();
            SqlConnection Connection = dbSettings.DbConnection();
            try
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(QueryGetByPatientID, Connection);
                Command.Parameters.AddWithValue("@ID", PatientID);

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows) table.Load(reader);
                reader.Close();
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
