using DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer
{
    public static class clsUpdateAppointment
    {
        readonly static string Query = @"      Update Appointment
      Set ADoctorId = @DoctorID , 
      APatientId = @PatientID ,
      AppointmentDateTime = @AppointmentDateTime ,
      AppoitmentStatus = @Status 
        where AppointmentId = @AppointmentID  ;";

       public static bool UpdateAppointment(int AppointmentID , int DoctorID , int PatientID , DateTime AppointmentDateTime ,
           string AppointmentStatus )
        {
            bool res = false;
            SqlConnection connection = dbSettings.DbConnection();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand( Query, connection );
                cmd.Parameters.AddWithValue("@AppointmentID",AppointmentID);
                cmd.Parameters.AddWithValue("@DoctorID", DoctorID);
                cmd.Parameters.AddWithValue("@PatientID", PatientID);
                cmd.Parameters.AddWithValue("@AppointmentDateTime", AppointmentDateTime);
                cmd.Parameters.AddWithValue("@Status", AppointmentStatus);

              object Exec =  cmd.ExecuteNonQuery();
                if (Exec!=null && int.TryParse(Exec.ToString() , out int NumOfAffectedRows) && NumOfAffectedRows >0 )
                {
                    res = true;
                }

            }
            catch
            { }
            finally
            {
                connection.Close();
            }

            return res; 

        }

    }
}
