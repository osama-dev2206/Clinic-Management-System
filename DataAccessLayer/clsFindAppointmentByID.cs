using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsFindAppointmentByID
    {
        readonly static string Query = @"select * from AppointmentDoctorPatient   -- Main table
       where AppointmentId = @ID ;  ";

        public static DataTable  FindAppointmentByID(int AppointmentID)
        {

            DataTable table =  new DataTable();

            SqlConnection connection = dbSettings.DbConnection();
            try
            {
                connection.Open(); 
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ID", AppointmentID);

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows ) table.Load(reader);
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
