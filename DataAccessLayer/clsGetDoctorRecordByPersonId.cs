using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsGetDoctorRecordByPersonId
    {
        readonly static string QueryGetByPersonID = @"Select * From DoctorsFullDetails
      where DoctorsFullDetails.PersonId = @ID ";

        readonly static string QueryGetByDoctorID = @"Select * From DoctorsFullDetails
                     where DoctorId = @ID  " ; 

        public static DataTable GetDoctorByPersonID(int PersonID)
        {
              DataTable table = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(QueryGetByPersonID, connection);
                command.Parameters.AddWithValue("@ID", PersonID);

                SqlDataReader reader = command.ExecuteReader();

              if(reader.HasRows)  table.Load(reader);
              reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }

            return table;
        }

        public static DataTable GetDoctorByDoctorID(int DoctorID)
        {
            DataTable table = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(QueryGetByDoctorID, connection);
                command.Parameters.AddWithValue("@ID", DoctorID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) table.Load(reader);
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }

            return table;
        }

    }
}
