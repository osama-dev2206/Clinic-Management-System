using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsListAllAppointments
    {
        static string query = @" Select * from AppointmentDetails;";

        public static DataTable ListAllAppointments()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                
                SqlDataReader reader = cmd.ExecuteReader();
             
                   if(reader.HasRows) dt.Load(reader);
                   reader.Close();
 
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
