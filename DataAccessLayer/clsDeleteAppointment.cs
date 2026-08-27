using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static  class clsDeleteAppointment
    {
        readonly static string Query = @"
      Delete AppointmentDoctorPatient
     Where AppointmentDoctorPatient.AppointmentId = @ID ; ";


        public static bool DeleteAppointment(int AppointmentID)
        {
            SqlConnection connection = dbSettings.DbConnection();
            bool res = false;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@ID", AppointmentID);

                object result = command.ExecuteNonQuery();

                if(result!=null && int.TryParse(result.ToString() , out int NumOfAffectedRows) && NumOfAffectedRows>0 )
                {
                    res = true;
                }


            }
            catch { }
            finally
            {
                connection.Close();
            }
            
            return res;

        }

    }

}
