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
        static string Query = @"Select * From DoctorsFullDetails
      where DoctorsFullDetails.PersonId = @ID ";

        public static DataTable GetDoctorByPersonID(int PersonID)
        {
              DataTable table = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ID", PersonID);

                SqlDataReader reader = command.ExecuteReader();

                table.Load(reader);

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
