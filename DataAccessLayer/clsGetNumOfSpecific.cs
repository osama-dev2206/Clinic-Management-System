using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsGetNumOfSpecific
    {
        static string query = @"Select Count(*) As NumOfAppointments From Appointment;";

      public static int GetNumOfAppointments()
        {
            int numOfAppointments = 0;
          SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                int.TryParse(cmd.ExecuteScalar().ToString(), out numOfAppointments);
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }
            return numOfAppointments;
        }

    }
}
